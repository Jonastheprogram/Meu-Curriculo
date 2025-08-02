namespace MeuCurriculo.Model
{
    public class CurriculoViewModel
    {
        public string Nome { get; set; }
        public string Funcao { get; set; }
        public string Sobremim { get; set; }

        
        public List<ExperienciaModel> Experiencias { get; set; }
        public List<FormacaoModel> Formacoes { get; set; }
        public List<IdiomaModel> Idiomas { get; set; }
        public List<HardSkillsModel> HardSkills { get; set; }
        public List<SoftSkillsModel> SoftSkills { get; set; }

    }
}