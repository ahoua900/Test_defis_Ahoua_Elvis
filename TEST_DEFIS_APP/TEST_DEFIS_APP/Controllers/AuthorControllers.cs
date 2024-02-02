using Microsoft.AspNetCore.Mvc;
using TEST_DEFIS_APP.Models;
using TEST_DEFIS_APP.Repositories;

namespace TEST_DEFIS_APP.Controllers
{
    [ApiController]
    public class AuthorControllers : ControllerBase
    {
        public AuthorServices autorsService;
        public AuthorControllers(AuthorServices autorsService)
        {
            this.autorsService = autorsService;
        }
        private readonly ILogger<UtilisateursController> _logger;

        public AuthorControllers(ILogger<UtilisateursController> logger)
        {
            _logger = logger;
        }
        [HttpGet]
        [Route("api/authors/authorsliste")]
        public ActionResult<Auteur> Get_Authors_Actifs()
        {
            _logger.LogInformation("Consultation des auteurs actifs");
            return Ok(autorsService.GetAllAuthor());
        }
        [HttpGet]
        [Route("api/authors/authorsdeletes")]
        public ActionResult<Auteur> Get_Authors_Delete()
        {
            _logger.LogInformation("Consultation des auteurs supprimés");
            return Ok(autorsService.GetAllAuthorDelete());
        }
        [HttpGet]
        [Route("api/authors/searchauthors")]
        public ActionResult<Auteur> Search([FromBody] string motcle)
        {
            _logger.LogInformation("Recherche sur l'auteur {0}", motcle);
            return Ok(autorsService.SearchAuthorByMotCle(motcle));
        }
        [HttpPost]
        [Route("api/authors/createauthors")]
        public ActionResult<Auteur> Create([FromBody] Auteur model)
        {
            _logger.LogInformation("création de l'auteur {0}", model.code);
            autorsService.CreateAuthor(model);
            return Ok();
        }
        [HttpPost]
        [Route("api/authors/updateauthors")]
        public ActionResult<Auteur> Update([FromBody] Auteur model)
        {
            _logger.LogInformation("Modification de l'auteur {0}", model.code);
            autorsService.UpdateAuthor(model);
            return Ok();
        }
        [HttpPost]
        [Route("api/authors/deleteauthors")]
        public ActionResult<Auteur> Delete([FromBody] Guid id)
        {
            _logger.LogInformation("Suppression de l'auteur {0}", id);
            autorsService.DeleteAuthor(id);
            return Ok();
        }
    }
}
