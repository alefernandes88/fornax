using fornax.Core.Entities;
using fornax.Data.Remote;
using System.Collections.Generic;

namespace fornax.Usecase.UserCase.Query
{
    public class UserGetAllQuery : UserUseCase
    {
        public List<User> getAll() => _remoteData.getAll();
    }
}
