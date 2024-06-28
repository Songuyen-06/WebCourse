﻿// <auto-generated />
using System;
using CourseInfrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CourseInfrastructure.Migrations
{
    [DbContext(typeof(CoursesDbContext))]
    [Migration("20240627131622_AddCertificateModels")]
    partial class AddCertificateModels
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.18")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CourseDomain.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("CategoryID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.HasKey("CategoryId")
                        .HasName("PK__Categori__19093A2B4E099F62");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("CourseDomain.Certificate", b =>
                {
                    b.Property<int>("CertificateId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CertificateId"));

                    b.Property<string>("CertificateUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CompletionDate")
                        .HasColumnType("datetime2");

                    b.Property<TimeSpan>("CompletionTime")
                        .HasColumnType("time");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IssuedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CertificateId");

                    b.ToTable("Certificates");
                });

            modelBuilder.Entity("CourseDomain.Checkout", b =>
                {
                    b.Property<int>("CheckoutId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("CheckoutID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CheckoutId"));

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(10, 2)");

                    b.Property<int?>("CourseId")
                        .HasColumnType("int")
                        .HasColumnName("CourseID");

                    b.Property<DateTime>("PaymentDate")
                        .HasColumnType("date");

                    b.Property<string>("PaymentStatus")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<int?>("StudentId")
                        .HasColumnType("int")
                        .HasColumnName("StudentID");

                    b.Property<string>("TransactionId")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("TransactionID");

                    b.HasKey("CheckoutId")
                        .HasName("PK__Checkout__E07EF51CCFBA1268");

                    b.HasIndex("CourseId");

                    b.HasIndex("StudentId");

                    b.ToTable("Checkouts");
                });

            modelBuilder.Entity("CourseDomain.Course", b =>
                {
                    b.Property<int>("CourseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("CourseID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CourseId"));

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int")
                        .HasColumnName("CategoryID");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("Duration")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<int?>("InstructorId")
                        .HasColumnType("int")
                        .HasColumnName("InstructorID");

                    b.Property<string>("Level")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<decimal?>("Price")
                        .HasColumnType("decimal(10, 2)");

                    b.Property<decimal?>("Rating")
                        .HasColumnType("decimal(2, 1)");

                    b.Property<int>("Sale")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Url")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("URL");

                    b.HasKey("CourseId")
                        .HasName("PK__Courses__C92D71876D4CFFEC");

                    b.HasIndex("CategoryId");

                    b.HasIndex("InstructorId");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("CourseDomain.Document", b =>
                {
                    b.Property<int>("DocumentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("DocumentID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DocumentId"));

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime");

                    b.Property<int?>("SectionId")
                        .HasColumnType("int")
                        .HasColumnName("SectionID");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Url")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("URL");

                    b.HasKey("DocumentId")
                        .HasName("PK__Document__1ABEEF6F6F6C41B2");

                    b.HasIndex("SectionId");

                    b.ToTable("Documents");
                });

            modelBuilder.Entity("CourseDomain.Enrollment", b =>
                {
                    b.Property<int>("EnrollmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("EnrollmentID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EnrollmentId"));

                    b.Property<int?>("CourseId")
                        .HasColumnType("int")
                        .HasColumnName("CourseID");

                    b.Property<DateTime?>("EnrollmentDate")
                        .HasColumnType("date");

                    b.Property<int?>("StudentId")
                        .HasColumnType("int")
                        .HasColumnName("StudentID");

                    b.HasKey("EnrollmentId")
                        .HasName("PK__Enrollme__7F6877FB59BADBB3");

                    b.HasIndex("CourseId");

                    b.HasIndex("StudentId");

                    b.ToTable("Enrollments");
                });

            modelBuilder.Entity("CourseDomain.Lecture", b =>
                {
                    b.Property<int>("LectureId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("LectureID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LectureId"));

                    b.Property<string>("Content")
                        .HasColumnType("text");

                    b.Property<string>("Duration")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<int?>("Position")
                        .HasColumnType("int");

                    b.Property<int?>("SectionId")
                        .HasColumnType("int")
                        .HasColumnName("SectionID");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("VideoUrl")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("VideoURL");

                    b.HasKey("LectureId")
                        .HasName("PK__Lectures__B739F69F45AA0B10");

                    b.HasIndex("SectionId");

                    b.ToTable("Lectures");
                });

            modelBuilder.Entity("CourseDomain.Review", b =>
                {
                    b.Property<int>("ReviewId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ReviewID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ReviewId"));

                    b.Property<string>("Comment")
                        .HasColumnType("text");

                    b.Property<int?>("CourseId")
                        .HasColumnType("int")
                        .HasColumnName("CourseID");

                    b.Property<decimal>("Rating")
                        .HasColumnType("decimal(2, 1)");

                    b.Property<DateTime>("ReviewDate")
                        .HasColumnType("date");

                    b.Property<int?>("StudentId")
                        .HasColumnType("int")
                        .HasColumnName("StudentID");

                    b.HasKey("ReviewId")
                        .HasName("PK__Reviews__74BC79AEB05343AB");

                    b.HasIndex("CourseId");

                    b.HasIndex("StudentId");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("CourseDomain.Role", b =>
                {
                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("RoleID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RoleId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.HasKey("RoleId")
                        .HasName("PK__Role__8AFACE3A672CA399");

                    b.ToTable("Role", (string)null);
                });

            modelBuilder.Entity("CourseDomain.Section", b =>
                {
                    b.Property<int>("SectionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("SectionID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SectionId"));

                    b.Property<int?>("CourseId")
                        .HasColumnType("int")
                        .HasColumnName("CourseID");

                    b.Property<string>("Duration")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<int?>("Position")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.HasKey("SectionId")
                        .HasName("PK__Sections__80EF08920752F11A");

                    b.HasIndex("CourseId");

                    b.ToTable("Sections");
                });

            modelBuilder.Entity("CourseDomain.StudentCertificate", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("CertificateId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "CertificateId");

                    b.HasIndex("CertificateId");

                    b.ToTable("StudentCertificates");
                });

            modelBuilder.Entity("CourseDomain.StudentCourse", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("UserID");

                    b.Property<int>("CourseId")
                        .HasColumnType("int")
                        .HasColumnName("CourseID");

                    b.Property<bool>("IsInCart")
                        .HasColumnType("bit");

                    b.HasKey("UserId", "CourseId")
                        .HasName("PK__StudentC__7B1A1BB4D2465F24");

                    b.HasIndex("CourseId");

                    b.ToTable("StudentCourses");
                });

            modelBuilder.Entity("CourseDomain.SystemSetting", b =>
                {
                    b.Property<int>("SettingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("SettingID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SettingId"));

                    b.Property<string>("Language")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<bool>("NotificationsEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("Theme")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<int?>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("UserID");

                    b.HasKey("SettingId")
                        .HasName("PK__SystemSe__54372AFDC5ADF01D");

                    b.HasIndex("UserId");

                    b.ToTable("SystemSettings");
                });

            modelBuilder.Entity("CourseDomain.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("UserID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<string>("Bio")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("FullName")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Phone")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<int?>("RoleId")
                        .HasColumnType("int")
                        .HasColumnName("RoleID");

                    b.HasKey("UserId")
                        .HasName("PK__Users__1788CCACEF9D4767");

                    b.HasIndex("RoleId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("CourseDomain.Checkout", b =>
                {
                    b.HasOne("CourseDomain.Course", "Course")
                        .WithMany("Checkouts")
                        .HasForeignKey("CourseId")
                        .HasConstraintName("FK__Checkouts__Cours__571DF1D5");

                    b.HasOne("CourseDomain.User", "Student")
                        .WithMany("Checkouts")
                        .HasForeignKey("StudentId")
                        .HasConstraintName("FK__Checkouts__Stude__5629CD9C");

                    b.Navigation("Course");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("CourseDomain.Course", b =>
                {
                    b.HasOne("CourseDomain.Category", "Category")
                        .WithMany("Courses")
                        .HasForeignKey("CategoryId")
                        .HasConstraintName("FK__Courses__Categor__3E52440B");

                    b.HasOne("CourseDomain.User", "Instructor")
                        .WithMany("Courses")
                        .HasForeignKey("InstructorId")
                        .HasConstraintName("FK__Courses__Instruc__3F466844");

                    b.Navigation("Category");

                    b.Navigation("Instructor");
                });

            modelBuilder.Entity("CourseDomain.Document", b =>
                {
                    b.HasOne("CourseDomain.Section", "Section")
                        .WithMany("Documents")
                        .HasForeignKey("SectionId")
                        .HasConstraintName("FK__Documents__Secti__47DBAE45");

                    b.Navigation("Section");
                });

            modelBuilder.Entity("CourseDomain.Enrollment", b =>
                {
                    b.HasOne("CourseDomain.Course", "Course")
                        .WithMany("Enrollments")
                        .HasForeignKey("CourseId")
                        .HasConstraintName("FK__Enrollmen__Cours__4F7CD00D");

                    b.HasOne("CourseDomain.User", "Student")
                        .WithMany("Enrollments")
                        .HasForeignKey("StudentId")
                        .HasConstraintName("FK__Enrollmen__Stude__4E88ABD4");

                    b.Navigation("Course");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("CourseDomain.Lecture", b =>
                {
                    b.HasOne("CourseDomain.Section", "Section")
                        .WithMany("Lectures")
                        .HasForeignKey("SectionId")
                        .HasConstraintName("FK__Lectures__Sectio__44FF419A");

                    b.Navigation("Section");
                });

            modelBuilder.Entity("CourseDomain.Review", b =>
                {
                    b.HasOne("CourseDomain.Course", "Course")
                        .WithMany("Reviews")
                        .HasForeignKey("CourseId")
                        .HasConstraintName("FK__Reviews__CourseI__534D60F1");

                    b.HasOne("CourseDomain.User", "Student")
                        .WithMany("Reviews")
                        .HasForeignKey("StudentId")
                        .HasConstraintName("FK__Reviews__Student__52593CB8");

                    b.Navigation("Course");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("CourseDomain.Section", b =>
                {
                    b.HasOne("CourseDomain.Course", "Course")
                        .WithMany("Sections")
                        .HasForeignKey("CourseId")
                        .HasConstraintName("FK__Sections__Course__4222D4EF");

                    b.Navigation("Course");
                });

            modelBuilder.Entity("CourseDomain.StudentCertificate", b =>
                {
                    b.HasOne("CourseDomain.Certificate", "Certificate")
                        .WithMany("StudentCertificates")
                        .HasForeignKey("CertificateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CourseDomain.User", "User")
                        .WithMany("StudentCertificates")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Certificate");

                    b.Navigation("User");
                });

            modelBuilder.Entity("CourseDomain.StudentCourse", b =>
                {
                    b.HasOne("CourseDomain.Course", "Course")
                        .WithMany("StudentCourses")
                        .HasForeignKey("CourseId")
                        .IsRequired()
                        .HasConstraintName("FK__StudentCo__Cours__4BAC3F29");

                    b.HasOne("CourseDomain.User", "User")
                        .WithMany("StudentCourses")
                        .HasForeignKey("UserId")
                        .IsRequired()
                        .HasConstraintName("FK__StudentCo__UserI__4AB81AF0");

                    b.Navigation("Course");

                    b.Navigation("User");
                });

            modelBuilder.Entity("CourseDomain.SystemSetting", b =>
                {
                    b.HasOne("CourseDomain.User", "User")
                        .WithMany("SystemSettings")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK__SystemSet__UserI__59FA5E80");

                    b.Navigation("User");
                });

            modelBuilder.Entity("CourseDomain.User", b =>
                {
                    b.HasOne("CourseDomain.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .HasConstraintName("FK__Users__RoleID__398D8EEE");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("CourseDomain.Category", b =>
                {
                    b.Navigation("Courses");
                });

            modelBuilder.Entity("CourseDomain.Certificate", b =>
                {
                    b.Navigation("StudentCertificates");
                });

            modelBuilder.Entity("CourseDomain.Course", b =>
                {
                    b.Navigation("Checkouts");

                    b.Navigation("Enrollments");

                    b.Navigation("Reviews");

                    b.Navigation("Sections");

                    b.Navigation("StudentCourses");
                });

            modelBuilder.Entity("CourseDomain.Role", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("CourseDomain.Section", b =>
                {
                    b.Navigation("Documents");

                    b.Navigation("Lectures");
                });

            modelBuilder.Entity("CourseDomain.User", b =>
                {
                    b.Navigation("Checkouts");

                    b.Navigation("Courses");

                    b.Navigation("Enrollments");

                    b.Navigation("Reviews");

                    b.Navigation("StudentCertificates");

                    b.Navigation("StudentCourses");

                    b.Navigation("SystemSettings");
                });
#pragma warning restore 612, 618
        }
    }
}