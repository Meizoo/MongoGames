using Microsoft.Extensions.Logging;

namespace MongoDBGames.Helpers
{
    public class UserService : IUserService
    {
        private readonly ILogger<UserService> _logger;

        public UserService(ILogger<UserService> logger) => 
            this._logger = logger;

        public bool IsValidUser(string userName, string password)
        {
            this._logger.LogInformation($"Validating user [{userName}]");
            return !string.IsNullOrWhiteSpace(userName) && !string.IsNullOrWhiteSpace(password);
        }
    }
}
