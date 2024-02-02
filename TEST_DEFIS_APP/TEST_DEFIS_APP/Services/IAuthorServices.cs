using TEST_DEFIS_APP.Models;

namespace TEST_DEFIS_APP.Services
{
    public interface IAuthorServices
    {
        void CreateAuthor(Auteur author);
        void UpdateAuthor(Auteur author);
        void DeleteAuthor(Guid id);
        List<Auteur> SearchAuthorByMotCle(string motcle);
        List<Auteur> GetAllAuthor();
        List<Auteur> GetAllAuthorDelete();
    }
}
