﻿// <auto-generated />
using System;
using BlankFinance.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BlankFinance.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    partial class ApplicationDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BlankFinance.Models.Budget", b =>
                {
                    b.Property<Guid>("BudgetId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BudgetXML");

                    b.Property<DateTime>("Created");

                    b.Property<DateTime>("LastUsed");

                    b.HasKey("BudgetId");

                    b.ToTable("Budgets");
                });

            modelBuilder.Entity("BlankFinance.Models.Transaction", b =>
                {
                    b.Property<Guid>("TransactionId")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("Amount");

                    b.Property<string>("Category")
                        .IsRequired();

                    b.Property<DateTime>("Date");

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<string>("Type")
                        .IsRequired();

                    b.HasKey("TransactionId");

                    b.ToTable("Transactions");
                });
#pragma warning restore 612, 618
        }
    }
}