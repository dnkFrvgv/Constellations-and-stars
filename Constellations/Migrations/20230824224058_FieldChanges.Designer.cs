﻿// <auto-generated />
using System;
using Constellations.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Constellations.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230824224058_FieldChanges")]
    partial class FieldChanges
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.10");

            modelBuilder.Entity("Constellations.Models.Constellation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Hemisphere")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int>("NumberOfStars")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Quadrant")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Constellations");
                });

            modelBuilder.Entity("Constellations.Models.SpectralClassification", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("IntrinsicColour")
                        .HasColumnType("TEXT");

                    b.Property<char>("SpectralType")
                        .HasColumnType("TEXT");

                    b.Property<double>("SurfaceTemperatureEndKelvin")
                        .HasColumnType("REAL");

                    b.Property<double>("SurfaceTemperatureStartKelvin")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.ToTable("SpectralClassifications");
                });

            modelBuilder.Entity("Constellations.Models.Star", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double>("AbsoluteMagnitude")
                        .HasColumnType("REAL");

                    b.Property<double>("AgeMillionYrs")
                        .HasColumnType("REAL");

                    b.Property<double>("ApparentMagnitude")
                        .HasColumnType("REAL");

                    b.Property<double>("ApproximateDistanceFromEarthLightYrs")
                        .HasColumnType("REAL");

                    b.Property<int>("ConstallationId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ConstellationId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<int>("EvolutionaryStageId")
                        .HasColumnType("INTEGER");

                    b.Property<double>("Luminosity")
                        .HasColumnType("REAL");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("ShortName")
                        .HasColumnType("TEXT");

                    b.Property<double>("SolarMass")
                        .HasColumnType("REAL");

                    b.Property<int>("SpectralClassificationId")
                        .HasColumnType("INTEGER");

                    b.Property<double>("SurfaceTemperatureKelvin")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.HasIndex("ConstellationId");

                    b.HasIndex("EvolutionaryStageId");

                    b.HasIndex("SpectralClassificationId");

                    b.ToTable("Stars");
                });

            modelBuilder.Entity("Constellations.Models.StarEvolutionaryStage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Definition")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("EvolutionaryStages");
                });

            modelBuilder.Entity("Constellations.Models.Star", b =>
                {
                    b.HasOne("Constellations.Models.Constellation", "Constellation")
                        .WithMany("Stars")
                        .HasForeignKey("ConstellationId");

                    b.HasOne("Constellations.Models.StarEvolutionaryStage", "EvolutionaryStage")
                        .WithMany("Stars")
                        .HasForeignKey("EvolutionaryStageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Constellations.Models.SpectralClassification", "SpectralClassification")
                        .WithMany("Stars")
                        .HasForeignKey("SpectralClassificationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Constellation");

                    b.Navigation("EvolutionaryStage");

                    b.Navigation("SpectralClassification");
                });

            modelBuilder.Entity("Constellations.Models.Constellation", b =>
                {
                    b.Navigation("Stars");
                });

            modelBuilder.Entity("Constellations.Models.SpectralClassification", b =>
                {
                    b.Navigation("Stars");
                });

            modelBuilder.Entity("Constellations.Models.StarEvolutionaryStage", b =>
                {
                    b.Navigation("Stars");
                });
#pragma warning restore 612, 618
        }
    }
}
