using Microsoft.AspNetCore.Mvc;
using TEST_DEFIS_APP.Repositories;

namespace TEST_DEFIS_APP.Controllers
{
    [ApiController]
    public class FilmsController : ControllerBase
    {
        public FIlmsServices filmService;
        public FilmsController(FIlmsServices filmService)
        {
            this.filmService = filmService;
        }
        private readonly ILogger<FilmsController> _logger;

        public FilmsController(ILogger<FilmsController> logger)
        {
            _logger = logger;
        }
      
    }
}
