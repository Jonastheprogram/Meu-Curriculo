using MeuCurriculo.Model;
using Microsoft.AspNetCore.Mvc;

namespace MeuCurriculo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FormacaoController : ControllerBase
    {
        [HttpGet]

        public IActionResult Get()
        {
            var formacao = new List<FormacaoModel>
            {
                new FormacaoModel
                {
                    Instituicao = "FIAP - Faculdade de Informática e Administração Paulista",
                    Curso = "Análise e Desenvolvimento de Sistemas",
                    DataInicio = new DateOnly(2024, 2, 1),
                    DataFim = new DateOnly(2025, 12, 31)
                },
                new FormacaoModel
                {
                    Instituicao = "Etec Paulino Botelho",
                    Curso = "Técnico em Eletrônica Integrado ao Ensino Médio",
                    DataInicio = new DateOnly(2018, 2, 1),
                    DataFim = new DateOnly(2020, 12, 31)
                }
            }; return Ok(formacao);
        
        }

        
    }
}
