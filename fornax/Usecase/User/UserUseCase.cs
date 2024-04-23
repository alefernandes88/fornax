using fornax.Data.Remote;

namespace fornax.Usecase.UserCase
{
    public  abstract class UserUseCase
    {
        public readonly  UserRepositoryRemoteData _remoteData = new UserRepositoryRemoteData();
    }
}
