using System;

namespace SgpApi.Models
{
    public class Publicacao
    {
        public int Id { get; set; }
        public int IdAvaliacao { get; set; }
        public int IdTurma { get; set; }
        public DateTime DataPublicacao { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public int ValorProva { get; set; }
    }
}