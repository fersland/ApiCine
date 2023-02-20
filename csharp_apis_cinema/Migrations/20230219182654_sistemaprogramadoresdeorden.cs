﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace csharp_apis_cinema.Migrations
{
    /// <inheritdoc />
    public partial class sistemaprogramadoresdeorden : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Orden",
                table: "SistemasProgramadores",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Orden",
                table: "SistemasProgramadores");
        }
    }
}
