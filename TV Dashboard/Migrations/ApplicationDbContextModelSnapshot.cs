﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TV_Dashboard.DbContext;

#nullable disable

namespace TV_Dashboard.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("TV_Dashboard.Models.LogsModel", b =>
                {
                    b.Property<int>("LogId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LogId"), 1L, 1);

                    b.Property<string>("ApplicationName")
                        .IsRequired()
                        .HasColumnType("varchar(250)");

                    b.Property<string>("LogDate")
                        .IsRequired()
                        .HasColumnType("varchar(10)");

                    b.Property<string>("LogTime")
                        .IsRequired()
                        .HasColumnType("varchar(8)");

                    b.Property<string>("ProcessName")
                        .IsRequired()
                        .HasColumnType("varchar(250)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("varchar(250)");

                    b.HasKey("LogId");

                    b.ToTable("MainLogsTable");
                });
#pragma warning restore 612, 618
        }
    }
}
