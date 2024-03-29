﻿using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KetoRecipies.Migrations.KetoDb
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Likes",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RecipeId = table.Column<int>(nullable: false),
                    UserId = table.Column<string>(nullable: true),
                    Liked = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Likes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ProductUrl = table.Column<string>(nullable: true),
                    ImageUrl = table.Column<string>(nullable: true),
                    ProductType = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "recipes",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateAdded = table.Column<DateTime>(nullable: false),
                    IncludeSocialMediaLinks = table.Column<bool>(nullable: false),
                    Facebook = table.Column<string>(nullable: true),
                    YouTube = table.Column<string>(nullable: true),
                    Instagram = table.Column<string>(nullable: true),
                    Twitter = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    Label = table.Column<string>(nullable: true),
                    Ingridients = table.Column<string>(nullable: true),
                    Instructions = table.Column<string>(nullable: true),
                    Source = table.Column<string>(nullable: true),
                    SourceUrl = table.Column<string>(nullable: true),
                    Yield = table.Column<int>(nullable: false),
                    TotalTime = table.Column<int>(nullable: false),
                    TotalCarbsServ = table.Column<int>(nullable: false),
                    TotalFatServ = table.Column<int>(nullable: false),
                    TotalCaloriesServ = table.Column<int>(nullable: false),
                    ImageUrl = table.Column<string>(nullable: true),
                    ImgPath = table.Column<string>(nullable: true),
                    VideoUrl = table.Column<string>(nullable: true),
                    LikeCount = table.Column<int>(nullable: false),
                    DisLikeCount = table.Column<int>(nullable: false),
                    ViewCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_recipes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "favorites",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserID = table.Column<string>(nullable: true),
                    RecipeID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_favorites", x => x.ID);
                    table.ForeignKey(
                        name: "FK_favorites_recipes_RecipeID",
                        column: x => x.RecipeID,
                        principalTable: "recipes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "mainComments",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Message = table.Column<string>(nullable: true),
                    DateTime = table.Column<DateTime>(nullable: false),
                    User = table.Column<string>(nullable: true),
                    RecipeID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mainComments", x => x.ID);
                    table.ForeignKey(
                        name: "FK_mainComments_recipes_RecipeID",
                        column: x => x.RecipeID,
                        principalTable: "recipes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "subComments",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Message = table.Column<string>(nullable: true),
                    DateTime = table.Column<DateTime>(nullable: false),
                    User = table.Column<string>(nullable: true),
                    MainCommentID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_subComments", x => x.ID);
                    table.ForeignKey(
                        name: "FK_subComments_mainComments_MainCommentID",
                        column: x => x.MainCommentID,
                        principalTable: "mainComments",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_favorites_RecipeID",
                table: "favorites",
                column: "RecipeID");

            migrationBuilder.CreateIndex(
                name: "IX_mainComments_RecipeID",
                table: "mainComments",
                column: "RecipeID");

            migrationBuilder.CreateIndex(
                name: "IX_subComments_MainCommentID",
                table: "subComments",
                column: "MainCommentID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "favorites");

            migrationBuilder.DropTable(
                name: "Likes");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "subComments");

            migrationBuilder.DropTable(
                name: "mainComments");

            migrationBuilder.DropTable(
                name: "recipes");
        }
    }
}
