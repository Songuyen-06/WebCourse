using System;
using System.Collections.Generic;
using CourseDomain;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace CourseInfrastructure;

public partial class CoursesDbContext : DbContext
{
    public CoursesDbContext()
    {
    }

    public CoursesDbContext(DbContextOptions<CoursesDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<Checkout> Checkouts { get; set; }

    public virtual DbSet<Course> Courses { get; set; }

    public virtual DbSet<Document> Documents { get; set; }

    public virtual DbSet<Enrollment> Enrollments { get; set; }

    public virtual DbSet<Lecture> Lectures { get; set; }

    public virtual DbSet<Review> Reviews { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<Section> Sections { get; set; }

    public virtual DbSet<StudentCourse> StudentCourses { get; set; }

    public virtual DbSet<SystemSetting> SystemSettings { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<Certificate> Certificates { get; set; }
    public virtual DbSet<StudentCertificate> StudentCertificates { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        Console.WriteLine(Directory.GetCurrentDirectory());
        IConfiguration config = new ConfigurationBuilder()
        .SetBasePath(Directory.GetCurrentDirectory())
        .AddJsonFile("appsettings.json", true, true)
        .Build();
        var strConn = config["ConnectionStrings:MyDatabase"];
        optionsBuilder.UseSqlServer(strConn);
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>().HasData(
       new Category { CategoryId = 1, Name = "Category 1" },
       new Category { CategoryId = 2, Name = "Category 2" },
       new Category { CategoryId = 3, Name = "Category 3" },
       new Category { CategoryId = 4, Name = "Category 4" },
       new Category { CategoryId = 5, Name = "Category 5" }
   );

        // Insert 5 hàng vào bảng Role
        modelBuilder.Entity<Role>().HasData(
            new Role { RoleId = 1, Name = "Role 1" },
            new Role { RoleId = 2, Name = "Role 2" },
            new Role { RoleId = 3, Name = "Role 3" },
            new Role { RoleId = 4, Name = "Role 4" },
            new Role { RoleId = 5, Name = "Role 5" }
        );

        // Insert 5 hàng vào bảng User
        modelBuilder.Entity<User>().HasData(
    new User { UserId = 1, FullName = "User 1", Email = "user1@example.com", RoleId = 1, Password = "123", Phone = "123456789", Bio = "Bio for User 1" },
    new User { UserId = 2, FullName = "User 2", Email = "user2@example.com", RoleId = 2, Password = "123", Phone = "987654321", Bio = "Bio for User 2" },
    new User { UserId = 3, FullName = "User 3", Email = "user3@example.com", RoleId = 3, Password = "123", Phone = "555555555", Bio = "Bio for User 3" },
    new User { UserId = 4, FullName = "User 4", Email = "user4@example.com", RoleId = 4, Password = "123", Phone = "111111111", Bio = "Bio for User 4" },
    new User { UserId = 5, FullName = "User 5", Email = "user5@example.com", RoleId = 5, Password = "123", Phone = "999999999", Bio = "Bio for User 5" }
);


        // Insert 5 hàng vào bảng Course
        modelBuilder.Entity<Course>().HasData(
     new Course { CourseId = 1, Title = "Course 1", CategoryId = 1, InstructorId = 1, Price = 100, Level = "Beginner", Description = "Description for Course 1", Duration = "2 hours", Rating = 4.5m, Url = "https://example.com/course1", Sale = 10 },
     new Course { CourseId = 2, Title = "Course 2", CategoryId = 2, InstructorId = 2, Price = 150, Level = "Intermediate", Description = "Description for Course 2", Duration = "3 hours", Rating = 4.2m, Url = "https://example.com/course2", Sale = 5 },
     new Course { CourseId = 3, Title = "Course 3", CategoryId = 3, InstructorId = 3, Price = 120, Level = "Advanced", Description = "Description for Course 3", Duration = "2.5 hours", Rating = 4.8m, Url = "https://example.com/course3", Sale = 15 },
     new Course { CourseId = 4, Title = "Course 4", CategoryId = 4, InstructorId = 4, Price = 200, Level = "Expert", Description = "Description for Course 4", Duration = "4 hours", Rating = 4.9m, Url = "https://example.com/course4", Sale = 20 },
     new Course { CourseId = 5, Title = "Course 5", CategoryId = 5, InstructorId = 5, Price = 180, Level = "Intermediate", Description = "Description for Course 5", Duration = "2.8 hours", Rating = 4.6m, Url = "https://example.com/course5", Sale = 12 }
 );


        modelBuilder.Entity<Checkout>().HasData(
       new Checkout { CheckoutId = 1, CourseId = 1, StudentId = 1, Amount = 50, PaymentStatus = "Paid", PaymentDate = DateTime.Now , TransactionId="1ABD"},
       new Checkout { CheckoutId = 2, CourseId = 2, StudentId = 2, Amount = 75, PaymentStatus = "Pending", PaymentDate = DateTime.Now, TransactionId = "16AHD" },
       new Checkout { CheckoutId = 3, CourseId = 3, StudentId = 3, Amount = 100, PaymentStatus = "Failed", PaymentDate = DateTime.Now, TransactionId = "1ABDOD" },
       new Checkout { CheckoutId = 4, CourseId = 4, StudentId = 4, Amount = 120, PaymentStatus = "Paid", PaymentDate = DateTime.Now , TransactionId = "1ADFHBD" },
       new Checkout { CheckoutId = 5, CourseId = 5, StudentId = 5, Amount = 80, PaymentStatus = "Pending", PaymentDate = DateTime.Now, TransactionId = "1ABDD" }
   );

      

        // Insert 5 hàng vào bảng Enrollment
        modelBuilder.Entity<Enrollment>().HasData(
            new Enrollment { EnrollmentId = 1, CourseId = 1, StudentId = 1, EnrollmentDate = DateTime.Now },
            new Enrollment { EnrollmentId = 2, CourseId = 2, StudentId = 2, EnrollmentDate = DateTime.Now },
            new Enrollment { EnrollmentId = 3, CourseId = 3, StudentId = 3, EnrollmentDate = DateTime.Now },
            new Enrollment { EnrollmentId = 4, CourseId = 4, StudentId = 4, EnrollmentDate = DateTime.Now },
            new Enrollment { EnrollmentId = 5, CourseId = 5, StudentId = 5, EnrollmentDate = DateTime.Now }
        );
        modelBuilder.Entity<Section>().HasData(
   new Section { SectionId = 1, CourseId = 1, Title = "Section 1", Duration = TimeSpan.FromHours(1) },
   new Section { SectionId = 2, CourseId = 2, Title = "Section 2", Duration = TimeSpan.FromHours(1.5) },
   new Section { SectionId = 3, CourseId = 3, Title = "Section 3", Duration = TimeSpan.FromHours(2) },
   new Section { SectionId = 4, CourseId = 4, Title = "Section 4", Duration = TimeSpan.FromHours(1.2) },
   new Section { SectionId = 5, CourseId = 5, Title = "Section 5", Duration = TimeSpan.FromHours(1.8) }
);
        // Insert 5 hàng vào bảng Lecture
        modelBuilder.Entity<Lecture>().HasData(
    new Lecture { LectureId = 1, SectionId = 1, Title = "Lecture 1", Content = "Lecture content 1", Duration = TimeSpan.FromMinutes(30), VideoUrl = "https://example.com/video1" },
    new Lecture { LectureId = 2, SectionId = 2, Title = "Lecture 2", Content = "Lecture content 2", Duration = TimeSpan.FromMinutes(45), VideoUrl = "https://example.com/video2" },
    new Lecture { LectureId = 3, SectionId = 3, Title = "Lecture 3", Content = "Lecture content 3", Duration = TimeSpan.FromMinutes(60), VideoUrl = "https://example.com/video3" },
    new Lecture { LectureId = 4, SectionId = 4, Title = "Lecture 4", Content = "Lecture content 4", Duration = TimeSpan.FromMinutes(50), VideoUrl = "https://example.com/video4" },
    new Lecture { LectureId = 5, SectionId = 5, Title = "Lecture 5", Content = "Lecture content 5", Duration = TimeSpan.FromMinutes(55), VideoUrl = "https://example.com/video5" }
);
        // Insert 5 hàng vào bảng Document
        modelBuilder.Entity<Document>().HasData(
            new Document { DocumentId = 1, SectionId = 1, Title = "Document 1", Url = "https://example.com/document1" },
            new Document { DocumentId = 2, SectionId = 2, Title = "Document 2", Url = "https://example.com/document2" },
            new Document { DocumentId = 3, SectionId = 3, Title = "Document 3", Url = "https://example.com/document3" },
            new Document { DocumentId = 4, SectionId = 4, Title = "Document 4", Url = "https://example.com/document4" },
            new Document { DocumentId = 5, SectionId = 5, Title = "Document 5", Url = "https://example.com/document5" }
        );

        // Insert 5 hàng vào bảng Review
        modelBuilder.Entity<Review>().HasData(
            new Review { ReviewId = 1, CourseId = 1, StudentId = 1, Rating = 4.5m, Comment = "Good course", ReviewDate = DateTime.Now },
            new Review { ReviewId = 2, CourseId = 2, StudentId = 2, Rating = 3.8m, Comment = "Could be better", ReviewDate = DateTime.Now },
            new Review { ReviewId = 3, CourseId = 3, StudentId = 3, Rating = 4.2m, Comment = "Excellent content", ReviewDate = DateTime.Now },
            new Review { ReviewId = 4, CourseId = 4, StudentId = 4, Rating = 4.7m, Comment = "Very informative", ReviewDate = DateTime.Now },
            new Review { ReviewId = 5, CourseId = 5, StudentId = 5, Rating = 4.0m, Comment = "Helped me a lot", ReviewDate = DateTime.Now }
        );

        // Insert 5 hàng vào bảng Section
     
        modelBuilder.Entity<Certificate>().HasData(
         new Certificate { CertificateId = 1, Title = "Certificate 1", Description = "Description for Certificate 1", CompletionDate = new DateTime(2023, 5, 15), CompletionTime = TimeSpan.FromHours(2), IssuedBy = "Issuing Authority 1", CertificateUrl = "https://example.com/certificate1" },
         new Certificate { CertificateId = 2, Title = "Certificate 2", Description = "Description for Certificate 2", CompletionDate = new DateTime(2023, 6, 20), CompletionTime = TimeSpan.FromHours(1.5), IssuedBy = "Issuing Authority 2", CertificateUrl = "https://example.com/certificate2" }
     );

        modelBuilder.Entity<StudentCertificate>().HasData(
            new StudentCertificate { UserId = 1, CertificateId = 1 },
            new StudentCertificate { UserId = 2, CertificateId = 2 }
        );

        modelBuilder.Entity<SystemSetting>().HasData(
            new SystemSetting { SettingId = 1, UserId = 1, Theme = "Dark", Language = "English", NotificationsEnabled = true },
            new SystemSetting { SettingId = 2, UserId = 2, Theme = "Light", Language = "French", NotificationsEnabled = false }
        );




        modelBuilder.Entity<StudentCertificate>()
           .HasKey(sc => new { sc.UserId, sc.CertificateId });

        modelBuilder.Entity<StudentCertificate>()
            .HasOne(sc => sc.User)
            .WithMany(u => u.StudentCertificates)
            .HasForeignKey(sc => sc.UserId);

        modelBuilder.Entity<StudentCertificate>()
            .HasOne(sc => sc.Certificate)
            .WithMany(c => c.StudentCertificates)
            .HasForeignKey(sc => sc.CertificateId);

        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasKey(e => e.CategoryId).HasName("PK__Categori__19093A2B4E099F62");

            entity.Property(e => e.CategoryId).HasColumnName("CategoryID");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Checkout>(entity =>
        {
            entity.HasKey(e => e.CheckoutId).HasName("PK__Checkout__E07EF51CCFBA1268");

            entity.Property(e => e.CheckoutId).HasColumnName("CheckoutID");
            entity.Property(e => e.Amount).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.CourseId).HasColumnName("CourseID");
            entity.Property(e => e.PaymentDate).HasColumnType("date");
            entity.Property(e => e.PaymentStatus)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.StudentId).HasColumnName("StudentID");
            entity.Property(e => e.TransactionId)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("TransactionID");

            entity.HasOne(d => d.Course).WithMany(p => p.Checkouts)
                .HasForeignKey(d => d.CourseId)
                .HasConstraintName("FK__Checkouts__Cours__571DF1D5");

            entity.HasOne(d => d.Student).WithMany(p => p.Checkouts)
                .HasForeignKey(d => d.StudentId)
                .HasConstraintName("FK__Checkouts__Stude__5629CD9C");
        });

        modelBuilder.Entity<Course>(entity =>
        {
            entity.HasKey(e => e.CourseId).HasName("PK__Courses__C92D71876D4CFFEC");

            entity.Property(e => e.CourseId).HasColumnName("CourseID");
            entity.Property(e => e.CategoryId).HasColumnName("CategoryID");
            entity.Property(e => e.Description).HasColumnType("text");
            entity.Property(e => e.Duration)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.InstructorId).HasColumnName("InstructorID");
            entity.Property(e => e.Level)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Price).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.Rating).HasColumnType("decimal(2, 1)");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Url)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("URL");

