using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TEST_DEFIS_APP.Models;
using TEST_DEFIS_APP.Repositories;

namespace TEST_DEFIS_APP.Controllers
{
    [ApiController]
    public class UtilisateursController : ControllerBase
    {
        // GET: UtilisateursController
        public UtilisateurService utilisateurService;
        public UtilisateursController(UtilisateurService utilisateurService)
        {
            this.utilisateurService = utilisateurService;
        }
        private readonly ILogger<UtilisateursController> _logger;

        public UtilisateursController(ILogger<UtilisateursController> logger)
        {
            _logger = logger;
        }
        [HttpGet]
        [Route("api/user/utilisateurs")]
        public ActionResult<UserModel> Get_Users_Actifs()
        {
            _logger.LogInformation("Consultation des utilisateurs actifs");
            return Ok(utilisateurService.GetUsersActifs());
        }
        [HttpGet]
        [Route("api/user/utilisateursdelete")]
        public ActionResult<UserModel> Get_Users_Delete()
        {
            _logger.LogInformation("Consultation des utilisateurs supprimés");
            return Ok(utilisateurService.GetUsersDelete());
        }
        [HttpPost]
        [Route("api/user/create")]
        public ActionResult<UserModel> Create([FromBody] UserModel model)
        {
            utilisateurService.CreateUser(model);
            _logger.LogInformation("Création de l'utilisateur {0} {1}",model.nom ,model.prenoms);
            return Ok(model);
        }
        [HttpPost]
        [Route("api/user/update")]
        public ActionResult<UserModel> UpdateUser([FromBody] UserModel model)
        {
            utilisateurService.UpdateUser(model);
            _logger.LogInformation("Modification de l'utilisateur {0} {1}", model.nom, model.prenoms);
            return Ok(model);
        }
        [HttpPost]
        [Route("api/user/delete/id")]
        public ActionResult<UserModel> UpdateUser([FromBody] Guid id)
        {
            utilisateurService.DeleteUser(id);
            _logger.LogInformation("Suppression de l'utilisateur {0} ", id);
            return Ok();
        }
       
    }
}
