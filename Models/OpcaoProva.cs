namespace SgpApi.Models
{
    public class OpcaoProva
    {
        public int Id { get; set; }
        public int IdOpcaoAvaliacao { get; set; }
        public int IdQuestaoProva { get; set; }
        public bool Resposta { get; set; }
    }
}