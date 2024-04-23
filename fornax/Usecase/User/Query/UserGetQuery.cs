using fornax.Core.Entities;
using fornax.Data.Remote;

namespace fornax.Usecase.UserCase.Query
{
    public class UserGetQuery : UserUseCase
    {
        public  User getUser(int id) => _remoteData.get(id);    
    }
}
