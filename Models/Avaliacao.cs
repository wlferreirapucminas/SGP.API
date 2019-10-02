namespace SgpApi.Models
{
    public class Avaliacao
    {
        public int Id { get; set; }
        public int IdProfessor { get; set; }
        public int IdDisciplina { get; set; }
        public int IdMateria { get; set; }
        public string Descricao { get; set; }
    }
}