﻿// <auto-generated />
using System;
using CRM_MED.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CRM_MED.Migrations
{
    [DbContext(typeof(CRMmedContext))]
    partial class CRMmedContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CRM_MED.Models.Admin", b =>
                {
                    b.Property<int>("AdminId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AdminId"));

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("nvarchar(8)");

                    b.HasKey("AdminId");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("CRM_MED.Models.DayOfWeek", b =>
                {
                    b.Property<int>("DayOfWeekId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DayOfWeekId"));

                    b.Property<string>("DayOfWeekName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("DayOfWeekId");

                    b.ToTable("DayOfWeeks");
                });

            modelBuilder.Entity("CRM_MED.Models.Doctor", b =>
                {
                    b.Property<int>("DoctorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DoctorId"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("nvarchar(8)");

                    b.Property<string>("Patronymic")
                        .IsRequired()
                        .HasMaxLength(71)
                        .HasColumnType("nvarchar(71)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("PhotoPath")
                        .IsRequired()
                        .HasMaxLength(600)
                        .HasColumnType("nvarchar(600)");

                    b.Property<string>("Speciality")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("DoctorId");

                    b.ToTable("Doctors");
                });

            modelBuilder.Entity("CRM_MED.Models.Gender", b =>
                {
                    b.Property<int>("GenderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GenderId"));

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("nvarchar(2)");

                    b.HasKey("GenderId");

                    b.ToTable("Genders");
                });

            modelBuilder.Entity("CRM_MED.Models.MaterialType", b =>
                {
                    b.Property<int>("MaterialTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaterialTypeId"));

                    b.Property<string>("MaterialTypeTitle")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("MaterialTypeId");

                    b.ToTable("MaterialTypes");
                });

            modelBuilder.Entity("CRM_MED.Models.MedicalCard", b =>
                {
                    b.Property<int>("MedicalCardId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MedicalCardId"));

                    b.Property<string>("Complaints")
                        .IsRequired()
                        .HasMaxLength(153)
                        .HasColumnType("nvarchar(153)");

                    b.Property<string>("CourseOfTreatment")
                        .IsRequired()
                        .HasMaxLength(800)
                        .HasColumnType("nvarchar(800)");

                    b.Property<DateTime>("DateOfCompletion")
                        .HasColumnType("datetime2");

                    b.Property<string>("Diagnosis")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("DoctorComment")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<int>("DoctorId")
                        .HasColumnType("int");

                    b.Property<int>("PatientId")
                        .HasColumnType("int");

                    b.Property<string>("Treatment")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.HasKey("MedicalCardId");

                    b.HasIndex("DoctorId");

                    b.HasIndex("PatientId")
                        .IsUnique();

                    b.ToTable("MedicalCards");
                });

            modelBuilder.Entity("CRM_MED.Models.Patient", b =>
                {
                    b.Property<int>("PatientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PatientId"));

                    b.Property<DateTime>("BirthDay")
                        .HasColumnType("datetime2");

                    b.Property<string>("ChronicDiseases")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<int>("GenderCodeNavigationGenderId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Passport")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("Patronymic")
                        .IsRequired()
                        .HasMaxLength(71)
                        .HasColumnType("nvarchar(71)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("PhotoPath")
                        .IsRequired()
                        .HasMaxLength(600)
                        .HasColumnType("nvarchar(600)");

                    b.Property<string>("PlaceOfRegistration")
                        .IsRequired()
                        .HasMaxLength(400)
                        .HasColumnType("nvarchar(400)");

                    b.Property<string>("PolicyNumber")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("nvarchar(32)");

                    b.Property<string>("SNILS")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("PatientId");

                    b.HasIndex("GenderCodeNavigationGenderId");

                    b.ToTable("Patients");
                });

            modelBuilder.Entity("CRM_MED.Models.Reception", b =>
                {
                    b.Property<int>("ReceptionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ReceptionId"));

                    b.Property<int>("DoctorId")
                        .HasColumnType("int");

                    b.Property<int>("PatientId")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime2");

                    b.HasKey("ReceptionId");

                    b.HasIndex("DoctorId");

                    b.HasIndex("PatientId");

                    b.ToTable("Receptions");
                });

            modelBuilder.Entity("CRM_MED.Models.Storage", b =>
                {
                    b.Property<int>("StorageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StorageId"));

                    b.Property<int>("Count")
                        .HasColumnType("int");

                    b.Property<DateTime>("ExpirationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("MaterialName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("MaterialTypeNavigationMaterialTypeId")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("UnitNavigationUnitId")
                        .HasColumnType("int");

                    b.HasKey("StorageId");

                    b.HasIndex("MaterialTypeNavigationMaterialTypeId");

                    b.HasIndex("UnitNavigationUnitId");

                    b.ToTable("Storages");
                });

            modelBuilder.Entity("CRM_MED.Models.Supplier", b =>
                {
                    b.Property<int>("SupplierId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SupplierId"));

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<int>("MaterialTypeNavigationMaterialTypeId")
                        .HasColumnType("int");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("SupplierId");

                    b.HasIndex("MaterialTypeNavigationMaterialTypeId");

                    b.ToTable("Suppliers");
                });

            modelBuilder.Entity("CRM_MED.Models.Unit", b =>
                {
                    b.Property<int>("UnitId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UnitId"));

                    b.Property<string>("UnitName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("UnitId");

                    b.ToTable("Units");
                });

            modelBuilder.Entity("CRM_MED.Models.WorkTime", b =>
                {
                    b.Property<int>("WorkTimeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("WorkTimeId"));

                    b.Property<int>("DayNavigationDayOfWeekId")
                        .HasColumnType("int");

                    b.Property<bool>("IsWorking")
                        .HasColumnType("bit");

                    b.Property<DateTime>("LunchEnd")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("LunchStart")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("WorkEnd")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("WorkStart")
                        .HasColumnType("datetime2");

                    b.HasKey("WorkTimeId");

                    b.HasIndex("DayNavigationDayOfWeekId");

                    b.ToTable("WorkTimes");
                });

            modelBuilder.Entity("CRM_MED.Models.MedicalCard", b =>
                {
                    b.HasOne("CRM_MED.Models.Doctor", "Doctor")
                        .WithMany("MedicalCards")
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CRM_MED.Models.Patient", "Patient")
                        .WithOne("medicalCard")
                        .HasForeignKey("CRM_MED.Models.MedicalCard", "PatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Doctor");

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("CRM_MED.Models.Patient", b =>
                {
                    b.HasOne("CRM_MED.Models.Gender", "GenderCodeNavigation")
                        .WithMany("Patients")
                        .HasForeignKey("GenderCodeNavigationGenderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("GenderCodeNavigation");
                });

            modelBuilder.Entity("CRM_MED.Models.Reception", b =>
                {
                    b.HasOne("CRM_MED.Models.Doctor", "Doctor")
                        .WithMany("Receptions")
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CRM_MED.Models.Patient", "Patient")
                        .WithMany("Receptions")
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Doctor");

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("CRM_MED.Models.Storage", b =>
                {
                    b.HasOne("CRM_MED.Models.MaterialType", "MaterialTypeNavigation")
                        .WithMany("Storages")
                        .HasForeignKey("MaterialTypeNavigationMaterialTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CRM_MED.Models.Unit", "UnitNavigation")
                        .WithMany("Storages")
                        .HasForeignKey("UnitNavigationUnitId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MaterialTypeNavigation");

                    b.Navigation("UnitNavigation");
                });

            modelBuilder.Entity("CRM_MED.Models.Supplier", b =>
                {
                    b.HasOne("CRM_MED.Models.MaterialType", "MaterialTypeNavigation")
                        .WithMany("Suppliers")
                        .HasForeignKey("MaterialTypeNavigationMaterialTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MaterialTypeNavigation");
                });

            modelBuilder.Entity("CRM_MED.Models.WorkTime", b =>
                {
                    b.HasOne("CRM_MED.Models.DayOfWeek", "DayNavigation")
                        .WithMany("WorkTimes")
                        .HasForeignKey("DayNavigationDayOfWeekId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DayNavigation");
                });

            modelBuilder.Entity("CRM_MED.Models.DayOfWeek", b =>
                {
                    b.Navigation("WorkTimes");
                });

            modelBuilder.Entity("CRM_MED.Models.Doctor", b =>
                {
                    b.Navigation("MedicalCards");

                    b.Navigation("Receptions");
                });

            modelBuilder.Entity("CRM_MED.Models.Gender", b =>
                {
                    b.Navigation("Patients");
                });

            modelBuilder.Entity("CRM_MED.Models.MaterialType", b =>
                {
                    b.Navigation("Storages");

                    b.Navigation("Suppliers");
                });

            modelBuilder.Entity("CRM_MED.Models.Patient", b =>
                {
                    b.Navigation("Receptions");

                    b.Navigation("medicalCard")
                        .IsRequired();
                });

            modelBuilder.Entity("CRM_MED.Models.Unit", b =>
                {
                    b.Navigation("Storages");
                });
#pragma warning restore 612, 618
        }
    }
}