            entity.HasOne(d => d.Category).WithMany(p => p.Courses)
                .HasForeignKey(d => d.CategoryId)
                .HasConstraintName("FK__Courses__Categor__3E52440B");

            entity.HasOne(d => d.Instructor).WithMany(p => p.Courses)
                .HasForeignKey(d => d.InstructorId)
                .HasConstraintName("FK__Courses__Instruc__3F466844");
        });

        modelBuilder.Entity<Document>(entity =>
        {
            entity.HasKey(e => e.DocumentId).HasName("PK__Document__1ABEEF6F6F6C41B2");

            entity.Property(e => e.DocumentId).HasColumnName("DocumentID");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.SectionId).HasColumnName("SectionID");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Url)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("URL");

            entity.HasOne(d => d.Section).WithMany(p => p.Documents)
                .HasForeignKey(d => d.SectionId)
                .HasConstraintName("FK__Documents__Secti__47DBAE45");
        });

        modelBuilder.Entity<Enrollment>(entity =>
        {
            entity.HasKey(e => e.EnrollmentId).HasName("PK__Enrollme__7F6877FB59BADBB3");

            entity.Property(e => e.EnrollmentId).HasColumnName("EnrollmentID");
            entity.Property(e => e.CourseId).HasColumnName("CourseID");
            entity.Property(e => e.EnrollmentDate).HasColumnType("date");
            entity.Property(e => e.StudentId).HasColumnName("StudentID");

            entity.HasOne(d => d.Course).WithMany(p => p.Enrollments)
                .HasForeignKey(d => d.CourseId)
                .HasConstraintName("FK__Enrollmen__Cours__4F7CD00D");

            entity.HasOne(d => d.Student).WithMany(p => p.Enrollments)
                .HasForeignKey(d => d.StudentId)
                .HasConstraintName("FK__Enrollmen__Stude__4E88ABD4");
        });

        modelBuilder.Entity<Lecture>(entity =>
        {
            entity.HasKey(e => e.LectureId).HasName("PK__Lectures__B739F69F45AA0B10");

            entity.Property(e => e.LectureId).HasColumnName("LectureID");
            entity.Property(e => e.Content).HasColumnType("text");
            entity.Property(e => e.Duration)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SectionId).HasColumnName("SectionID");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.VideoUrl)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("VideoURL");

            entity.HasOne(d => d.Section).WithMany(p => p.Lectures)
                .HasForeignKey(d => d.SectionId)
                .HasConstraintName("FK__Lectures__Sectio__44FF419A");
        });

        modelBuilder.Entity<Review>(entity =>
        {
            entity.HasKey(e => e.ReviewId).HasName("PK__Reviews__74BC79AEB05343AB");

            entity.Property(e => e.ReviewId).HasColumnName("ReviewID");
            entity.Property(e => e.Comment).HasColumnType("text");
            entity.Property(e => e.CourseId).HasColumnName("CourseID");
            entity.Property(e => e.Rating).HasColumnType("decimal(2, 1)");
            entity.Property(e => e.ReviewDate).HasColumnType("date");
            entity.Property(e => e.ReOpen).HasColumnType("int");

            entity.Property(e => e.StudentId).HasColumnName("StudentID");

            entity.HasOne(d => d.Course).WithMany(p => p.Reviews)
                .HasForeignKey(d => d.CourseId)
                .HasConstraintName("FK__Reviews__CourseI__534D60F1");

            entity.HasOne(d => d.Student).WithMany(p => p.Reviews)
                .HasForeignKey(d => d.StudentId)
                .HasConstraintName("FK__Reviews__Student__52593CB8");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.RoleId).HasName("PK__Role__8AFACE3A672CA399");

            entity.ToTable("Role");

            entity.Property(e => e.RoleId).HasColumnName("RoleID");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Section>(entity =>
        {
            entity.HasKey(e => e.SectionId).HasName("PK__Sections__80EF08920752F11A");

            entity.Property(e => e.SectionId).HasColumnName("SectionID");
            entity.Property(e => e.CourseId).HasColumnName("CourseID");
            entity.Property(e => e.Duration)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.HasOne(d => d.Course).WithMany(p => p.Sections)
                .HasForeignKey(d => d.CourseId)
                .HasConstraintName("FK__Sections__Course__4222D4EF");
        });

        modelBuilder.Entity<StudentCourse>(entity =>
        {
            entity.HasKey(e => new { e.UserId, e.CourseId }).HasName("PK__StudentC__7B1A1BB4D2465F24");

            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.CourseId).HasColumnName("CourseID");

            entity.HasOne(d => d.Course).WithMany(p => p.StudentCourses)
                .HasForeignKey(d => d.CourseId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__StudentCo__Cours__4BAC3F29");

            entity.HasOne(d => d.User).WithMany(p => p.StudentCourses)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__StudentCo__UserI__4AB81AF0");
        });

        modelBuilder.Entity<SystemSetting>(entity =>
        {
            entity.HasKey(e => e.SettingId).HasName("PK__SystemSe__54372AFDC5ADF01D");

            entity.Property(e => e.SettingId).HasColumnName("SettingID");
            entity.Property(e => e.Language)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Theme)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.User).WithMany(p => p.SystemSettings)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK__SystemSet__UserI__59FA5E80");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__Users__1788CCACEF9D4767");

            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.Bio).HasMaxLength(500);
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.FullName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Password)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Phone)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.RoleId).HasColumnName("RoleID");

            entity.HasOne(d => d.Role).WithMany(p => p.Users)
                .HasForeignKey(d => d.RoleId)
                .HasConstraintName("FK__Users__RoleID__398D8EEE");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
