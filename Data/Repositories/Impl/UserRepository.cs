using Core.Models;
using Data.Pattern;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Repositories.Impl
{
    public class UserRepository: Repository<User>, IUserRepository
    {
        public UserRepository(MyDataBaseContext dbCtx):base(dbCtx) {  }

    }
}
