using Microsoft.EntityFrameworkCore;

namespace api1
{
    public class DataContext : DbContext
    {
        public DbSet<MFilial> Filiais { get; set; } = null!;
        public DbSet<MQuarto> Quartos { get; set; } = null!;
        public DbSet<MCliente> Clientes { get; set; } = null!;
        public DbSet<MReserva> Reservas { get; set; } = null!;
        public DbSet<MFuncionario> Funcionarios { get; set; } = null!;
        public DbSet<MConsumo> Consumos { get; set; } = null!;
        public DbSet<MConsumoRestaurante> ConsumosRestaurante { get; set; } = null!;
        public DbSet<MServicoLavanderia> ServicosLavanderia { get; set; } = null!;
        public DbSet<MPagamento> Pagamentos { get; set; } = null!;
        public DbSet<MTipoHotel> TiposHotel { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer(@"Server=.\;Database=Trabalhoo;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MConsumo>().Property(c => c.Valor).HasColumnType("decimal(10, 2)");
            modelBuilder.Entity<MPagamento>().Property(p => p.Valor).HasColumnType("decimal(10, 2)");
            modelBuilder.Entity<MServicoLavanderia>().Property(s => s.Valor).HasColumnType("decimal(10, 2)");
            modelBuilder.Entity<MConsumoRestaurante>().Property(c => c.Valor).HasColumnType("decimal(10, 2)");

        }
    }
}
