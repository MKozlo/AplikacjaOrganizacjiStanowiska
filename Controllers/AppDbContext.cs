using Aplikacja_organizacji_stanowiska_fizycznego_i_wirtualnego.Entities;
using Microsoft.EntityFrameworkCore;

namespace Aplikacja_organizacji_stanowiska_fizycznego_i_wirtualnego.Controllers
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        private string _connectionString = "Server=(localdb)\\mssqllocaldb;Database=OrganizacjaDb;Trusted_Connection=True;TrustServerCertificate=True;";

        public DbSet<Dzialanie> Dzialania { get; set; }
        public DbSet<Kontrola> Kontrole { get; set; }
        public DbSet<Krok> Kroki { get; set; }
        public DbSet<Odpowiedz> Odpowiedzi { get; set; }
        public DbSet<Odpowiedzialny> Odpowiedzialni { get; set; }
        public DbSet<PlanDzialan> PlanyDzialan { get; set; }
        public DbSet<Pozycja> Pozycje { get; set; }
        public DbSet<Pytanie> Pytania { get; set; }
        public DbSet<Sprawdzajacy> Sprawdzanie { get; set; }
        public DbSet<WynikOdpowiedzi> WynikiOdpowiedzi { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Dzialanie>()
                .Property(d => d.idDzialania)
                .IsRequired();

            modelBuilder.Entity<Kontrola>()
                .Property(k => k.idKontroli)
                .IsRequired();

            modelBuilder.Entity<Krok>()
                .Property(kr => kr.idKroku)
                .IsRequired();

            modelBuilder.Entity<Odpowiedz>()
                .Property(odp => odp.idOdpowiedzi)
                .IsRequired();

            modelBuilder.Entity<Odpowiedzialny>()
                .Property(o => o.idOdpowiedzialnego)
                .IsRequired();

            modelBuilder.Entity<PlanDzialan>()
                .Property(pd => pd.idPlanuDzialan)
                .IsRequired();

            modelBuilder.Entity<Pozycja>()
                .Property(p => p.idPozycji)
                .IsRequired();

            modelBuilder.Entity<Pytanie>()
                .Property(pyt => pyt.idPytania)
                .IsRequired();

            modelBuilder.Entity<Sprawdzajacy>()
                .Property(spr => spr.idSprawdzajacego)
                .IsRequired();

            modelBuilder.Entity<WynikOdpowiedzi>()
                .Property(wo => wo.idWynikuOdpowiedzi)
                .IsRequired();


            // Ustawienie klucza głównego

            modelBuilder.Entity<Dzialanie>()
                .HasKey(d => d.idDzialania);

            modelBuilder.Entity<Kontrola>()
                .HasKey(k => k.idKontroli);

            modelBuilder.Entity<Krok>()
                .HasKey(kr => kr.idKroku);

            modelBuilder.Entity<Odpowiedz>()
                .HasKey(odp => odp.idOdpowiedzi);

            modelBuilder.Entity<Odpowiedzialny>()
                .HasKey(o => o.idOdpowiedzialnego);

            modelBuilder.Entity<PlanDzialan>()
                .HasKey(pd => pd.idPlanuDzialan);

            modelBuilder.Entity<Pozycja>()
                .HasKey(p => p.idPozycji);

            modelBuilder.Entity<Pytanie>()
                .HasKey(pyt => pyt.idPytania);

            modelBuilder.Entity<Sprawdzajacy>()
                .HasKey(spr => spr.idSprawdzajacego);

            modelBuilder.Entity<WynikOdpowiedzi>()
                .HasKey(wo => wo.idWynikuOdpowiedzi);


            // Ustawienie relacji

            // Odpowiedz - Pytanie (N:1)
            modelBuilder.Entity<Odpowiedz>()
                .HasOne(odp => odp.Pytanie)
                .WithMany(pyt => pyt.Odpowiedzi)
                .HasForeignKey(odp => odp.idPytania);

            // Pytanie - Krok (N:1)
            modelBuilder.Entity<Pytanie>()
                .HasOne(pyt => pyt.Krok)
                .WithMany(k => k.Pytania)
                .HasForeignKey(pyt => pyt.idKroku);

            // Krok - Pozycja (N:1)
            modelBuilder.Entity<Krok>()
                .HasOne(k => k.Pozycja)
                .WithMany(p => p.Kroki)
                .HasForeignKey(k => k.idPozycji);

            // Wynik Odpowiedzi - Pozycja (N:1)
            modelBuilder.Entity<WynikOdpowiedzi>()
                .HasOne(wo => wo.Pozycja)
                .WithMany(p => p.WynikiOdpowiedzi)
                .HasForeignKey(wo => wo.idPozycji);

            // Wynik Odpowiedzi - Odpowiedź (N:1)
            modelBuilder.Entity<WynikOdpowiedzi>()
                .HasOne(wo => wo.Odpowiedz)
                .WithMany(odp => odp.WynikiOdpowiedzi)
                .HasForeignKey(wo => wo.idOdpowiedzi);

            // Pozycja - Kontrola (N:1)
            modelBuilder.Entity<Pozycja>()
                .HasOne(p => p.Kontrola)
                .WithMany(k => k.Pozycje)
                .HasForeignKey(p => p.idKontroli)
                .IsRequired(false);

            // Kontrola - Odpowiedzialni (N:1)
            modelBuilder.Entity<Kontrola>()
                .HasOne(k => k.Odpowiedzialny)
                .WithMany(o => o.Kontrole)
                .HasForeignKey(k => k.idOdpowiedzialnego);

            // Kontrola - Sprawdzajacy (N:1)
            modelBuilder.Entity<Kontrola>()
                .HasOne(k => k.Sprawdzajacy)
                .WithMany(s => s.Kontrole)
                .HasForeignKey(k => k.idSprawdzajacego);

            // Dzialanie - Odpowiedzialni (N:1)
            modelBuilder.Entity<Dzialanie>()
                .HasOne(d => d.Odpowiedzialny)
                .WithMany(o => o.Dzialania)
                .HasForeignKey(d => d.idOdpowiedzialnego);

            // Plan Działań - Sprawdzający (N:1)
            modelBuilder.Entity<PlanDzialan>()
                .HasOne(pd => pd.Sprawdzajacy)
                .WithMany(spr => spr.PlanyDzialan)
                .HasForeignKey(pd => pd.idSprawdzajacego)
                .IsRequired(false); // Ustawienie foreign key jako opcjonalny

            // Plan Działań - Kontrola (N:1)
            modelBuilder.Entity<PlanDzialan>()
                .HasOne(pd => pd.Kontrola)
                .WithMany(k => k.PlanyDzialan)
                .HasForeignKey(pd => pd.idKontroli)
                .IsRequired(false); // Ustawienie foreign key jako opcjonalny

            // Działanie - Plan Działań (N:1)
            modelBuilder.Entity<Dzialanie>()
                .HasOne(d => d.PlanDzialan)
                .WithMany(pd => pd.Dzialania)
                .HasForeignKey(d => d.idPlanuDzialan)
                .IsRequired(false); // Ustawienie foreign key jako opcjonalny
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }
    }
}
