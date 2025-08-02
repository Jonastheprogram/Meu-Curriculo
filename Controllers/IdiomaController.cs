using MeuCurriculo.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MeuCurriculo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IdiomaController : ControllerBase
    {
        [HttpGet]

        public IActionResult Get()
        {
            var idioma = new List<IdiomaModel>
            {
                new IdiomaModel
                {
                    Idioma = "Inglês",
                    Nivel = "Intermediário em processo de aperfeiçoamento"
                }

            };
            return Ok(idioma);
        }
    }
}
