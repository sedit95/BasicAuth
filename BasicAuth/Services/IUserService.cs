using BasicAuth.Models.UsersModels;
using System.Collections.Generic;

namespace BasicAuth.Services
{
    public interface IUserService 
    { 
        UserModel Authenticate(string userName, string password); 
        List<UserModel> GetAll(); 
    }
}
