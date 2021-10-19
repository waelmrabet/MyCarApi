using BLL.ServicePattern;
using Core.Models;
using Data.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Services.Impl
{
    public class UserService: ServicePattern<User>, IUserService
    {
        public UserService(IUserRepository userRepo): base(userRepo)
        {
        }
    }
}
