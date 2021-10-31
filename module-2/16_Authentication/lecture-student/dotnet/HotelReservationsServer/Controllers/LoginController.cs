using HotelReservations.DAO;
using HotelReservations.Security;
using HotelReservations.Models;
using Microsoft.AspNetCore.Mvc;

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

        // Add an endpoint to check to see what user ID we have (User.FindFirst "sub")
    }
}
