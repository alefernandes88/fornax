using fornax.Core.Entities;
using System;
using System.Linq;

namespace fornax.Infra.DB.Models
{
    public class StartedDB
    {
        public static void Started(UserContext context)
        {
            context.Database.EnsureCreated();
            
            if(context.Users.Any())
            {
                return;
            }

            var user = new User
            {
                    Name  = "alessandro fernandes",
                    Email = "san-linux@hotmail.com",
                    Pass  = "123456",
                    InitialDate = DateTime.Now
            };

            context.Users.Add(user);

        }
    }
}
