using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MongoDBGames.Helpers
{

    public interface IUserService
    {
        bool IsValidUser(string userName, string password);
    }

}
