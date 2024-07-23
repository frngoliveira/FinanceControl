using FinanceControl.Domain._2._2_Entity;
using Microsoft.EntityFrameworkCore;

namespace FinanceControl.Infra._3._1_Context
{
    public class FinanceControlContext : DbContext 
    {
        public FinanceControlContext(DbContextOptions<FinanceControlContext> options) : base(options) { }

        public DbSet<Lancamento> Lancamento { get; set; }      

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_BIN");            
        }
    }
}
