using MarketPlace.DTOs;
using MarketPlace.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace.Services.Interfaces
{
    internal interface IUserService
    {
        public bool RegisterUser(RegisterDto register);
        public bool LoginUser(LoginDto login);
    }
}
