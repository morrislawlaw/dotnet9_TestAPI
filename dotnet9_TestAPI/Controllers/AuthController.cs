using ACXBookingSystem.Entities;
using Anderson_Road.Entities;
using Anderson_Road.Models;
using dotnet9_TestAPI.Entities.HotelBookingSystem;
using dotnet9_TestAPI.Models;
using HotelBookingSystem.Entities;
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
using BCryptNet = BCrypt.Net.BCrypt;

namespace dotnet9_TestAPI.Controllers
{
    [Route("api/auth")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly HotelBookingSystemDbContext _context;

        public AuthController(IConfiguration configuration, HotelBookingSystemDbContext context)
        {
            _configuration = configuration;
            _context = context;
        }

        //private static List<User> users = new List<User>
        //{
        //    new User { Username = "admin", Password = "password" }
        //};

        public class ResponseTokenParam
        {
            public string? Token { get; set; }
            public int Expiry { get; set; }
        }

        //public class ResponseTokenParam
        //{
        //    public string? token { get; set; }
        //    public int expiry { get; set; }
        //}

        // ===================================================
        // 1. STANDARD REGISTRATION HANDLER
        // ===================================================
        [HttpPost("register")]
        public async Task<ActionResult<ApiResponse<object>>> Register([FromBody] RegisterDto dto)
        {
            if (dto == null || string.IsNullOrEmpty(dto.Email) || string.IsNullOrEmpty(dto.Password))
            {
                return Ok(ApiResponse<object>.Error(-1, "Invalid input parameters."));
            }

            // Use a database transaction to ensure both writes succeed together
            using var transaction = await _context.Database.BeginTransactionAsync();
            try
            {
                if (await _context.Users.AnyAsync(u => u.Email == dto.Email))
                {
                    return Ok(ApiResponse<object>.Error(-1, "Email address already registered."));
                }

                // 1. Split name into FirstName and LastName for the Customers table
                string firstName = "Guest";
                string lastName = "User";
                var nameParts = dto.Name.Trim().Split(' ', 2);
                if (nameParts.Length > 0) firstName = nameParts[0];
                if (nameParts.Length > 1) lastName = nameParts[1];

                // 2. Write to your core transactional profile table
                var customer = new Customer
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Email = dto.Email,
                    Phone = dto.Phone,
                    CreatedAt = DateTime.UtcNow // Maps to your datetime2 schema
                };
                _context.Customers.Add(customer);
                await _context.SaveChangesAsync(); // Generates CustomerID[cite: 27]

                // 3. Write to your authentication ledger table
                var user = new Entities.HotelBookingSystem.User
                {
                    Name = dto.Name,
                    Email = dto.Email,
                    Phone = dto.Phone,
                    PasswordHash = BCryptNet.HashPassword(dto.Password),
                    Status = "Active",
                    CreatedAt = DateTime.UtcNow
                };
                _context.Users.Add(user);
                await _context.SaveChangesAsync();

                await transaction.CommitAsync();
                return Ok(ApiResponse<object>.Success("Registration successful."));

                //var user = new Entities.HotelBookingSystem.User
                //{
                //    Name = dto.Name,
                //    Email = dto.Email,
                //    Phone = dto.Phone,
                //    PasswordHash = BCryptNet.HashPassword(dto.Password), // Secure enterprise salt & hash compilation
                //    Status = "Active",
                //    CreatedAt = DateTime.UtcNow
                //};

                //_context.Users.Add(user);
                //await _context.SaveChangesAsync();

                //return Ok(ApiResponse<object>.Success("Registration successful."));
            }
            catch (Exception ex)
            {
                await transaction.RollbackAsync();
                return StatusCode(500, new { message = "Registration processing failed.", details = ex.Message });
            }


        }

