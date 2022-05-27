﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using artifact_manager2.Database.Context;

namespace artifact_manager2.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220526134054_AddIntegerForeignKeys")]
    partial class AddIntegerForeignKeys
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("artifact_manager2.Database.Models.Attribute", b =>
                {
                    b.Property<int>("AttributeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TypeOfAttribute")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AttributeId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Attributes");
                });

            modelBuilder.Entity("artifact_manager2.Database.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SuperClass")
                        .HasColumnType("int");

                    b.Property<int?>("SuperClassCategoryCategoryId")
                        .HasColumnType("int");

                    b.HasKey("CategoryId");

                    b.HasIndex("SuperClassCategoryCategoryId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("artifact_manager2.Database.Models.CategoryAttribute", b =>
                {
                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("AttributeId")
                        .HasColumnType("int");

                    b.HasKey("CategoryId", "AttributeId");

                    b.HasIndex("AttributeId");

                    b.ToTable("CategoryAttributes");
                });

            modelBuilder.Entity("artifact_manager2.Database.Models.FloatValue", b =>
                {
                    b.Property<int>("RepresentativeId")
                        .HasColumnType("int");

                    b.Property<int>("AttributeId")
                        .HasColumnType("int");

                    b.Property<float>("Value")
                        .HasColumnType("real");

                    b.HasKey("RepresentativeId", "AttributeId");

                    b.HasIndex("AttributeId");

                    b.ToTable("FloatValuess");
                });

            modelBuilder.Entity("artifact_manager2.Database.Models.IntegerValue", b =>
                {
                    b.Property<int>("RepresentativeId")
                        .HasColumnType("int");

                    b.Property<int>("AttributeId")
                        .HasColumnType("int");

                    b.Property<int>("Value")
                        .HasColumnType("int");

                    b.HasKey("RepresentativeId", "AttributeId");

                    b.HasIndex("AttributeId");

                    b.ToTable("IntegerValues");
                });

            modelBuilder.Entity("artifact_manager2.Database.Models.Representative", b =>
                {
                    b.Property<int>("RepresentativeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.HasKey("RepresentativeId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Representatives");
                });

            modelBuilder.Entity("artifact_manager2.Database.Models.Role", b =>
                {
                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("CanAddClasses")
                        .HasColumnType("bit");

                    b.Property<bool>("CanAddRecords")
                        .HasColumnType("bit");

                    b.Property<bool>("CanDeleteClasses")
                        .HasColumnType("bit");

                    b.Property<bool>("CanDeleteRecords")
                        .HasColumnType("bit");

                    b.Property<bool>("CanUpdateClasses")
                        .HasColumnType("bit");

                    b.Property<bool>("CanUpdateRecords")
                        .HasColumnType("bit");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RoleId");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("artifact_manager2.Database.Models.StringValue", b =>
                {
                    b.Property<int>("RepresentativeId")
                        .HasColumnType("int");

                    b.Property<int>("AttributeId")
                        .HasColumnType("int");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RepresentativeId", "AttributeId");

                    b.HasIndex("AttributeId");

                    b.ToTable("StringValues");
                });

            modelBuilder.Entity("artifact_manager2.Database.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("artifact_manager2.Database.Models.UserRole", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("UserRoles");
                });

            modelBuilder.Entity("artifact_manager2.Database.Models.Attribute", b =>
                {
                    b.HasOne("artifact_manager2.Database.Models.Category", null)
                        .WithMany("Attributes")
                        .HasForeignKey("CategoryId");
                });

            modelBuilder.Entity("artifact_manager2.Database.Models.Category", b =>
                {
                    b.HasOne("artifact_manager2.Database.Models.Category", "SuperClassCategory")
                        .WithMany()
                        .HasForeignKey("SuperClassCategoryCategoryId");
                });

            modelBuilder.Entity("artifact_manager2.Database.Models.CategoryAttribute", b =>
                {
                    b.HasOne("artifact_manager2.Database.Models.Attribute", "Attribute")
                        .WithMany()
                        .HasForeignKey("AttributeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("artifact_manager2.Database.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("artifact_manager2.Database.Models.FloatValue", b =>
                {
                    b.HasOne("artifact_manager2.Database.Models.Attribute", "Attribute")
                        .WithMany()
                        .HasForeignKey("AttributeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("artifact_manager2.Database.Models.Representative", "Representative")
                        .WithMany()
                        .HasForeignKey("RepresentativeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("artifact_manager2.Database.Models.IntegerValue", b =>
                {
                    b.HasOne("artifact_manager2.Database.Models.Attribute", "attribute")
                        .WithMany()
                        .HasForeignKey("AttributeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("artifact_manager2.Database.Models.Representative", "representative")
                        .WithMany()
                        .HasForeignKey("RepresentativeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("artifact_manager2.Database.Models.Representative", b =>
                {
                    b.HasOne("artifact_manager2.Database.Models.Category", null)
                        .WithMany("Representatives")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("artifact_manager2.Database.Models.StringValue", b =>
                {
                    b.HasOne("artifact_manager2.Database.Models.Attribute", "attribute")
                        .WithMany()
                        .HasForeignKey("AttributeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("artifact_manager2.Database.Models.Representative", "representative")
                        .WithMany()
                        .HasForeignKey("RepresentativeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("artifact_manager2.Database.Models.UserRole", b =>
                {
                    b.HasOne("artifact_manager2.Database.Models.Role", "Role")
                        .WithMany("userRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("artifact_manager2.Database.Models.User", "User")
                        .WithMany("userRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
