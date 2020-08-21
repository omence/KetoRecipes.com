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
    [Migration("20200820212052_change")]
    partial class change
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("KetoRecipies.Models.Comments.MainComment", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateTime");

                    b.Property<string>("Message");

                    b.Property<int>("RecipeID");

                    b.Property<string>("User");

                    b.HasKey("ID");

                    b.HasIndex("RecipeID");

                    b.ToTable("mainComments");
                });

            modelBuilder.Entity("KetoRecipies.Models.Comments.SubComment", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateTime");

                    b.Property<int>("MainCommentID");

                    b.Property<string>("Message");

                    b.Property<string>("User");

                    b.HasKey("ID");

                    b.HasIndex("MainCommentID");

                    b.ToTable("subComments");
                });

            modelBuilder.Entity("KetoRecipies.Models.Favorite", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("RecipeID");

                    b.Property<string>("UserID");

                    b.HasKey("ID");

                    b.HasIndex("RecipeID");

                    b.ToTable("favorites");
                });

            modelBuilder.Entity("KetoRecipies.Models.Like", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Liked");

                    b.Property<int>("RecipeId");

                    b.Property<string>("UserId");

                    b.HasKey("ID");

                    b.ToTable("Likes");
                });

            modelBuilder.Entity("KetoRecipies.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ImageUrl");

                    b.Property<string>("ProductName");

                    b.Property<string>("ProductType");

                    b.Property<string>("ProductUrl");

                    b.HasKey("Id");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("KetoRecipies.Models.Recipe", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateAdded");

                    b.Property<int>("DisLikeCount");

                    b.Property<string>("Facebook");

                    b.Property<string>("ImageUrl");

                    b.Property<string>("ImgPath");

                    b.Property<bool>("IncludeSocialMediaLinks");

                    b.Property<string>("Ingridients");

                    b.Property<string>("Instagram");

                    b.Property<string>("Instructions");

                    b.Property<string>("Label");

                    b.Property<int>("LikeCount");

                    b.Property<string>("Source");

                    b.Property<string>("SourceUrl");

                    b.Property<int>("TotalCaloriesServ");

                    b.Property<int>("TotalCarbsServ");

                    b.Property<int>("TotalFatServ");

                    b.Property<int>("TotalTime");

                    b.Property<string>("Twitter");

                    b.Property<string>("Type");

                    b.Property<string>("UserId");

                    b.Property<string>("VideoUrl");

                    b.Property<int>("ViewCount");

                    b.Property<int>("Yield");

                    b.Property<string>("YouTube");

                    b.HasKey("ID");

                    b.ToTable("recipes");
                });

            modelBuilder.Entity("KetoRecipies.Models.Comments.MainComment", b =>
                {
                    b.HasOne("KetoRecipies.Models.Recipe")
                        .WithMany("Comments")
                        .HasForeignKey("RecipeID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("KetoRecipies.Models.Comments.SubComment", b =>
                {
                    b.HasOne("KetoRecipies.Models.Comments.MainComment")
                        .WithMany("SubComments")
                        .HasForeignKey("MainCommentID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("KetoRecipies.Models.Favorite", b =>
                {
                    b.HasOne("KetoRecipies.Models.Recipe", "Recipe")
                        .WithMany()
                        .HasForeignKey("RecipeID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
