using DataSecurity.Cli.DAL;
using DataSecurity.Cli.Model;
using DataSecurity.Cli.Security;
using Microsoft.Extensions.Configuration;

namespace DataSecurity.Cli
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string connectionString = LoadConnectionString();

            IPasswordHasher passwordHasher = new PasswordHasher();
            IUserDao userDao = new UserSqlDAO(connectionString, passwordHasher);

            UserManagerCli application = new UserManagerCli(userDao);

            application.Run();
        }

        private static string LoadConnectionString()
        {
            IConfiguration config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();

            string connectionString = config.GetConnectionString("UserManagerConnection");
            return connectionString;
        }
    }
}
