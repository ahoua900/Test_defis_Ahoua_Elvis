using TEST_DEFIS_APP.Models;

namespace TEST_DEFIS_APP.Services
{
    public interface IFilmsServices
    {
        void CreateFilms(Films films);
        void DeleteFilms(Guid id);
        void UpgradeFilms(Films films);
        List<Films> SearchFilms(string motcle);
        List<Films> SearchFilmsByAuthors(string nomauthor);
    }
}
