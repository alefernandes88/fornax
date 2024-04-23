using fornax.Controllers.DTO;
using fornax.Core.Base;
using fornax.Core.Entities;
using System;
using System.Data;

namespace fornax.Core.Domain.Mappers
{
    public class UserMapper : Mapper<User, UserDTO>
    {
        public override UserDTO mapFrom(User param)
        {
            UserDTO usuDTO = new UserDTO();
            usuDTO.Id = param.Id;
            usuDTO.Name = param.Name;
            usuDTO.Email = param.Email;
            usuDTO.Initial_date = param.InitialDate;
            return usuDTO;
        }

        public override User mapTo(UserDTO param)
        {
            User user = new User();
            user.Name = param.Name;
            user.Email = param.Email;
            user.Pass = param.Pass;
            user.InitialDate = DateTime.Now;
            return user;
        }
    }
}
