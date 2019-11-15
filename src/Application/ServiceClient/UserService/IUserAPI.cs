using Model.POCOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Refit;

namespace Application.ServiceClient.UserService
{
    public interface IUserAPI
    {
        [Get("/users/{id}")]
        public Task<User> GetUser(int id);
        [Get("/users")]
        public Task<IEnumerable<User>> GetUsers();
    }
}
