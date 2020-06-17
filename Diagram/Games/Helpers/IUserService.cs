namespace MongoDBGames.Helpers
{
    public interface IUserService
    {
        bool IsValidUser(string userName, string password);
    }
}
