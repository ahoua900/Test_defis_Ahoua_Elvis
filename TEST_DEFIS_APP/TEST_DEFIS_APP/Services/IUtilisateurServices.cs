using TEST_DEFIS_APP.Models;

namespace TEST_DEFIS_APP.Services
{
    public interface IUtilisateurServices
    {
       void CreateUser(UserModel user);
       void UpdateUser(UserModel user);
       void DeleteUser(Guid id);
       List<UserModel> GetUsersDelete();
       List<UserModel> GetUsersActifs();
       UserModel GetUserSelect(Guid id);
    }
}
