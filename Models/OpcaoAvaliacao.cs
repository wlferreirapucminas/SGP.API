namespace SgpApi.Models
{
    public class OpcaoAvaliacao
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public int IdQuestao { get; set; }
        public bool Verdadeira { get; set; }
        
    }
}