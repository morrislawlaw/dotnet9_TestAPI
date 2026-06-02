using ACXBookingSystem.Entities;
using Anderson_Road.Entities;
using Anderson_Road.Models;
using dotnet9_TestAPI.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Google;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

namespace dotnet9_TestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly ACXBookingSystemDbContext _context;

        public AuthController(IConfiguration configuration, ACXBookingSystemDbContext context)
        {
            _configuration = configuration;
            _context = context;
        }

        private static List<User> users = new List<User>
        {
            new User { Username = "admin", Password = "password" }
        };

        public class ResponseTokenParam
        {
            public string? token { get; set; }
            public int expiry { get; set; }
        }

        [HttpPost]
        [Route("Loginv2")]
        public async Task<ActionResult<ApiResponse<ResponseTokenParam>>> Loginv2([FromBody] UserDto dto)
        {
            if (dto == null)
                return Ok(ApiResponse<object>.Error(-1, "Invalid input parameters."));

            // Retrieving headers
            var timestampHeader = Request.Headers["timestamp"].ToString();
            var nonceHeader = Request.Headers["nonce"].ToString();

            // Validate headers
            if (string.IsNullOrEmpty(timestampHeader) || string.IsNullOrEmpty(nonceHeader))
                return Ok(ApiResponse<object>.Error(-1, "Missing timestamp or nonce in headers."));

            //find the password in DB based on the user_id
            var password = await _context.Users.Where(v => v.UserName == dto.user_id).Select(v => v.Password.ToString()).FirstOrDefaultAsync();
            if(password == null)
                return Ok(ApiResponse<object>.Error(-1, "User does not exist."));

            var dataToHash = dto.user_id + nonceHeader + timestampHeader;
            string hash_pwd = HMACSHA256Encrypt(password, dataToHash, Encoding.UTF8);

            if (hash_pwd != dto.password)
                return Ok(ApiResponse<object>.Error(-1, "Invalid username or password."));

            string token = CreateToken(dto);

            ResponseTokenParam response = new ResponseTokenParam();
            response.token = token;
            response.expiry = 120; // 2 hours in minutes

            return Ok(ApiResponse<ResponseTokenParam>.Success(response));
        }

        [HttpPost]
        [Route("Login")]
        public ActionResult<ResponseEntity> Login(UserDto loginUser)
        {
            // Retrieving headers
            var timestampHeader = Request.Headers["timestamp"].ToString();
            var nonceHeader = Request.Headers["nonce"].ToString();

            // Validate headers
            if (string.IsNullOrEmpty(timestampHeader) || string.IsNullOrEmpty(nonceHeader))           
                return BadRequest("Missing timestamp or nonce in headers.");
            
            if (loginUser is null)
                return BadRequest("Invalid input parameters.");

            //password in DB
            var password = users.FirstOrDefault(u => u.Username == loginUser.user_id)?.Password;

            var dataToHash = loginUser.user_id + nonceHeader + timestampHeader;
            string hash_pwd = HMACSHA256Encrypt(password, dataToHash, Encoding.UTF8);

            if (hash_pwd != loginUser.password)
                return Unauthorized("Invalid username or password.");

            string token = CreateToken(loginUser);

            ResponseTokenParam response = new ResponseTokenParam();
            response.token = token;
            response.expiry = 120; // 2 hours in minutes

            ResponseEntity ret = new ResponseEntity();
            ret.Success(response);

            return Ok(ret);
        }

        // ==================== NEW: GOOGLE LOGIN ====================

        [HttpGet("google")]
        public IActionResult GoogleLogin()
        {
            var properties = new AuthenticationProperties
            {
                RedirectUri = Url.Action("GoogleCallback", "Auth")
            };
            return Challenge(properties, GoogleDefaults.AuthenticationScheme);
        }

        [HttpGet("google-callback")]
        public async Task<IActionResult> GoogleCallback()
        {
            var result = await HttpContext.AuthenticateAsync(GoogleDefaults.AuthenticationScheme);

            if (result?.Succeeded != true || result.Principal == null)
                return BadRequest(new { message = "Google authentication failed." });

            var email = result.Principal.FindFirst(ClaimTypes.Email)?.Value;
            var name = result.Principal.FindFirst(ClaimTypes.Name)?.Value;
            var picture = result.Principal.FindFirst("picture")?.Value;

            if (string.IsNullOrEmpty(email))
                return BadRequest(new { message = "Failed to get email from Google." });

            // Reuse your existing CreateToken method
            var userDto = new UserDto { user_id = email };

            string token = CreateToken(userDto);

            // Redirect back to frontend with token in query string
            return Redirect($"https://488865.xyz/?token={token}");
        }

        private string CreateToken(UserDto user)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, user.user_id),
                new Claim(ClaimTypes.Role, "Admin")
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration.GetValue<string>("Jwt:Key")!));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var tokenDescriptor = new JwtSecurityToken(
                issuer: _configuration["Jwt:Issuer"],
                audience: _configuration["Jwt:Audience"],
                claims: claims,
                expires: DateTime.Now.AddHours(2),
                signingCredentials: creds
            );

            return new JwtSecurityTokenHandler().WriteToken(tokenDescriptor);
        }

        private static string HashEncrypt(HashAlgorithm hashAlgorithm, string input, Encoding encoding)
        {
            var data = hashAlgorithm.ComputeHash(encoding.GetBytes(input));

            return BitConverter.ToString(data).Replace("-", "").ToLower();
        }

        /// <summary>
        /// HMAC-SHA256 加密
        /// </summary>
        /// <param name="input"> 要加密的字符串 </param>
        /// <param name="key"> 密钥 </param>
        /// <param name="encoding"> 字符编码 </param>
        /// <returns></returns>
        /// 
        //public static string HMACSHA256Encrypt(string key, string input, Encoding encoding)
        public static string HMACSHA256Encrypt(string input, string key, Encoding encoding)
        {
            Console.WriteLine("key: " + key);
            Console.WriteLine("input: " + input);
            return HashEncrypt(new HMACSHA256(encoding.GetBytes(key)), input, encoding);
        }

        private const string AllowedChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";

        // Function to generate a random string token
        public static string GenerateToken(int length)
        {
            if (length <= 0)
                throw new ArgumentException("Length must be greater than zero.", nameof(length));

            // Using a cryptographic random number generator
            using (var rng = new RNGCryptoServiceProvider())
            {
                var tokenBytes = new byte[length];
                rng.GetBytes(tokenBytes);

                // Convert bytes to a string using allowed characters
                return new string(Enumerable.Range(0, length)
                    .Select(i => AllowedChars[tokenBytes[i] % AllowedChars.Length])
                    .ToArray());
            }
        }

    }
}