        // ===================================================
        // 2. UPDATED STANDARD LOGIN (Loginv2)
        // ===================================================
        [HttpPost("Loginv2")]
        public async Task<ActionResult<ApiResponse<ResponseTokenParam>>> Loginv2([FromBody] UserDto dto)
        {
            if (dto == null || string.IsNullOrEmpty(dto.user_id) || string.IsNullOrEmpty(dto.password))
            {
                return Ok(ApiResponse<object>.Error(-1, "Invalid input parameters."));
            }

            // Look up account inside your unified HotelBookingSystem database context
            var user = await _context.Users.FirstOrDefaultAsync(u => u.Email == dto.user_id);

            if (user == null)
            {
                return Ok(ApiResponse<object>.Error(-1, "User account does not exist."));
            }

            if (user.Status != "Active")
            {
                return Ok(ApiResponse<object>.Error(-1, "Account has been suspended."));
            }

            if (string.IsNullOrEmpty(user.PasswordHash))
            {
                return Ok(ApiResponse<object>.Error(-1, "This account uses social sign-in. Please log in with Google."));
            }

            // Verify input matches cryptographic store values securely via BCrypt
            bool isPasswordValid = BCryptNet.Verify(dto.password, user.PasswordHash);

            if (!isPasswordValid)
            {
                return Ok(ApiResponse<object>.Error(-1, "Invalid username or password."));
            }

            // Document audit metadata login timestamp metrics
            user.LastLoginAt = DateTime.UtcNow;
            await _context.SaveChangesAsync();

            string jwtToken = CreateToken(user.Email);

            var response = new ResponseTokenParam
            {
                Token = jwtToken,
                Expiry = 120 // 2 hours session representation
            };

            return Ok(ApiResponse<ResponseTokenParam>.Success(response));
        }

        //[HttpPost]
        //[Route("Loginv2")]
        //public async Task<ActionResult<ApiResponse<ResponseTokenParam>>> Loginv2([FromBody] UserDto dto)
        //{
        //    if (dto == null)
        //        return Ok(ApiResponse<object>.Error(-1, "Invalid input parameters."));

        //    // Retrieving headers
        //    var timestampHeader = Request.Headers["timestamp"].ToString();
        //    var nonceHeader = Request.Headers["nonce"].ToString();

        //    // Validate headers
        //    if (string.IsNullOrEmpty(timestampHeader) || string.IsNullOrEmpty(nonceHeader))
        //        return Ok(ApiResponse<object>.Error(-1, "Missing timestamp or nonce in headers."));

        //    //find the password in DB based on the user_id
        //    var password = await _context.Users.Where(v => v.UserName == dto.user_id).Select(v => v.Password.ToString()).FirstOrDefaultAsync();
        //    if(password == null)
        //        return Ok(ApiResponse<object>.Error(-1, "User does not exist."));

        //    var dataToHash = dto.user_id + nonceHeader + timestampHeader;
        //    string hash_pwd = HMACSHA256Encrypt(password, dataToHash, Encoding.UTF8);

        //    if (hash_pwd != dto.password)
        //        return Ok(ApiResponse<object>.Error(-1, "Invalid username or password."));

        //    string token = CreateToken(dto);

        //    ResponseTokenParam response = new ResponseTokenParam();
        //    response.token = token;
        //    response.expiry = 120; // 2 hours in minutes

        //    return Ok(ApiResponse<ResponseTokenParam>.Success(response));
        //}

        //[HttpPost]
        //[Route("Login")]
        //public ActionResult<ResponseEntity> Login(UserDto loginUser)
        //{
        //    // Retrieving headers
        //    var timestampHeader = Request.Headers["timestamp"].ToString();
        //    var nonceHeader = Request.Headers["nonce"].ToString();

        //    // Validate headers
        //    if (string.IsNullOrEmpty(timestampHeader) || string.IsNullOrEmpty(nonceHeader))           
        //        return BadRequest("Missing timestamp or nonce in headers.");

        //    if (loginUser is null)
        //        return BadRequest("Invalid input parameters.");

        //    //password in DB
        //    var password = users.FirstOrDefault(u => u.Username == loginUser.user_id)?.Password;

        //    var dataToHash = loginUser.user_id + nonceHeader + timestampHeader;
        //    string hash_pwd = HMACSHA256Encrypt(password, dataToHash, Encoding.UTF8);

        //    if (hash_pwd != loginUser.password)
        //        return Unauthorized("Invalid username or password.");

        //    string token = CreateToken(loginUser);

