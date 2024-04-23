using fornax.Controllers.DTO;
using fornax.Core.Domain.Mappers;
using fornax.Core.Entities;
using Microsoft.AspNetCore.Http;

namespace fornax.Usecase.UserCase.Command
{
    public class UserUpdateCommand : UserUseCase
    {
        public void updateUser(UserDTO user)
        {
            try
            {
                User u = new UserMapper().mapTo(user);
                int id = (int)user.Id;
                _remoteData.update(id, u);
            } catch(BadHttpRequestException e)
            {
                throw new BadHttpRequestException(e.Message);
            }
            
        }
    }
}
