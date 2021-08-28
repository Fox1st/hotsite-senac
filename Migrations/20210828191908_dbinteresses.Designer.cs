﻿// <auto-generated />
using Hotsite.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Hotsite.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20210828191908_dbinteresses")]
    partial class dbinteresses
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("Hotsite.Models.Interesse", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Email")
                        .HasColumnType("character varying(156)")
                        .HasMaxLength(156);

                    b.Property<string>("Mensagem")
                        .HasColumnType("character varying(512)")
                        .HasMaxLength(512);

                    b.Property<string>("Nome")
                        .HasColumnType("character varying(156)")
                        .HasMaxLength(156);

                    b.HasKey("Id");

                    b.ToTable("Interesses");
                });
#pragma warning restore 612, 618
        }
    }
}
