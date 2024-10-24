using Microsoft.EntityFrameworkCore;

namespace atento_n3_projeto_api.Models
{
    public class PessoaContext : DbContext
    {
        public PessoaContext(DbContextOptions<PessoaContext> options) : base(options)
        {
        }

        public DbSet<Pessoa> Pessoas { get; set; } = null!;
    }
}
