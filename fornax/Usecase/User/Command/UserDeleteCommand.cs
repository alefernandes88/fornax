namespace fornax.Usecase.UserCase.Command
{
    public class UserDeleteCommand : UserUseCase
    {
        public void deletarUser(int id) => _remoteData.delete(id);
    }
}
