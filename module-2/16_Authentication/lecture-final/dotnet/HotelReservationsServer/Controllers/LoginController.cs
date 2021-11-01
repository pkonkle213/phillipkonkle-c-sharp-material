using HotelReservations.DAO;
using HotelReservations.Security;
using HotelReservations.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace HotelReservations.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly ITokenGenerator tokenGenerator;
        private readonly IPasswordHasher passwordHasher;
        private readonly IUserDao userDao;

        public LoginController(ITokenGenerator _tokenGenerator, IPasswordHasher _passwordHasher, IUserDao _userDao)
        {
            tokenGenerator = _tokenGenerator;
            passwordHasher = _passwordHasher;
            userDao = _userDao;
        }

        /// <summary>
        /// Authenticates the user and returns a result of their login request
        /// </summary>
        /// <param name="userParam">
        /// The username and password object. Storing this in the body allows us to send it securely via HTTPS
        /// </param>
        /// <returns>The result of the authentication request. This should be a 200 or 400 status code.</returns>
        /// <remarks>
        /// Valid credentials:
        ///     - Username: "user",   Password: "test",  Role: view
        ///     - Username: "johnny", Password: "test",  Role: creator
        ///     - Username: "admin",  Password: "admin", Role: admin
        /// </remarks>
        [HttpPost]
        [AllowAnonymous]
        public IActionResult Authenticate(LoginUser userParam)
        {
            // Default to bad username/password message
            // Get the user by username
            User user = userDao.GetUser(userParam.Username);

            // If we found a user and the password hash matches
            if (user != null && passwordHasher.VerifyHashMatch(user.PasswordHash, userParam.Password, user.Salt))
            {
                // Create an authentication token
                string token = tokenGenerator.GenerateToken(user.Id, user.Username, user.Role);

                // Create a ReturnUser object to return to the client
                ReturnUser retUser = new ReturnUser { 
                    Id = user.Id, 
                    Username = user.Username, 
                    Role = user.Role, 
                    Token = token 
                };

                // Tell the user we're authenticated
                return Ok(retUser);
            }

            return BadRequest(new { message = "Username or password is incorrect" });
        }

        // Add an endpoint to check to see what user name we have (User.Identity.Name)
        [HttpGet] // GET login
        [AllowAnonymous]
        public ActionResult GetInfoAboutUser()
        {
            var user = this.User;

            if (user.Identity.Name != null)
            {
                if (user.Identity.Name == "hackerman")
                {
                    return Forbid("Hackers go home."); // 403
                }

                var idClaim = user.FindFirst("sub"); // "sub": "3" (sub is subject, or the user's ID)
                string idString = idClaim.Value; // "3"
                int id = int.Parse(idString); // 3

                return Ok("Hello " + user.Identity.Name + " your user id is " + id);
            }
            else
            {
                return Ok("I have no idea who you are");
            }
        }

        // Add an endpoint to check to see what user ID we have (User.FindFirst "sub")
        [HttpGet("test")] // GET login/test
        [Authorize] // Only authenticated users can call this method
        public ActionResult TestAuthentication()
        {
            return Ok("You apparently are authenticated!");
        }

        [HttpGet("test/admin")] // GET login/test/admin
        [Authorize(Roles="admin")] // Only authenticated users with a role of "admin" can call this method
        public ActionResult TestAdminAuthentication()
        {
            return Ok("You must be an admin. Wow!");
        }

        // GET accounts/42/balance
    }
}
