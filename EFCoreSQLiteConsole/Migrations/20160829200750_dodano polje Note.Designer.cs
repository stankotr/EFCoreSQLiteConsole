using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using EFCoreSQLiteConsole.Context;

namespace EFCoreSQLiteConsole.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20160829200750_dodano polje Note")]
    partial class dodanopoljeNote
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc1-16348");

            modelBuilder.Entity("EFCoreSQLiteConsole.Models.Beer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<string>("Note");

                    b.HasKey("Id");
                });
        }
    }
}
