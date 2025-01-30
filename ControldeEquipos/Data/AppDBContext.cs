using Microsoft.EntityFrameworkCore;

public class AppDBContext : DbContext
{
    public AppDBContext(DbContextOptions<AppDBContext> options) : base(options) { }

    public DbSet<Departamento> Departamentos { get; set; }
    public DbSet<Equipo> Equipos { get; set; }
    public DbSet<Mantenimiento> Mantenimientos { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Departamento>()
            .HasKey(d => d.ID_Departamento);

        modelBuilder.Entity<Equipo>()
            .HasKey(e => e.ID_Equipo);

        modelBuilder.Entity<Mantenimiento>()
            .HasKey(m => m.ID_Mantenimiento);

        // Otras configuraciones de entidades...

        base.OnModelCreating(modelBuilder);
    }
}