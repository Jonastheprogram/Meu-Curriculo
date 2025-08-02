using MeuCurriculo.Model;
using Microsoft.AspNetCore.Mvc;

namespace MeuCurriculo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SoftSkillsController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var softskills = new List<SoftSkillsModel>
            {
                new SoftSkillsModel { SoftSkills = "Trabalho em equipe" },
                new SoftSkillsModel { SoftSkills = "Proativo" },
                new SoftSkillsModel { SoftSkills = "Rapido aprendizado" },
                new SoftSkillsModel { SoftSkills = "Adaptabilidade" },
            };
            return Ok(softskills);
        }


    }
}