        //    ResponseTokenParam response = new ResponseTokenParam();
        //    response.token = token;
        //    response.expiry = 120; // 2 hours in minutes

        //    ResponseEntity ret = new ResponseEntity();
        //    ret.Success(response);

        //    return Ok(ret);
        //}

        // ==================== NEW: GOOGLE LOGIN ====================

        [HttpGet("google")]
        public IActionResult GoogleLogin()
        {
            //var properties = new AuthenticationProperties
            //{
            //    RedirectUri = Url.Action("GoogleCallback", "Auth")
            //};

            //var properties = new AuthenticationProperties
            //{
            //    // Explicitly set the exact redirect URI that matches Google Console
            //    RedirectUri = "https://488865.xyz/api/auth/google-callback"
            //};
            var properties = new AuthenticationProperties
            {
                // 🔥 FIX: Match your actual endpoint path exactly!
                RedirectUri = "https://488865.xyz/api/auth/google-success"
            };

            return Challenge(properties, GoogleDefaults.AuthenticationScheme);
        }

        //[HttpGet("google-callback")]
        //[HttpGet("google-success")]
        //public async Task<IActionResult> GoogleCallback()
        //{
        //    try
        //    {
        //        var result = await HttpContext.AuthenticateAsync(GoogleDefaults.AuthenticationScheme);

        //        if (result?.Succeeded != true || result.Principal == null)
        //            return BadRequest(new { message = "Google authentication failed." });

        //        var email = result.Principal.FindFirst(ClaimTypes.Email)?.Value;
        //        var name = result.Principal.FindFirst(ClaimTypes.Name)?.Value;
        //        var picture = result.Principal.FindFirst("picture")?.Value;

        //        if (string.IsNullOrEmpty(email))
        //            return BadRequest(new { message = "Failed to get email from Google." });

        //        // Reuse your existing CreateToken method
        //        var userDto = new UserDto { user_id = email };
        //        string token = CreateToken(userDto);

        //        // Check if the request came from a local environment context or default to production
        //        //var referer = Request.Headers["Referer"].ToString();
        //        //if (!string.IsNullOrEmpty(referer) && referer.Contains("localhost:5173"))
        //        //{
        //        //    // Bounces back to your local development server
        //        //    return Redirect($"http://localhost:5173/?token={token}");
        //        //}

        //        // Fallback default redirect to production frontend
        //        return Redirect($"https://488865.xyz/?token={token}");
        //    }
        //    catch (Exception ex)
        //    {
        //        // 🔥 This will catch the crash and show the real error details on your webpage!
        //        return StatusCode(500, new
        //        {
        //            message = "An error occurred inside GoogleCallback",
        //            errorDetails = ex.Message,
        //            stackTrace = ex.StackTrace
        //        });
        //    }
        //}

