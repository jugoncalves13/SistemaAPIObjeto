using Microsoft.EntityFrameworkCore;

namespace SistemaAPIObjeto.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) { }

        public DbSet<Objeto>? Objeto { get; set; }
        public DbSet<Observacoes>? Observacoes { get; set; }
        public DbSet<Usuario>? Usuario { get; set; }

    }
}
