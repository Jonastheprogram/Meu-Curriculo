using MeuCurriculo.Model;
using Microsoft.AspNetCore.Mvc;

namespace MeuCurriculo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExperienciaController : ControllerBase
    {
        [HttpGet]

        public IActionResult Get()
        {
            var experiencia = new List<ExperienciaModel>
            {
                new ExperienciaModel
                {
                    Empresa = "DMC Equipamentos",
                    Cargo = "Montador de Equipamentos Eletrônicos",
                    Periodo = "Set/2023 - Jul/2025",
                    DescricaoCargo = "Produção e montagem de equipamentos médicos, estéticos e odontológicos " +
                    "Atuação com eletrônica digital, mecânica e controle de qualidade dos produtos."
                },

                new ExperienciaModel
                {
                    Empresa = "DirectLight",
                    Cargo = "Montador de Equipamentos Elétricos",
                    Periodo = "Set/2022 - Set/2023",
                    DescricaoCargo = "Manutenção, montagem e fabricação de produtos de iluminação interna e externa com alto rendimento luminoso"

                },

                new ExperienciaModel
                {
                    Empresa = "Compuled",
                    Cargo = "Técnico em Manutenção de Equipamentos de Informática",
                    Periodo = "Abr/2022 - Ago/2022",
                    DescricaoCargo = "Realização de formatação de sistemas, manutenção preventiva e corretiva, recuperação de dados, configuração e execução de backups. Responsável também pelo reparo, otimização e atualização de microcomputadores, garantindo desempenho e estabilidade dos equipamentos."
                }


            };

            return Ok(experiencia);
        }
    }
}
