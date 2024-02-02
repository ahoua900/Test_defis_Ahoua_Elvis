using TEST_DEFIS_APP.DataAccess;
using TEST_DEFIS_APP.Models;
using TEST_DEFIS_APP.Services;

namespace TEST_DEFIS_APP.Repositories
{
    public class UtilisateurService : IUtilisateurServices
    {
        private readonly MoviesDbContext _dbContext;

        public UtilisateurService(MoviesDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void CreateUser(UserModel user)
        {
            _dbContext.Add(user);
        }
        public void DeleteUser(Guid id)
        {
            UserModel userselect = _dbContext.UserModels.Single(s => s.id == id);
            if (userselect != null)
            {
                userselect.est_actif = false;
                _dbContext.Update(userselect);
            }
        }
        public List<UserModel> GetUsersActifs()
        {
            return _dbContext.UserModels.Where(_ => _.est_actif).ToList();
        }

        public List<UserModel> GetUsersDelete()
        {
            return _dbContext.UserModels.Where(_ => !_.est_actif).ToList();
        }
        public UserModel GetUserSelect(Guid id)
        {
            return _dbContext.UserModels.Single(s => s.id == id);
        }
        public void UpdateUser(UserModel user)
        {
            _dbContext.Update(user);
        }

    }
}
