﻿// <auto-generated />
using System;
using HMSystem.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HMSystem.Migrations
{
    [DbContext(typeof(HMSystemDbContext))]
    [Migration("20191127134455_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HMSystem.Person", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreationTime");

                    b.Property<long?>("CreatorUserId");

                    b.Property<DateTime?>("LastModificationTime");

                    b.Property<long?>("LastModifierUserId");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(32);

                    b.HasKey("Id");

                    b.ToTable("AppPersons");
                });

            modelBuilder.Entity("HMSystem.ServicePersonalBase", b =>
                {
                    b.Property<int>("ServicePersonalID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<Guid?>("AssignedPersonId");

                    b.Property<DateTime>("BirthDay");

                    b.Property<DateTime>("CreationTime");

                    b.Property<string>("Description")
                        .HasMaxLength(65536);

                    b.Property<string>("IDCard")
                        .HasMaxLength(256);

                    b.Property<int>("Id");

                    b.Property<int>("NumberOfRoles");

                    b.Property<string>("SelfIntroduction")
                        .HasMaxLength(256);

                    b.Property<int>("ServicePersonalGender");

                    b.Property<string>("ServicePersonalName")
                        .HasMaxLength(256);

                    b.Property<string>("ServiceRegion")
                        .HasMaxLength(256);

                    b.Property<byte>("State");

                    b.Property<string>("TelephoneNumber")
                        .HasMaxLength(256);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(256);

                    b.Property<int>("Type");

                    b.HasKey("ServicePersonalID");

                    b.HasIndex("AssignedPersonId");

                    b.ToTable("ServicePersonalBaseInfo");
                });

            modelBuilder.Entity("HMSystem.ServicePersonalBase", b =>
                {
                    b.HasOne("HMSystem.Person", "AssignedPerson")
                        .WithMany()
                        .HasForeignKey("AssignedPersonId");
                });
#pragma warning restore 612, 618
        }
    }
}