using MeuCurriculo.Model;
using Microsoft.AspNetCore.Mvc;

namespace MeuCurriculo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HardSkillsController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var hardskills = new List<HardSkillsModel>
            {
                new HardSkillsModel { HardSkills = "Java" },
                new HardSkillsModel { HardSkills = "Python" },
                new HardSkillsModel { HardSkills = "Kotlin" },
                new HardSkillsModel { HardSkills = "C#" },
                new HardSkillsModel { HardSkills = "HTML" },
                new HardSkillsModel { HardSkills = "CSS" },
                new HardSkillsModel { HardSkills = "JavaScript" },
                new HardSkillsModel { HardSkills = "API RESTful" },
                new HardSkillsModel { HardSkills = "Git" },
                new HardSkillsModel { HardSkills = "Docker" },
                new HardSkillsModel { HardSkills = "Oracle SQL" },
                new HardSkillsModel { HardSkills = "Spring Boot" },
                new HardSkillsModel { HardSkills = "Scrum" },
                new HardSkillsModel { HardSkills = "Kanban" },


                
            };
            return Ok(hardskills);
        }


    }
}