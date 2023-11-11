using MarketPlace.DTOs;
using MarketPlace.Entities;
using MarketPlace.Services.Interfaces;
using MarketPlace.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace.Services
{
    internal class UserService : IUserService
    {
        private string _filePath;
        private List<Client> _clients;
        private Serialization<Client> _serialization;

        public UserService(string filePath)
        {
            _serialization = new Serialization<Client>();
            _filePath = filePath;
            _clients = _serialization.DeserializeFromJsonFile(_filePath);

        }
        public bool LoginUser(LoginDto login)
        {
            return _clients.Any(c => c.Email == login.Email && c.Password == login.Password);
        }

        public bool RegisterUser(RegisterDto register)
        {
            try
            {
                Client client = new Client()
                {
                    Id = Storage.AutoEncrementValues.AutoEncrementClient++,
                    UserName = register.UserName,
                    Email = register.Email,
                    Password = register.Password,
                    WalletBalance = 0,
                };

                _clients.Add(client);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
