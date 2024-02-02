using System.Reflection;
using TEST_DEFIS_APP.DataAccess;
using TEST_DEFIS_APP.Models;
using TEST_DEFIS_APP.Services;

namespace TEST_DEFIS_APP.Repositories
{
    public class FIlmsServices : IFilmsServices
    {
        private readonly MoviesDbContext _dbContext;

        public FIlmsServices(MoviesDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void CreateFilms(Films films)
        {
            _dbContext.Films.Add(films);
        }

        public void DeleteFilms(Guid id)
        {
            Films film = _dbContext.Films.Single(s => s.Id == id);
            if (film != null)
            {
                film.EstActif = false;
                _dbContext.Films.Update(film);
            }
        }

        public List<Films> SearchFilms(string motcle)
        {
            return _dbContext.Films.Where(s => s.Titre.Contains(motcle) || s.Code.Contains(motcle)).ToList();
        }

        public List<Films> SearchFilmsByAuthors(string nomauthor)
        {
            return _dbContext.Films.Where(s => s.Auteur.code.Contains(nomauthor) || s.Auteur.libelle.Contains(nomauthor)).ToList();
        }

        public void UpgradeFilms(Films films)
        {
            throw new NotImplementedException();
        }
    }
}
