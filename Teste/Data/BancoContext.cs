using Microsoft.EntityFrameworkCore;
using Teste.Models;

namespace Teste.Data
{
    public class BancoContext: DbContext
    {
         public BancoContext(DbContextOptions<BancoContext> options): base(options) => Database.EnsureCreated();
    

        public DbSet<ClienteModel> Clinetes
            { get; set; }

    }
}
