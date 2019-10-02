using System;

namespace SgpApi.Models
{
    public class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Login { get; set; }
        public bool Status { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Curso { get; set; }
        public string Sexo { get; set; }
        public string Telefone { get; set; }
        public string Origem { get; set; }
        public int Tipo { get; set; }
        public int IdTurma { get; set; }
        public string Senha { get; set; }
    }
}