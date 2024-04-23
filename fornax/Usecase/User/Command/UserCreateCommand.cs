using fornax.Controllers.DTO;
using fornax.Core.Domain.Mappers;
using fornax.Core.Entities;

namespace fornax.Usecase.UserCase.Command
{
    public class UserCreateCommand : UserUseCase
    {
        public void CreatedUser(UserDTO user)
        {
            User u = new UserMapper().mapTo(user);
            _remoteData.create(u);
        }
    }
}