        // ===================================================
        // 4. REVISED GOOGLE SUCCESS PROCESSING SUITE
        // ===================================================
        [HttpGet("google-success")]
        public async Task<IActionResult> GoogleCallback()
        {
            try
            {
                var result = await HttpContext.AuthenticateAsync(GoogleDefaults.AuthenticationScheme);

                if (result?.Succeeded != true || result.Principal == null)
                {
                    return BadRequest(new { message = "Google authentication failed." });
                }

                var email = result.Principal.FindFirst(ClaimTypes.Email)?.Value;
                var name = result.Principal.FindFirst(ClaimTypes.Name)?.Value ?? "Google User";

                if (string.IsNullOrEmpty(email))
                {
                    return BadRequest(new { message = "Failed to extract verified email context from Google profile." });
                }

                // Pull user profile out, eager loading federated configuration matrix links
                var user = await _context.Users.Include(u => u.UserLogins).FirstOrDefaultAsync(u => u.Email == email);

                if (user == null)
                {
                    using var transaction = await _context.Database.BeginTransactionAsync();
                    try
                    {

                        //// USER DOES NOT EXIST: Dynamically provision clean system account profile
                        //user = new Entities.HotelBookingSystem.User
                        //{
                        //    Name = name,
                        //    Email = email,
                        //    Status = "Active",
                        //    CreatedAt = DateTime.UtcNow,
                        //    LastLoginAt = DateTime.UtcNow
                        //};
                        //_context.Users.Add(user);
                        //await _context.SaveChangesAsync(); // Commit to extract tracking primary row keys

                        //// Map structural tracking link parameter relations to prevent account collisions
                        //var loginLink = new UserLogin
                        //{
                        //    UserId = user.Id,
                        //    LoginProvider = "Google",
                        //    ProviderKey = email
                        //};
                        //_context.UserLogins.Add(loginLink);
                        //await _context.SaveChangesAsync();

                        // Ensure a profile exists inside the transactional Customers table[cite: 27]
                        var customerExists = await _context.Customers.AnyAsync(c => c.Email == email);
                        if (!customerExists)
                        {
                            string firstName = "Google";
                            string lastName = "User";
                            var nameParts = name.Trim().Split(' ', 2);
                            if (nameParts.Length > 0) firstName = nameParts[0];
                            if (nameParts.Length > 1) lastName = nameParts[1];

                            var newCustomer = new Customer
                            {
                                FirstName = firstName,
                                LastName = lastName,
                                Email = email,
                                CreatedAt = DateTime.UtcNow
                            };
                            _context.Customers.Add(newCustomer);
                            await _context.SaveChangesAsync();
                }

                        // Provision identity user context account record
                        user = new Entities.HotelBookingSystem.User
                        {
                            Name = name,
                            Email = email,
                            Status = "Active",
                            CreatedAt = DateTime.UtcNow,
                            LastLoginAt = DateTime.UtcNow
                        };
                        _context.Users.Add(user);
                        await _context.SaveChangesAsync();

                        var loginLink = new UserLogin
                        {
                            UserId = user.Id,
                            LoginProvider = "Google",
                            ProviderKey = email
                        };
                        _context.UserLogins.Add(loginLink);
                        await _context.SaveChangesAsync();

                        await transaction.CommitAsync();

                    }
                    catch
                    {
                        await transaction.RollbackAsync();
                        throw;
                    }
                }
                else
                {
                    // Account existed. Double check social identity linkage arrays are documented
                    if (!user.UserLogins.Any(l => l.LoginProvider == "Google"))
                    {
                        var loginLink = new UserLogin
                        {
                            UserId = user.Id,
                            LoginProvider = "Google",
                            ProviderKey = email
                        };
                        _context.UserLogins.Add(loginLink);
                    }

                    user.LastLoginAt = DateTime.UtcNow;
                    await _context.SaveChangesAsync();
                }

                if (user.Status != "Active")
                {
                    return BadRequest(ApiResponse<object>.Error(-1, "Account has been suspended."));
                }

                // Compile internal app domain authorization token mapping
                string token = CreateToken(user.Email);

                // Safe structural bounce straight back to production frontend domain root
                return Redirect($"https://488865.xyz/?token={token}");
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "Error inside GoogleCallback processing pipeline.", errorDetails = ex.Message });
            }
        }

        // Framework JWT processing token engine
        private string CreateToken(string email)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, email),
                new Claim(ClaimTypes.Role, "User")
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration.GetValue<string>("Jwt:Key")!));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var tokenDescriptor = new JwtSecurityToken(
                issuer: _configuration["Jwt:Issuer"],
                audience: _configuration["Jwt:Audience"],
                claims: claims,
                expires: DateTime.UtcNow.AddHours(2),
                signingCredentials: creds
            );

            return new JwtSecurityTokenHandler().WriteToken(tokenDescriptor);
        }

        //private string CreateToken(UserDto user)
        //{
        //    var claims = new List<Claim>
        //    {
        //        new Claim(ClaimTypes.Name, user.user_id),
        //        new Claim(ClaimTypes.Role, "Admin")
        //    };

        //    var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration.GetValue<string>("Jwt:Key")!));
        //    var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

        //    var tokenDescriptor = new JwtSecurityToken(
        //        issuer: _configuration["Jwt:Issuer"],
        //        audience: _configuration["Jwt:Audience"],
        //        claims: claims,
        //        expires: DateTime.Now.AddHours(2),
        //        signingCredentials: creds
        //    );

        //    return new JwtSecurityTokenHandler().WriteToken(tokenDescriptor);
        //}

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
