using Microsoft.EntityFrameworkCore;

namespace SgpApi.Models
{
    public class SgpDbContext : DbContext
    {
        public SgpDbContext(DbContextOptions<SgpDbContext> options)
            : base(options)
        {
        }

        public DbSet<Avaliacao> Avaliacao { get; set; }
        public DbSet<OpcaoAvaliacao> OpcaoAvaliacao { get; set; }
        public DbSet<Prova> Prova { get; set; }
        public DbSet<OpcaoProva> OpcaoProva { get; set; }
        public DbSet<Pessoa> Pessoa { get; set; }
        public DbSet<Questao> Questao { get; set; }
        public DbSet<QuestaoProva> QuestaoProva { get; set; }
        public DbSet<Materia> Materia { get; set; }
        public DbSet<Turma> Turma { get; set; }
        public DbSet<Disciplina> Disciplina { get; set; }
        public DbSet<Publicacao> Publicacao { get; set; }

    }
    
}