using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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

        public AuthController(IConfiguration configuration)
        {
            _configuration = configuration;
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
            var password = users.FirstOrDefault(u => u.Username == loginUser.Username)?.Password;

            var dataToHash = loginUser.Username + nonceHeader + timestampHeader;
            string hash_pwd = HMACSHA256Encrypt(password, dataToHash, Encoding.UTF8);

            if (hash_pwd != loginUser.Password_hash)
                return Unauthorized("Invalid username or password.");

            string token = CreateToken(loginUser);

            ResponseTokenParam response = new ResponseTokenParam();
            response.token = token;
            response.expiry = 120; // 2 hours in minutes

            ResponseEntity ret = new ResponseEntity();
            ret.Success(response);

            return Ok(ret);
        }

        private string CreateToken(UserDto user)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, user.Username),
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
        public static string HMACSHA256Encrypt(string key, string input, Encoding encoding)
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
