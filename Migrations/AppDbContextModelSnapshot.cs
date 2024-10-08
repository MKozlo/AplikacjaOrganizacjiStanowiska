﻿// <auto-generated />
using System;
using Aplikacja_organizacji_stanowiska_fizycznego_i_wirtualnego.Controllers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Aplikacja_organizacji_stanowiska_fizycznego_i_wirtualnego.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Aplikacja_organizacji_stanowiska_fizycznego_i_wirtualnego.Entities.Dzialanie", b =>
                {
                    b.Property<int>("idDzialania")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idDzialania"));

                    b.Property<DateTime>("data")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("doKiedy")
                        .HasColumnType("datetime2");

                    b.Property<string>("dzialania")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("idOdpowiedzialnego")
                        .HasColumnType("int");

                    b.Property<int?>("idPlanuDzialan")
                        .HasColumnType("int");

                    b.Property<string>("komentarz")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("miejsceTemat")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("obserwacjeProblemy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idDzialania");

                    b.HasIndex("idOdpowiedzialnego");

                    b.HasIndex("idPlanuDzialan");

                    b.ToTable("Dzialania");
                });

            modelBuilder.Entity("Aplikacja_organizacji_stanowiska_fizycznego_i_wirtualnego.Entities.Kontrola", b =>
                {
                    b.Property<int>("idKontroli")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idKontroli"));

                    b.Property<DateTime>("dataKontroli")
                        .HasColumnType("datetime2");

                    b.Property<int?>("idOdpowiedzialnego")
                        .HasColumnType("int");

                    b.Property<int?>("idSprawdzajacego")
                        .HasColumnType("int");

                    b.Property<string>("obszarStanowisko")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idKontroli");

                    b.HasIndex("idOdpowiedzialnego");

                    b.HasIndex("idSprawdzajacego");

                    b.ToTable("Kontrole");
                });

            modelBuilder.Entity("Aplikacja_organizacji_stanowiska_fizycznego_i_wirtualnego.Entities.Krok", b =>
                {
                    b.Property<int>("idKroku")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idKroku"));

                    b.Property<int>("idPozycji")
                        .HasColumnType("int");

                    b.Property<string>("tresc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idKroku");

                    b.HasIndex("idPozycji");

                    b.ToTable("Kroki");
                });

            modelBuilder.Entity("Aplikacja_organizacji_stanowiska_fizycznego_i_wirtualnego.Entities.Odpowiedz", b =>
                {
                    b.Property<int>("idOdpowiedzi")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idOdpowiedzi"));

                    b.Property<int>("idPytania")
                        .HasColumnType("int");

                    b.Property<string>("tresc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idOdpowiedzi");

                    b.HasIndex("idPytania");

                    b.ToTable("Odpowiedzi");
                });

            modelBuilder.Entity("Aplikacja_organizacji_stanowiska_fizycznego_i_wirtualnego.Entities.Odpowiedzialny", b =>
                {
                    b.Property<int>("idOdpowiedzialnego")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idOdpowiedzialnego"));

                    b.Property<string>("imie")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nazwisko")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idOdpowiedzialnego");

                    b.ToTable("Odpowiedzialni");
                });

            modelBuilder.Entity("Aplikacja_organizacji_stanowiska_fizycznego_i_wirtualnego.Entities.PlanDzialan", b =>
                {
                    b.Property<int>("idPlanuDzialan")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idPlanuDzialan"));

                    b.Property<DateTime>("data")
                        .HasColumnType("datetime2");

                    b.Property<string>("dzial")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("idKontroli")
                        .HasColumnType("int");

                    b.Property<int>("idSprawdzajacego")
                        .HasColumnType("int");

                    b.Property<string>("obszar")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("temat")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idPlanuDzialan");

                    b.HasIndex("idKontroli");

                    b.HasIndex("idSprawdzajacego");

                    b.ToTable("PlanyDzialan");
                });

            modelBuilder.Entity("Aplikacja_organizacji_stanowiska_fizycznego_i_wirtualnego.Entities.Pozycja", b =>
                {
                    b.Property<int>("idPozycji")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idPozycji"));

                    b.Property<int?>("idKontroli")
                        .HasColumnType("int");

                    b.Property<string>("nazwa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("poprzedniWynik")
                        .HasColumnType("int");

                    b.Property<int?>("wynikCalkowity")
                        .HasColumnType("int");

                    b.HasKey("idPozycji");

                    b.HasIndex("idKontroli");

                    b.ToTable("Pozycje");
                });

            modelBuilder.Entity("Aplikacja_organizacji_stanowiska_fizycznego_i_wirtualnego.Entities.Pytanie", b =>
                {
                    b.Property<int>("idPytania")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idPytania"));

                    b.Property<int>("idKroku")
                        .HasColumnType("int");

                    b.Property<string>("tresc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idPytania");

                    b.HasIndex("idKroku");

                    b.ToTable("Pytania");
                });

            modelBuilder.Entity("Aplikacja_organizacji_stanowiska_fizycznego_i_wirtualnego.Entities.Sprawdzajacy", b =>
                {
                    b.Property<int>("idSprawdzajacego")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idSprawdzajacego"));

                    b.Property<string>("imie")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nazwisko")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idSprawdzajacego");

                    b.ToTable("Sprawdzanie");
                });

            modelBuilder.Entity("Aplikacja_organizacji_stanowiska_fizycznego_i_wirtualnego.Entities.WynikOdpowiedzi", b =>
                {
                    b.Property<int>("idWynikuOdpowiedzi")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idWynikuOdpowiedzi"));

                    b.Property<int?>("idOdpowiedzi")
                        .HasColumnType("int");

                    b.Property<int?>("idPozycji")
                        .HasColumnType("int");

                    b.HasKey("idWynikuOdpowiedzi");

                    b.HasIndex("idOdpowiedzi");

                    b.HasIndex("idPozycji");

                    b.ToTable("WynikiOdpowiedzi");
                });

            modelBuilder.Entity("Aplikacja_organizacji_stanowiska_fizycznego_i_wirtualnego.Entities.Dzialanie", b =>
                {
                    b.HasOne("Aplikacja_organizacji_stanowiska_fizycznego_i_wirtualnego.Entities.Odpowiedzialny", "Odpowiedzialny")
                        .WithMany("Dzialania")
                        .HasForeignKey("idOdpowiedzialnego")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Aplikacja_organizacji_stanowiska_fizycznego_i_wirtualnego.Entities.PlanDzialan", "PlanDzialan")
                        .WithMany("Dzialania")
                        .HasForeignKey("idPlanuDzialan");

                    b.Navigation("Odpowiedzialny");

                    b.Navigation("PlanDzialan");
                });

            modelBuilder.Entity("Aplikacja_organizacji_stanowiska_fizycznego_i_wirtualnego.Entities.Kontrola", b =>
                {
                    b.HasOne("Aplikacja_organizacji_stanowiska_fizycznego_i_wirtualnego.Entities.Odpowiedzialny", "Odpowiedzialny")
                        .WithMany("Kontrole")
                        .HasForeignKey("idOdpowiedzialnego");

                    b.HasOne("Aplikacja_organizacji_stanowiska_fizycznego_i_wirtualnego.Entities.Sprawdzajacy", "Sprawdzajacy")
                        .WithMany("Kontrole")
                        .HasForeignKey("idSprawdzajacego");

                    b.Navigation("Odpowiedzialny");

                    b.Navigation("Sprawdzajacy");
                });

            modelBuilder.Entity("Aplikacja_organizacji_stanowiska_fizycznego_i_wirtualnego.Entities.Krok", b =>
                {
                    b.HasOne("Aplikacja_organizacji_stanowiska_fizycznego_i_wirtualnego.Entities.Pozycja", "Pozycja")
                        .WithMany("Kroki")
                        .HasForeignKey("idPozycji")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pozycja");
                });

            modelBuilder.Entity("Aplikacja_organizacji_stanowiska_fizycznego_i_wirtualnego.Entities.Odpowiedz", b =>
                {
                    b.HasOne("Aplikacja_organizacji_stanowiska_fizycznego_i_wirtualnego.Entities.Pytanie", "Pytanie")
                        .WithMany("Odpowiedzi")
                        .HasForeignKey("idPytania")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pytanie");
                });

            modelBuilder.Entity("Aplikacja_organizacji_stanowiska_fizycznego_i_wirtualnego.Entities.PlanDzialan", b =>
                {
                    b.HasOne("Aplikacja_organizacji_stanowiska_fizycznego_i_wirtualnego.Entities.Kontrola", "Kontrola")
                        .WithMany("PlanyDzialan")
                        .HasForeignKey("idKontroli");

                    b.HasOne("Aplikacja_organizacji_stanowiska_fizycznego_i_wirtualnego.Entities.Sprawdzajacy", "Sprawdzajacy")
                        .WithMany("PlanyDzialan")
                        .HasForeignKey("idSprawdzajacego");

                    b.Navigation("Kontrola");

                    b.Navigation("Sprawdzajacy");
                });

            modelBuilder.Entity("Aplikacja_organizacji_stanowiska_fizycznego_i_wirtualnego.Entities.Pozycja", b =>
                {
                    b.HasOne("Aplikacja_organizacji_stanowiska_fizycznego_i_wirtualnego.Entities.Kontrola", "Kontrola")
                        .WithMany("Pozycje")
                        .HasForeignKey("idKontroli");

                    b.Navigation("Kontrola");
                });

            modelBuilder.Entity("Aplikacja_organizacji_stanowiska_fizycznego_i_wirtualnego.Entities.Pytanie", b =>
                {
                    b.HasOne("Aplikacja_organizacji_stanowiska_fizycznego_i_wirtualnego.Entities.Krok", "Krok")
                        .WithMany("Pytania")
                        .HasForeignKey("idKroku")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Krok");
                });

            modelBuilder.Entity("Aplikacja_organizacji_stanowiska_fizycznego_i_wirtualnego.Entities.WynikOdpowiedzi", b =>
                {
                    b.HasOne("Aplikacja_organizacji_stanowiska_fizycznego_i_wirtualnego.Entities.Odpowiedz", "Odpowiedz")
                        .WithMany("WynikiOdpowiedzi")
                        .HasForeignKey("idOdpowiedzi");

                    b.HasOne("Aplikacja_organizacji_stanowiska_fizycznego_i_wirtualnego.Entities.Pozycja", "Pozycja")
                        .WithMany("WynikiOdpowiedzi")
                        .HasForeignKey("idPozycji");

                    b.Navigation("Odpowiedz");

                    b.Navigation("Pozycja");
                });

            modelBuilder.Entity("Aplikacja_organizacji_stanowiska_fizycznego_i_wirtualnego.Entities.Kontrola", b =>
                {
                    b.Navigation("PlanyDzialan");

                    b.Navigation("Pozycje");
                });

            modelBuilder.Entity("Aplikacja_organizacji_stanowiska_fizycznego_i_wirtualnego.Entities.Krok", b =>
                {
                    b.Navigation("Pytania");
                });

            modelBuilder.Entity("Aplikacja_organizacji_stanowiska_fizycznego_i_wirtualnego.Entities.Odpowiedz", b =>
                {
                    b.Navigation("WynikiOdpowiedzi");
                });

            modelBuilder.Entity("Aplikacja_organizacji_stanowiska_fizycznego_i_wirtualnego.Entities.Odpowiedzialny", b =>
                {
                    b.Navigation("Dzialania");

                    b.Navigation("Kontrole");
                });

            modelBuilder.Entity("Aplikacja_organizacji_stanowiska_fizycznego_i_wirtualnego.Entities.PlanDzialan", b =>
                {
                    b.Navigation("Dzialania");
                });

            modelBuilder.Entity("Aplikacja_organizacji_stanowiska_fizycznego_i_wirtualnego.Entities.Pozycja", b =>
                {
                    b.Navigation("Kroki");

                    b.Navigation("WynikiOdpowiedzi");
                });

            modelBuilder.Entity("Aplikacja_organizacji_stanowiska_fizycznego_i_wirtualnego.Entities.Pytanie", b =>
                {
                    b.Navigation("Odpowiedzi");
                });

            modelBuilder.Entity("Aplikacja_organizacji_stanowiska_fizycznego_i_wirtualnego.Entities.Sprawdzajacy", b =>
                {
                    b.Navigation("Kontrole");

                    b.Navigation("PlanyDzialan");
                });
#pragma warning restore 612, 618
        }
    }
}
