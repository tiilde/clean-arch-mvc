using CleanArchMvc.Domain.Entities;
using Microsoft.EntityFrameworkCore;



namespace CleanArchMvc.Infra.Data.Context {
    public class ApplicationDbContext : DbContext {
        
        // através dessa classe é que iremos definir a conexão com o banco de dados, utilizando Entity framework
        // será feito o mapeamento ORM
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options) : base(options) {
        
        }
        // mapeando category e product
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder builder) { 
            
            base.OnModelCreating(builder);

            // método para aplicar as configurações que irão ser feitas em todas as entidades que
            // seguem o padrão de herança de "Entity Type Configuration
            builder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
        }

    }
}
 