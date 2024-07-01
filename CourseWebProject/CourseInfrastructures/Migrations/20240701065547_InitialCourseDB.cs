using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CourseInfrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialCourseDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Categori__19093A2B4E099F62", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "Certificates",
                columns: table => new
                {
                    CertificateId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompletionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CompletionTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    IssuedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CertificateUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Certificates", x => x.CertificateId);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    RoleID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Role__8AFACE3A672CA399", x => x.RoleID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Email = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    Phone = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Password = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    Bio = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    RoleID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Users__1788CCACEF9D4767", x => x.UserID);
                    table.ForeignKey(
                        name: "FK__Users__RoleID__398D8EEE",
                        column: x => x.RoleID,
                        principalTable: "Role",
                        principalColumn: "RoleID");
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    CourseID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    InstructorID = table.Column<int>(type: "int", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Level = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Duration = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Price = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    Rating = table.Column<decimal>(type: "decimal(2,1)", nullable: true),
                    CategoryID = table.Column<int>(type: "int", nullable: true),
                    URL = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    Sale = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Courses__C92D71876D4CFFEC", x => x.CourseID);
                    table.ForeignKey(
                        name: "FK__Courses__Categor__3E52440B",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "CategoryID");
                    table.ForeignKey(
                        name: "FK__Courses__Instruc__3F466844",
                        column: x => x.InstructorID,
                        principalTable: "Users",
                        principalColumn: "UserID");
                });

            migrationBuilder.CreateTable(
                name: "StudentCertificates",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CertificateId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentCertificates", x => new { x.UserId, x.CertificateId });
                    table.ForeignKey(
                        name: "FK_StudentCertificates_Certificates_CertificateId",
                        column: x => x.CertificateId,
                        principalTable: "Certificates",
                        principalColumn: "CertificateId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentCertificates_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SystemSettings",
                columns: table => new
                {
                    SettingID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<int>(type: "int", nullable: true),
                    Theme = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Language = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    NotificationsEnabled = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__SystemSe__54372AFDC5ADF01D", x => x.SettingID);
                    table.ForeignKey(
                        name: "FK__SystemSet__UserI__59FA5E80",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "UserID");
                });

            migrationBuilder.CreateTable(
                name: "Checkouts",
                columns: table => new
                {
                    CheckoutID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentID = table.Column<int>(type: "int", nullable: true),
                    CourseID = table.Column<int>(type: "int", nullable: true),
                    PaymentDate = table.Column<DateTime>(type: "date", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    PaymentStatus = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    TransactionID = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Checkout__E07EF51CCFBA1268", x => x.CheckoutID);
                    table.ForeignKey(
                        name: "FK__Checkouts__Cours__571DF1D5",
                        column: x => x.CourseID,
                        principalTable: "Courses",
                        principalColumn: "CourseID");
                    table.ForeignKey(
                        name: "FK__Checkouts__Stude__5629CD9C",
                        column: x => x.StudentID,
                        principalTable: "Users",
                        principalColumn: "UserID");
                });

            migrationBuilder.CreateTable(
                name: "Enrollments",
                columns: table => new
                {
                    EnrollmentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentID = table.Column<int>(type: "int", nullable: true),
                    CourseID = table.Column<int>(type: "int", nullable: true),
                    EnrollmentDate = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Enrollme__7F6877FB59BADBB3", x => x.EnrollmentID);
                    table.ForeignKey(
                        name: "FK__Enrollmen__Cours__4F7CD00D",
                        column: x => x.CourseID,
                        principalTable: "Courses",
                        principalColumn: "CourseID");
                    table.ForeignKey(
                        name: "FK__Enrollmen__Stude__4E88ABD4",
                        column: x => x.StudentID,
                        principalTable: "Users",
                        principalColumn: "UserID");
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    ReviewID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentID = table.Column<int>(type: "int", nullable: true),
                    CourseID = table.Column<int>(type: "int", nullable: true),
                    Rating = table.Column<decimal>(type: "decimal(2,1)", nullable: false),
                    Comment = table.Column<string>(type: "text", nullable: true),
                    ReviewDate = table.Column<DateTime>(type: "date", nullable: false),
                    ReOpen = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Reviews__74BC79AEB05343AB", x => x.ReviewID);
                    table.ForeignKey(
                        name: "FK__Reviews__CourseI__534D60F1",
                        column: x => x.CourseID,
                        principalTable: "Courses",
                        principalColumn: "CourseID");
                    table.ForeignKey(
                        name: "FK__Reviews__Student__52593CB8",
                        column: x => x.StudentID,
                        principalTable: "Users",
                        principalColumn: "UserID");
                });

            migrationBuilder.CreateTable(
                name: "Sections",
                columns: table => new
                {
                    SectionID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseID = table.Column<int>(type: "int", nullable: true),
                    Title = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    Duration = table.Column<TimeSpan>(type: "time", unicode: false, maxLength: 50, nullable: true),
                    Position = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Sections__80EF08920752F11A", x => x.SectionID);
                    table.ForeignKey(
                        name: "FK__Sections__Course__4222D4EF",
                        column: x => x.CourseID,
                        principalTable: "Courses",
                        principalColumn: "CourseID");
                });

            migrationBuilder.CreateTable(
                name: "StudentCourses",
                columns: table => new
                {
                    UserID = table.Column<int>(type: "int", nullable: false),
                    CourseID = table.Column<int>(type: "int", nullable: false),
                    IsInCart = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__StudentC__7B1A1BB4D2465F24", x => new { x.UserID, x.CourseID });
                    table.ForeignKey(
                        name: "FK__StudentCo__Cours__4BAC3F29",
                        column: x => x.CourseID,
                        principalTable: "Courses",
                        principalColumn: "CourseID");
                    table.ForeignKey(
                        name: "FK__StudentCo__UserI__4AB81AF0",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "UserID");
                });

            migrationBuilder.CreateTable(
                name: "Documents",
                columns: table => new
                {
                    DocumentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SectionID = table.Column<int>(type: "int", nullable: true),
                    Title = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    URL = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Document__1ABEEF6F6F6C41B2", x => x.DocumentID);
                    table.ForeignKey(
                        name: "FK__Documents__Secti__47DBAE45",
                        column: x => x.SectionID,
                        principalTable: "Sections",
                        principalColumn: "SectionID");
                });

            migrationBuilder.CreateTable(
                name: "Lectures",
                columns: table => new
                {
                    LectureID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SectionID = table.Column<int>(type: "int", nullable: true),
                    Title = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    Content = table.Column<string>(type: "text", nullable: true),
                    VideoURL = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    Duration = table.Column<TimeSpan>(type: "time", unicode: false, maxLength: 50, nullable: true),
                    Position = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Lectures__B739F69F45AA0B10", x => x.LectureID);
                    table.ForeignKey(
                        name: "FK__Lectures__Sectio__44FF419A",
                        column: x => x.SectionID,
                        principalTable: "Sections",
                        principalColumn: "SectionID");
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "Name" },
                values: new object[,]
                {
                    { 1, "Category 1" },
                    { 2, "Category 2" },
                    { 3, "Category 3" },
                    { 4, "Category 4" },
                    { 5, "Category 5" }
                });

            migrationBuilder.InsertData(
                table: "Certificates",
                columns: new[] { "CertificateId", "CertificateUrl", "CompletionDate", "CompletionTime", "Description", "IssuedBy", "Title" },
                values: new object[,]
                {
                    { 1, "https://example.com/certificate1", new DateTime(2023, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0), "Description for Certificate 1", "Issuing Authority 1", "Certificate 1" },
                    { 2, "https://example.com/certificate2", new DateTime(2023, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 30, 0, 0), "Description for Certificate 2", "Issuing Authority 2", "Certificate 2" }
                });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "RoleID", "Name" },
                values: new object[,]
                {
                    { 1, "Role 1" },
                    { 2, "Role 2" },
                    { 3, "Role 3" },
                    { 4, "Role 4" },
                    { 5, "Role 5" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserID", "Bio", "Email", "FullName", "Password", "Phone", "RoleID" },
                values: new object[,]
                {
                    { 1, "Bio for User 1", "user1@example.com", "User 1", "123", "123456789", 1 },
                    { 2, "Bio for User 2", "user2@example.com", "User 2", "123", "987654321", 2 },
                    { 3, "Bio for User 3", "user3@example.com", "User 3", "123", "555555555", 3 },
                    { 4, "Bio for User 4", "user4@example.com", "User 4", "123", "111111111", 4 },
                    { 5, "Bio for User 5", "user5@example.com", "User 5", "123", "999999999", 5 }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseID", "CategoryID", "Description", "Duration", "InstructorID", "Level", "Price", "Rating", "Sale", "Title", "URL" },
                values: new object[,]
                {
                    { 1, 1, "Description for Course 1", "2 hours", 1, "Beginner", 100m, 4.5m, 10, "Course 1", "https://example.com/course1" },
                    { 2, 2, "Description for Course 2", "3 hours", 2, "Intermediate", 150m, 4.2m, 5, "Course 2", "https://example.com/course2" },
                    { 3, 3, "Description for Course 3", "2.5 hours", 3, "Advanced", 120m, 4.8m, 15, "Course 3", "https://example.com/course3" },
                    { 4, 4, "Description for Course 4", "4 hours", 4, "Expert", 200m, 4.9m, 20, "Course 4", "https://example.com/course4" },
                    { 5, 5, "Description for Course 5", "2.8 hours", 5, "Intermediate", 180m, 4.6m, 12, "Course 5", "https://example.com/course5" }
                });

            migrationBuilder.InsertData(
                table: "StudentCertificates",
                columns: new[] { "CertificateId", "UserId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 }
                });

            migrationBuilder.InsertData(
                table: "SystemSettings",
                columns: new[] { "SettingID", "Language", "NotificationsEnabled", "Theme", "UserID" },
                values: new object[,]
                {
                    { 1, "English", true, "Dark", 1 },
                    { 2, "French", false, "Light", 2 }
                });

            migrationBuilder.InsertData(
                table: "Checkouts",
                columns: new[] { "CheckoutID", "Amount", "CourseID", "PaymentDate", "PaymentStatus", "StudentID", "TransactionID" },
                values: new object[,]
                {
                    { 1, 50m, 1, new DateTime(2024, 7, 1, 13, 55, 46, 914, DateTimeKind.Local).AddTicks(8964), "Paid", 1, "1ABD" },
                    { 2, 75m, 2, new DateTime(2024, 7, 1, 13, 55, 46, 914, DateTimeKind.Local).AddTicks(8979), "Pending", 2, "16AHD" },
                    { 3, 100m, 3, new DateTime(2024, 7, 1, 13, 55, 46, 914, DateTimeKind.Local).AddTicks(8982), "Failed", 3, "1ABDOD" },
                    { 4, 120m, 4, new DateTime(2024, 7, 1, 13, 55, 46, 914, DateTimeKind.Local).AddTicks(8984), "Paid", 4, "1ADFHBD" },
                    { 5, 80m, 5, new DateTime(2024, 7, 1, 13, 55, 46, 914, DateTimeKind.Local).AddTicks(8987), "Pending", 5, "1ABDD" }
                });

            migrationBuilder.InsertData(
                table: "Enrollments",
                columns: new[] { "EnrollmentID", "CourseID", "EnrollmentDate", "StudentID" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 7, 1, 13, 55, 46, 914, DateTimeKind.Local).AddTicks(9013), 1 },
                    { 2, 2, new DateTime(2024, 7, 1, 13, 55, 46, 914, DateTimeKind.Local).AddTicks(9018), 2 },
                    { 3, 3, new DateTime(2024, 7, 1, 13, 55, 46, 914, DateTimeKind.Local).AddTicks(9020), 3 },
                    { 4, 4, new DateTime(2024, 7, 1, 13, 55, 46, 914, DateTimeKind.Local).AddTicks(9021), 4 },
                    { 5, 5, new DateTime(2024, 7, 1, 13, 55, 46, 914, DateTimeKind.Local).AddTicks(9023), 5 }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewID", "Comment", "CourseID", "Rating", "ReOpen", "ReviewDate", "StudentID" },
                values: new object[,]
                {
                    { 1, "Good course", 1, 4.5m, null, new DateTime(2024, 7, 1, 13, 55, 46, 914, DateTimeKind.Local).AddTicks(9147), 1 },
                    { 2, "Could be better", 2, 3.8m, null, new DateTime(2024, 7, 1, 13, 55, 46, 914, DateTimeKind.Local).AddTicks(9151), 2 },
                    { 3, "Excellent content", 3, 4.2m, null, new DateTime(2024, 7, 1, 13, 55, 46, 914, DateTimeKind.Local).AddTicks(9153), 3 },
                    { 4, "Very informative", 4, 4.7m, null, new DateTime(2024, 7, 1, 13, 55, 46, 914, DateTimeKind.Local).AddTicks(9155), 4 },
                    { 5, "Helped me a lot", 5, 4.0m, null, new DateTime(2024, 7, 1, 13, 55, 46, 914, DateTimeKind.Local).AddTicks(9157), 5 }
                });

            migrationBuilder.InsertData(
                table: "Sections",
                columns: new[] { "SectionID", "CourseID", "Duration", "Position", "Title" },
                values: new object[,]
                {
                    { 1, 1, new TimeSpan(0, 1, 0, 0, 0), null, "Section 1" },
                    { 2, 2, new TimeSpan(0, 1, 30, 0, 0), null, "Section 2" },
                    { 3, 3, new TimeSpan(0, 2, 0, 0, 0), null, "Section 3" },
                    { 4, 4, new TimeSpan(0, 1, 12, 0, 0), null, "Section 4" },
                    { 5, 5, new TimeSpan(0, 1, 48, 0, 0), null, "Section 5" }
                });

            migrationBuilder.InsertData(
                table: "Documents",
                columns: new[] { "DocumentID", "CreateDate", "SectionID", "Title", "URL" },
                values: new object[,]
                {
                    { 1, null, 1, "Document 1", "https://example.com/document1" },
                    { 2, null, 2, "Document 2", "https://example.com/document2" },
                    { 3, null, 3, "Document 3", "https://example.com/document3" },
                    { 4, null, 4, "Document 4", "https://example.com/document4" },
                    { 5, null, 5, "Document 5", "https://example.com/document5" }
                });

            migrationBuilder.InsertData(
                table: "Lectures",
                columns: new[] { "LectureID", "Content", "Duration", "Position", "SectionID", "Title", "VideoURL" },
                values: new object[,]
                {
                    { 1, "Lecture content 1", new TimeSpan(0, 0, 30, 0, 0), null, 1, "Lecture 1", "https://example.com/video1" },
                    { 2, "Lecture content 2", new TimeSpan(0, 0, 45, 0, 0), null, 2, "Lecture 2", "https://example.com/video2" },
                    { 3, "Lecture content 3", new TimeSpan(0, 1, 0, 0, 0), null, 3, "Lecture 3", "https://example.com/video3" },
                    { 4, "Lecture content 4", new TimeSpan(0, 0, 50, 0, 0), null, 4, "Lecture 4", "https://example.com/video4" },
                    { 5, "Lecture content 5", new TimeSpan(0, 0, 55, 0, 0), null, 5, "Lecture 5", "https://example.com/video5" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Checkouts_CourseID",
                table: "Checkouts",
                column: "CourseID");

            migrationBuilder.CreateIndex(
                name: "IX_Checkouts_StudentID",
                table: "Checkouts",
                column: "StudentID");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_CategoryID",
                table: "Courses",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_InstructorID",
                table: "Courses",
                column: "InstructorID");

            migrationBuilder.CreateIndex(
                name: "IX_Documents_SectionID",
                table: "Documents",
                column: "SectionID");

            migrationBuilder.CreateIndex(
                name: "IX_Enrollments_CourseID",
                table: "Enrollments",
                column: "CourseID");

            migrationBuilder.CreateIndex(
                name: "IX_Enrollments_StudentID",
                table: "Enrollments",
                column: "StudentID");

            migrationBuilder.CreateIndex(
                name: "IX_Lectures_SectionID",
                table: "Lectures",
                column: "SectionID");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_CourseID",
                table: "Reviews",
                column: "CourseID");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_StudentID",
                table: "Reviews",
                column: "StudentID");

            migrationBuilder.CreateIndex(
                name: "IX_Sections_CourseID",
                table: "Sections",
                column: "CourseID");

            migrationBuilder.CreateIndex(
                name: "IX_StudentCertificates_CertificateId",
                table: "StudentCertificates",
                column: "CertificateId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentCourses_CourseID",
                table: "StudentCourses",
                column: "CourseID");

            migrationBuilder.CreateIndex(
                name: "IX_SystemSettings_UserID",
                table: "SystemSettings",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Users_RoleID",
                table: "Users",
                column: "RoleID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Checkouts");

            migrationBuilder.DropTable(
                name: "Documents");

            migrationBuilder.DropTable(
                name: "Enrollments");

            migrationBuilder.DropTable(
                name: "Lectures");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "StudentCertificates");

            migrationBuilder.DropTable(
                name: "StudentCourses");

            migrationBuilder.DropTable(
                name: "SystemSettings");

            migrationBuilder.DropTable(
                name: "Sections");

            migrationBuilder.DropTable(
                name: "Certificates");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Role");
        }
    }
}
