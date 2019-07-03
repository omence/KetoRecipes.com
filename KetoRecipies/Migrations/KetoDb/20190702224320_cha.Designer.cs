﻿// <auto-generated />
using System;
using KetoRecipies.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace KetoRecipies.Migrations.KetoDb
{
    [DbContext(typeof(KetoDbContext))]
    [Migration("20190702224320_cha")]
    partial class cha
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("KetoRecipies.Models.Favorite", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("RecipeID");

                    b.Property<string>("UserID");

                    b.HasKey("ID");

                    b.HasIndex("RecipeID");

                    b.ToTable("favorites");
                });

            modelBuilder.Entity("KetoRecipies.Models.Recipe", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ImageUrl");

                    b.Property<string>("Ingridients");

                    b.Property<string>("Instructions");

                    b.Property<string>("Label");

                    b.Property<string>("Source");

                    b.Property<string>("SourceUrl");

                    b.Property<decimal>("TotalCaloriesServ");

                    b.Property<decimal>("TotalCarbsServ");

                    b.Property<decimal>("TotalFatServ");

                    b.Property<decimal>("TotalTime");

                    b.Property<string>("VideoUrl");

                    b.Property<decimal>("Yield");

                    b.HasKey("ID");

                    b.ToTable("recipes");
                });

            modelBuilder.Entity("KetoRecipies.Models.Favorite", b =>
                {
                    b.HasOne("KetoRecipies.Models.Recipe", "Recipe")
                        .WithMany()
                        .HasForeignKey("RecipeID");
                });
#pragma warning restore 612, 618
        }
    }
}
