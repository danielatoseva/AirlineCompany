// <auto-generated />
using System;
using AirlineCompany;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AirlineCompany.Migrations
{
    [DbContext(typeof(AirlineCompanyContext))]
    [Migration("20210913132559_foreign key")]
    partial class foreignkey
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.8");

            modelBuilder.Entity("AirlineCompany.Models.Airplanes.Airplane", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("MyPropertyID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("MyPropertyID");

                    b.ToTable("Airplane");
                });

            modelBuilder.Entity("AirlineCompany.Models.Airplanes.AirplaneModel", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Manufacturer")
                        .HasColumnType("longtext");

                    b.Property<string>("ModelName")
                        .HasColumnType("longtext");

                    b.HasKey("ID");

                    b.ToTable("AirplaneModel");
                });

            modelBuilder.Entity("AirlineCompany.Models.Airplanes.Country", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.HasKey("ID");

                    b.ToTable("Country");
                });

            modelBuilder.Entity("AirlineCompany.Models.Airplanes.Destination", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.HasKey("ID");

                    b.HasIndex("CountryId");

                    b.ToTable("Destination");
                });

            modelBuilder.Entity("AirlineCompany.Models.Airplanes.Flight", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("FlownByID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("FlownByID");

                    b.ToTable("Flight");
                });

            modelBuilder.Entity("AirlineCompany.Models.Airplanes.FlightDestinations", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("AirRouteID")
                        .HasColumnType("int");

                    b.Property<int?>("DestinationID")
                        .HasColumnType("int");

                    b.Property<int?>("FlightID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("AirRouteID");

                    b.HasIndex("DestinationID");

                    b.HasIndex("FlightID");

                    b.ToTable("FlightDestinations");
                });

            modelBuilder.Entity("AirlineCompany.Models.Flights.AirRoute", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<uint>("Altitude")
                        .HasColumnType("int unsigned");

                    b.Property<uint>("Distance")
                        .HasColumnType("int unsigned");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.HasKey("ID");

                    b.ToTable("AirRoutes");
                });

            modelBuilder.Entity("DestinationFlight", b =>
                {
                    b.Property<int>("DestinationID")
                        .HasColumnType("int");

                    b.Property<int>("FlightsID")
                        .HasColumnType("int");

                    b.HasKey("DestinationID", "FlightsID");

                    b.HasIndex("FlightsID");

                    b.ToTable("DestinationFlight");
                });

            modelBuilder.Entity("AirlineCompany.Models.Airplanes.Airplane", b =>
                {
                    b.HasOne("AirlineCompany.Models.Airplanes.AirplaneModel", "MyProperty")
                        .WithMany()
                        .HasForeignKey("MyPropertyID");

                    b.Navigation("MyProperty");
                });

            modelBuilder.Entity("AirlineCompany.Models.Airplanes.Destination", b =>
                {
                    b.HasOne("AirlineCompany.Models.Airplanes.Country", "Country")
                        .WithMany()
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("AirlineCompany.Models.Airplanes.Flight", b =>
                {
                    b.HasOne("AirlineCompany.Models.Airplanes.Airplane", "FlownBy")
                        .WithMany()
                        .HasForeignKey("FlownByID");

                    b.Navigation("FlownBy");
                });

            modelBuilder.Entity("AirlineCompany.Models.Airplanes.FlightDestinations", b =>
                {
                    b.HasOne("AirlineCompany.Models.Flights.AirRoute", "AirRoute")
                        .WithMany()
                        .HasForeignKey("AirRouteID");

                    b.HasOne("AirlineCompany.Models.Airplanes.Destination", "Destination")
                        .WithMany()
                        .HasForeignKey("DestinationID");

                    b.HasOne("AirlineCompany.Models.Airplanes.Flight", "Flight")
                        .WithMany()
                        .HasForeignKey("FlightID");

                    b.Navigation("AirRoute");

                    b.Navigation("Destination");

                    b.Navigation("Flight");
                });

            modelBuilder.Entity("DestinationFlight", b =>
                {
                    b.HasOne("AirlineCompany.Models.Airplanes.Destination", null)
                        .WithMany()
                        .HasForeignKey("DestinationID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AirlineCompany.Models.Airplanes.Flight", null)
                        .WithMany()
                        .HasForeignKey("FlightsID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
