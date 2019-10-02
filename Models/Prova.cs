using System;

namespace SgpApi.Models
{
    public class Prova
    {
        public int Id { get; set; }
        public int IdAvaliacao { get; set; }
        public int IdAluno { get; set; }
        public DateTime DataProva { get; set; }
        public int NotaObtida { get; set; }
    }
}