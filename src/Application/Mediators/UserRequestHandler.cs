using System.Threading;
using System.Threading.Tasks;
using Application.ServiceClient.UserService;
using MediatR;

namespace Application.Mediators
{
    public class UserRequestHandler : IRequestHandler<UserRequest, UserResponse>
    {
        private readonly IUserService _userService;
        public UserRequestHandler(IUserService userService)
        {
            _userService = userService;
        }
        public async Task<UserResponse> Handle(UserRequest request, CancellationToken cancellationToken)
        {
            return new UserResponse { User = await _userService.GetUser(request.Id) };
        }
    }
}
