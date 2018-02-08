﻿// <auto-generated />
using JOIN.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace JOIN.Migrations
{
    [DbContext(typeof(JoinDbContext))]
    [Migration("20180208143530_fixedmodelbind")]
    partial class fixedmodelbind
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("JOIN.Models.EmailAddress", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ValidEmail");

                    b.HasKey("Id");

                    b.ToTable("EmailAddress");
                });

            modelBuilder.Entity("JOIN.Models.Registration", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("Owner");

                    b.Property<int?>("ValidEmailId");

                    b.HasKey("Id");

                    b.HasIndex("ValidEmailId");

                    b.ToTable("Registrations");
                });

            modelBuilder.Entity("JOIN.Models.Registration", b =>
                {
                    b.HasOne("JOIN.Models.EmailAddress", "ValidEmail")
                        .WithMany()
                        .HasForeignKey("ValidEmailId");
                });
#pragma warning restore 612, 618
        }
    }
}
