using Microsoft.EntityFrameworkCore;

namespace PoliziaMunicipaleApp.Models
{
    public class PoliziaMunicipaleContext : DbContext
    {
        public PoliziaMunicipaleContext(DbContextOptions<PoliziaMunicipaleContext> options)
            : base(options)
        {
        }

        public DbSet<Anagrafica> Anagrafica { get; set; }
        public DbSet<TipoViolazione> TipoViolazione { get; set; }
        public DbSet<Verbale> Verbale { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configuring relationships
            modelBuilder.Entity<Verbale>()
                .HasOne(v => v.Anagrafica)
                .WithMany()
                .HasForeignKey(v => v.idAnagrafica); 

            modelBuilder.Entity<Verbale>()
                .HasOne(v => v.TipoViolazione)
                .WithMany()
                .HasForeignKey(v => v.IdViolazione); 

        } 
    } 
}
