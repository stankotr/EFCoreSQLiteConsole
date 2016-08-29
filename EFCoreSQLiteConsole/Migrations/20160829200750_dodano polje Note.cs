using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace EFCoreSQLiteConsole.Migrations
{
    public partial class dodanopoljeNote : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Note",
                table: "Beer",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(name: "Note", table: "Beer");
        }
    }
}
