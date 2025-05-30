﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using projetoTeste.Data;

#nullable disable

namespace projetoTeste.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("projetoTeste.Models.ModelInput", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<float>("Households")
                        .HasColumnType("real");

                    b.Property<float>("Housing_median_age")
                        .HasColumnType("real");

                    b.Property<float>("Latitude")
                        .HasColumnType("real");

                    b.Property<float>("Longitude")
                        .HasColumnType("real");

                    b.Property<float>("Median_house_value")
                        .HasColumnType("real");

                    b.Property<float>("Median_income")
                        .HasColumnType("real");

                    b.Property<string>("Ocean_proximity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Population")
                        .HasColumnType("real");

                    b.Property<float>("Total_bedrooms")
                        .HasColumnType("real");

                    b.Property<float>("Total_rooms")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.ToTable("ModelInputs");
                });

            modelBuilder.Entity("projetoTeste.Models.ModelOutput", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ModelInputId")
                        .HasColumnType("int");

                    b.Property<float>("Score")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.HasIndex("ModelInputId");

                    b.ToTable("ModelOutputs");
                });

            modelBuilder.Entity("projetoTeste.Models.ModelOutput", b =>
                {
                    b.HasOne("projetoTeste.Models.ModelInput", "ModelInput")
                        .WithMany()
                        .HasForeignKey("ModelInputId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ModelInput");
                });
#pragma warning restore 612, 618
        }
    }
}
