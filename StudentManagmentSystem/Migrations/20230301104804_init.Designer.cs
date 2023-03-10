﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StudentManagmentSystem.Models;

#nullable disable

namespace StudentManagmentSystem.Migrations
{
    [DbContext(typeof(StudentDbContext))]
    [Migration("20230301104804_init")]
    partial class init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("StudentManagmentSystem.Models.EducationDetails", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("College")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Degree")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("EducationType")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.Property<string>("University")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("StudentId");

                    b.ToTable("EducationDetail");
                });

            modelBuilder.Entity("StudentManagmentSystem.Models.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StudentId"));

                    b.Property<string>("AbcId")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("AddressLine1")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("AddressLine2")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Cluster")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("Course")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("DateOfBirth")
                        .IsRequired()
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("Department")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("EmailId")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("FatherEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("FatherMobile")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("FatherName")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("IdNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("IdType")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("MaritialStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("MiddleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("MotherEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("MotherMobile")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("MotherName")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Other1")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Other2")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Other3")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Other4")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Other5")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Other6")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("StudentMobile")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Uid")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StudentId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("StudentManagmentSystem.Models.EducationDetails", b =>
                {
                    b.HasOne("StudentManagmentSystem.Models.Student", null)
                        .WithMany("educationDetails")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("StudentManagmentSystem.Models.Student", b =>
                {
                    b.Navigation("educationDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
