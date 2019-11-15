using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Model.POCOs;
using Refit;

namespace Application.ServiceClient.UserService
{
    public class UserRefitService : IUserService
    {
        public Task<IEnumerable<User>> GetUsers()
        {
            var jsonPlaceholderAPI = RestService.For<IUserAPI>("https://jsonplaceholder.typicode.com");
            return jsonPlaceholderAPI.GetUsers();
        }
        public Task<User> GetUser(int Id)
        {
            var jsonPlaceholderAPI = RestService.For<IUserAPI>("https://jsonplaceholder.typicode.com");
            return jsonPlaceholderAPI.GetUser(Id);
        }
    }
}
