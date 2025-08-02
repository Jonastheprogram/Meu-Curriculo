using MeuCurriculo.Model;
using Microsoft.AspNetCore.Mvc;

public class CurriculoController : Controller
{
    private readonly HttpClient _http;

    public CurriculoController(IHttpClientFactory httpClientFactory)
    {
        _http = httpClientFactory.CreateClient();
    }

    public async Task<IActionResult> CurriculoIndex()
    {
       
        var experiencias = await _http.GetFromJsonAsync<List<ExperienciaModel>>("http://localhost:5051/api/experiencia");
        var formacoes = await _http.GetFromJsonAsync<List<FormacaoModel>>("http://localhost:5051/api/formacao");
        var idiomas = await _http.GetFromJsonAsync<List<IdiomaModel>>("http://localhost:5051/api/idioma");
        var hardskills = await _http.GetFromJsonAsync<List<HardSkillsModel>>("http://localhost:5051/api/hardskills");
        var softskills = await _http.GetFromJsonAsync<List<SoftSkillsModel>>("http://localhost:5051/api/softskills");

        var model = new CurriculoViewModel
        {
            Nome = "João Antonio de Lima França",
            Funcao = "Junior Software Developer",
            Sobremim = "Sou um profissional em transição de carreira, atualmente iniciando minha jornada na área de desenvolvimento de software. Tenho 24 anos, resido em São Carlos, SP e estou cursando Análise e Desenvolvimento de Sistemas pela FIAP. Tenho experiência em áreas da tecnologia, como montagem e manutenção eletrônica, além de reparo de microcomputadores. Tenho grande interesse por tecnologia, resolução de problemas e criação de soluções que façam a diferença. Estou em busca da minha primeira oportunidade como desenvolvedor. Sou dedicado, curioso, gosto de aprender na prática e procuro evoluir sempre com desafios. Meus conhecimentos estão mais detalhados abaixo.",

            Experiencias = experiencias,
            Formacoes = formacoes,
            Idiomas = idiomas,
            HardSkills = hardskills,
            SoftSkills = softskills
        };

        return View(model);
    }
}
