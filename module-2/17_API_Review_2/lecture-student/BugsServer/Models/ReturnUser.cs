namespace BugsServer.Models
{
    /// <summary>
    /// Contains just the properties to return for a logged in user
    /// </summary>
    public class ReturnUser
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Role { get; set; }
        public string Token { get; set; }
    }
}
