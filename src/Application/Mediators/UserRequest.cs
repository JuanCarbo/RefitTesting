using System;
using System.Collections.Generic;
using System.Text;
using MediatR;

namespace Application.Mediators
{
    public class UserRequest : IRequest<UserResponse>
    {
        public int Id { get; set; }
    }
}
