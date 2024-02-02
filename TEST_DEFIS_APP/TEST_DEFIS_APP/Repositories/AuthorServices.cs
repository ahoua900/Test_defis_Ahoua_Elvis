using Microsoft.EntityFrameworkCore;
using TEST_DEFIS_APP.DataAccess;
using TEST_DEFIS_APP.Models;
using TEST_DEFIS_APP.Services;

namespace TEST_DEFIS_APP.Repositories
{
    public class AuthorServices : IAuthorServices
    {
        private readonly MoviesDbContext _dbContext;

        public AuthorServices(MoviesDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void CreateAuthor(Auteur author)
        {
            _dbContext.Auteurs.Add(author);
        }

        public void DeleteAuthor(Guid id)
        {
            Auteur auteur = _dbContext.Auteurs.Single(s => s.id == id);
            if (auteur != null) {
                auteur.est_actif = false;
                _dbContext.Auteurs.Update(auteur);
            }
        }

        public List<Auteur> GetAllAuthor()
        {
            return _dbContext.Auteurs.Where(s => s.est_actif).ToList();
        }

        public List<Auteur> GetAllAuthorDelete()
        {
            return _dbContext.Auteurs.Where(s=>!s.est_actif).ToList();
        }

        public List<Auteur> SearchAuthorByMotCle(string motcle)
        {
            return _dbContext.Auteurs.Where(s => s.libelle.Contains(motcle) || s.code.Contains(motcle)).ToList();
        }
        public void UpdateAuthor(Auteur author)
        {
            _dbContext.Update(author);
        }
    }
}
