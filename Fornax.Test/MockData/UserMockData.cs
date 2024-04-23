using fornax.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fornax.Test.MockData
{
    internal class UserMockData
    {
        public static List<User> getUser()
        {
            return new List<User>()
            {
                new User
                {
                    Name = "Test",
                    Email = "teste@teste.com",
                    Id = 1,
                    Pass = "123456",
                    InitialDate = DateTime.Now,
                },
                new User
                {
                    Name = "Test2",
                    Email = "teste2@teste.com",
                    Id = 2,
                    Pass = "123456",
                    InitialDate = DateTime.Now,
                }
            };
        }
    }
}
