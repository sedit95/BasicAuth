using BasicAuth.Models.UsersModels;
using System.Collections.Generic;
using System.Linq;

namespace BasicAuth.Services
{
    public class UserService : IUserService
    {

        private List<UserModel> _users = new List<UserModel>()
        {new UserModel {Id = 1, FirstName = "Murat", LastName = "Suzen", UserName = "murat", Password = "1234"}};

   

        UserModel IUserService.Authenticate(string userName, string password)
        {
            var user = _users.FirstOrDefault(x => x.UserName == userName && x.Password == password);
            return user;
        }

        public List<UserModel> GetAll()
        {
            return _users;
        }
    }
}
