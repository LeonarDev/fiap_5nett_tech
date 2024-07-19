﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using fiap_5nett_tech.Infrastructure.Data;

#nullable disable

namespace fiap_5nett_tech.Infrastructure.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("fiap_5nett_tech.Domain.Entities.Contact", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("DDD")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("NVARCHAR");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("NVARCHAR");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(9)
                        .HasColumnType("VARCHAR");

                    b.HasKey("Id");

                    b.HasIndex("DDD");

                    b.ToTable("Contact", (string)null);
                });

            modelBuilder.Entity("fiap_5nett_tech.Domain.Entities.Region", b =>
                {
                    b.Property<int>("Ddd")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("NVARCHAR");

                    b.HasKey("Ddd");

                    b.ToTable("Region", (string)null);

                    b.HasData(
                        new
                        {
                            Ddd = 11,
                            Name = "São Paulo"
                        },
                        new
                        {
                            Ddd = 12,
                            Name = "São Paulo"
                        },
                        new
                        {
                            Ddd = 13,
                            Name = "São Paulo"
                        },
                        new
                        {
                            Ddd = 14,
                            Name = "São Paulo"
                        },
                        new
                        {
                            Ddd = 15,
                            Name = "São Paulo"
                        },
                        new
                        {
                            Ddd = 16,
                            Name = "São Paulo"
                        },
                        new
                        {
                            Ddd = 17,
                            Name = "São Paulo"
                        },
                        new
                        {
                            Ddd = 18,
                            Name = "São Paulo"
                        },
                        new
                        {
                            Ddd = 19,
                            Name = "São Paulo"
                        },
                        new
                        {
                            Ddd = 21,
                            Name = "Rio de Janeiro"
                        },
                        new
                        {
                            Ddd = 22,
                            Name = "Rio de Janeiro"
                        },
                        new
                        {
                            Ddd = 24,
                            Name = "Rio de Janeiro"
                        },
                        new
                        {
                            Ddd = 27,
                            Name = "Espírito Santo"
                        },
                        new
                        {
                            Ddd = 28,
                            Name = "Espírito Santo"
                        },
                        new
                        {
                            Ddd = 31,
                            Name = "Minas Gerais"
                        },
                        new
                        {
                            Ddd = 32,
                            Name = "Minas Gerais"
                        },
                        new
                        {
                            Ddd = 33,
                            Name = "Minas Gerais"
                        },
                        new
                        {
                            Ddd = 34,
                            Name = "Minas Gerais"
                        },
                        new
                        {
                            Ddd = 35,
                            Name = "Minas Gerais"
                        },
                        new
                        {
                            Ddd = 37,
                            Name = "Minas Gerais"
                        },
                        new
                        {
                            Ddd = 38,
                            Name = "Minas Gerais"
                        },
                        new
                        {
                            Ddd = 41,
                            Name = "Paraná"
                        },
                        new
                        {
                            Ddd = 42,
                            Name = "Paraná"
                        },
                        new
                        {
                            Ddd = 43,
                            Name = "Paraná"
                        },
                        new
                        {
                            Ddd = 44,
                            Name = "Paraná"
                        },
                        new
                        {
                            Ddd = 45,
                            Name = "Paraná"
                        },
                        new
                        {
                            Ddd = 46,
                            Name = "Paraná"
                        },
                        new
                        {
                            Ddd = 47,
                            Name = "Santa Catarina"
                        },
                        new
                        {
                            Ddd = 48,
                            Name = "Santa Catarina"
                        },
                        new
                        {
                            Ddd = 49,
                            Name = "Santa Catarina"
                        },
                        new
                        {
                            Ddd = 51,
                            Name = "Rio Grande do Sul"
                        },
                        new
                        {
                            Ddd = 53,
                            Name = "Rio Grande do Sul"
                        },
                        new
                        {
                            Ddd = 54,
                            Name = "Rio Grande do Sul"
                        },
                        new
                        {
                            Ddd = 55,
                            Name = "Rio Grande do Sul"
                        },
                        new
                        {
                            Ddd = 61,
                            Name = "Distrito Federal"
                        },
                        new
                        {
                            Ddd = 62,
                            Name = "Goiás"
                        },
                        new
                        {
                            Ddd = 63,
                            Name = "Tocantins"
                        },
                        new
                        {
                            Ddd = 64,
                            Name = "Goiás"
                        },
                        new
                        {
                            Ddd = 65,
                            Name = "Mato Grosso"
                        },
                        new
                        {
                            Ddd = 66,
                            Name = "Mato Grosso"
                        },
                        new
                        {
                            Ddd = 67,
                            Name = "Mato Grosso do Sul"
                        },
                        new
                        {
                            Ddd = 68,
                            Name = "Acre"
                        },
                        new
                        {
                            Ddd = 69,
                            Name = "Rondônia"
                        },
                        new
                        {
                            Ddd = 71,
                            Name = "Bahia"
                        },
                        new
                        {
                            Ddd = 73,
                            Name = "Bahia"
                        },
                        new
                        {
                            Ddd = 74,
                            Name = "Bahia"
                        },
                        new
                        {
                            Ddd = 75,
                            Name = "Bahia"
                        },
                        new
                        {
                            Ddd = 77,
                            Name = "Bahia"
                        },
                        new
                        {
                            Ddd = 79,
                            Name = "Sergipe"
                        },
                        new
                        {
                            Ddd = 81,
                            Name = "Pernambuco"
                        },
                        new
                        {
                            Ddd = 82,
                            Name = "Alagoas"
                        },
                        new
                        {
                            Ddd = 83,
                            Name = "Paraíba"
                        },
                        new
                        {
                            Ddd = 84,
                            Name = "Rio Grande do Norte"
                        },
                        new
                        {
                            Ddd = 85,
                            Name = "Ceará"
                        },
                        new
                        {
                            Ddd = 86,
                            Name = "Piauí"
                        },
                        new
                        {
                            Ddd = 87,
                            Name = "Pernambuco"
                        },
                        new
                        {
                            Ddd = 88,
                            Name = "Ceará"
                        },
                        new
                        {
                            Ddd = 89,
                            Name = "Piauí"
                        },
                        new
                        {
                            Ddd = 91,
                            Name = "Pará"
                        },
                        new
                        {
                            Ddd = 92,
                            Name = "Amazonas"
                        },
                        new
                        {
                            Ddd = 93,
                            Name = "Pará"
                        },
                        new
                        {
                            Ddd = 94,
                            Name = "Pará"
                        },
                        new
                        {
                            Ddd = 95,
                            Name = "Roraima"
                        },
                        new
                        {
                            Ddd = 96,
                            Name = "Amapá"
                        },
                        new
                        {
                            Ddd = 97,
                            Name = "Amazonas"
                        },
                        new
                        {
                            Ddd = 98,
                            Name = "Maranhão"
                        },
                        new
                        {
                            Ddd = 99,
                            Name = "Maranhão"
                        });
                });

            modelBuilder.Entity("fiap_5nett_tech.Domain.Entities.Contact", b =>
                {
                    b.HasOne("fiap_5nett_tech.Domain.Entities.Region", "Ddd")
                        .WithMany("Contacts")
                        .HasForeignKey("DDD")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_CONTACT_REGION");

                    b.Navigation("Ddd");
                });

            modelBuilder.Entity("fiap_5nett_tech.Domain.Entities.Region", b =>
                {
                    b.Navigation("Contacts");
                });
#pragma warning restore 612, 618
        }
    }
}
