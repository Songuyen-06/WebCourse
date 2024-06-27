using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CourseInfrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddCertificateModels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK__Checkouts__Cours__5EBF139D",
                table: "Checkouts");

            migrationBuilder.DropForeignKey(
                name: "FK__Checkouts__Stude__5DCAEF64",
                table: "Checkouts");

            migrationBuilder.DropForeignKey(
                name: "FK__Courses__Categor__48CFD27E",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK__Courses__Instruc__49C3F6B7",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK__Enrollmen__Cours__571DF1D5",
                table: "Enrollments");

            migrationBuilder.DropForeignKey(
                name: "FK__Enrollmen__Stude__5629CD9C",
                table: "Enrollments");

            migrationBuilder.DropForeignKey(
                name: "FK__Lectures__Sectio__4F7CD00D",
                table: "Lectures");

            migrationBuilder.DropForeignKey(
                name: "FK__Reviews__CourseI__5AEE82B9",
                table: "Reviews");

            migrationBuilder.DropForeignKey(
                name: "FK__Reviews__Student__59FA5E80",
                table: "Reviews");

            migrationBuilder.DropForeignKey(
                name: "FK__Sections__Course__4CA06362",
                table: "Sections");

            migrationBuilder.DropForeignKey(
                name: "FK__StudentCo__Cours__534D60F1",
                table: "StudentCourses");

            migrationBuilder.DropForeignKey(
                name: "FK__StudentCo__UserI__52593CB8",
                table: "StudentCourses");

            migrationBuilder.DropForeignKey(
                name: "FK__Users__RoleID__440B1D61",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK__Users__1788CCAC981B88AF",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK__StudentC__7B1A1BB406BDC762",
                table: "StudentCourses");

            migrationBuilder.DropPrimaryKey(
                name: "PK__Sections__80EF0892F00F11E0",
                table: "Sections");

            migrationBuilder.DropPrimaryKey(
                name: "PK__Role__8AFACE3AB9C692EB",
                table: "Role");

            migrationBuilder.DropPrimaryKey(
                name: "PK__Reviews__74BC79AE02ABBEA8",
                table: "Reviews");

            migrationBuilder.DropPrimaryKey(
                name: "PK__Lectures__B739F69F6144E8EB",
                table: "Lectures");

            migrationBuilder.DropPrimaryKey(
                name: "PK__Enrollme__7F6877FB1A50426C",
                table: "Enrollments");

            migrationBuilder.DropPrimaryKey(
                name: "PK__Courses__C92D718776EFE5F8",
                table: "Courses");

            migrationBuilder.DropPrimaryKey(
                name: "PK__Checkout__E07EF51CF6A8F43E",
                table: "Checkouts");

            migrationBuilder.DropPrimaryKey(
                name: "PK__Categori__19093A2B1C92A134",
                table: "Categories");

            migrationBuilder.AddPrimaryKey(
                name: "PK__Users__1788CCACEF9D4767",
                table: "Users",
                column: "UserID");

            migrationBuilder.AddPrimaryKey(
                name: "PK__StudentC__7B1A1BB4D2465F24",
                table: "StudentCourses",
                columns: new[] { "UserID", "CourseID" });

            migrationBuilder.AddPrimaryKey(
                name: "PK__Sections__80EF08920752F11A",
                table: "Sections",
                column: "SectionID");

            migrationBuilder.AddPrimaryKey(
                name: "PK__Role__8AFACE3A672CA399",
                table: "Role",
                column: "RoleID");

            migrationBuilder.AddPrimaryKey(
                name: "PK__Reviews__74BC79AEB05343AB",
                table: "Reviews",
                column: "ReviewID");

            migrationBuilder.AddPrimaryKey(
                name: "PK__Lectures__B739F69F45AA0B10",
                table: "Lectures",
                column: "LectureID");

            migrationBuilder.AddPrimaryKey(
                name: "PK__Enrollme__7F6877FB59BADBB3",
                table: "Enrollments",
                column: "EnrollmentID");

            migrationBuilder.AddPrimaryKey(
                name: "PK__Courses__C92D71876D4CFFEC",
                table: "Courses",
                column: "CourseID");

            migrationBuilder.AddPrimaryKey(
                name: "PK__Checkout__E07EF51CCFBA1268",
                table: "Checkouts",
                column: "CheckoutID");

            migrationBuilder.AddPrimaryKey(
                name: "PK__Categori__19093A2B4E099F62",
                table: "Categories",
                column: "CategoryID");

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

            migrationBuilder.CreateIndex(
                name: "IX_Documents_SectionID",
                table: "Documents",
                column: "SectionID");

            migrationBuilder.CreateIndex(
                name: "IX_StudentCertificates_CertificateId",
                table: "StudentCertificates",
                column: "CertificateId");

            migrationBuilder.CreateIndex(
                name: "IX_SystemSettings_UserID",
                table: "SystemSettings",
                column: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK__Checkouts__Cours__571DF1D5",
                table: "Checkouts",
                column: "CourseID",
                principalTable: "Courses",
                principalColumn: "CourseID");

            migrationBuilder.AddForeignKey(
                name: "FK__Checkouts__Stude__5629CD9C",
                table: "Checkouts",
                column: "StudentID",
                principalTable: "Users",
                principalColumn: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK__Courses__Categor__3E52440B",
                table: "Courses",
                column: "CategoryID",
                principalTable: "Categories",
                principalColumn: "CategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK__Courses__Instruc__3F466844",
                table: "Courses",
                column: "InstructorID",
                principalTable: "Users",
                principalColumn: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK__Enrollmen__Cours__4F7CD00D",
                table: "Enrollments",
                column: "CourseID",
                principalTable: "Courses",
                principalColumn: "CourseID");

            migrationBuilder.AddForeignKey(
                name: "FK__Enrollmen__Stude__4E88ABD4",
                table: "Enrollments",
                column: "StudentID",
                principalTable: "Users",
                principalColumn: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK__Lectures__Sectio__44FF419A",
                table: "Lectures",
                column: "SectionID",
                principalTable: "Sections",
                principalColumn: "SectionID");

            migrationBuilder.AddForeignKey(
                name: "FK__Reviews__CourseI__534D60F1",
                table: "Reviews",
                column: "CourseID",
                principalTable: "Courses",
                principalColumn: "CourseID");

            migrationBuilder.AddForeignKey(
                name: "FK__Reviews__Student__52593CB8",
                table: "Reviews",
                column: "StudentID",
                principalTable: "Users",
                principalColumn: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK__Sections__Course__4222D4EF",
                table: "Sections",
                column: "CourseID",
                principalTable: "Courses",
                principalColumn: "CourseID");

            migrationBuilder.AddForeignKey(
                name: "FK__StudentCo__Cours__4BAC3F29",
                table: "StudentCourses",
                column: "CourseID",
                principalTable: "Courses",
                principalColumn: "CourseID");

            migrationBuilder.AddForeignKey(
                name: "FK__StudentCo__UserI__4AB81AF0",
                table: "StudentCourses",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK__Users__RoleID__398D8EEE",
                table: "Users",
                column: "RoleID",
                principalTable: "Role",
                principalColumn: "RoleID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK__Checkouts__Cours__571DF1D5",
                table: "Checkouts");

            migrationBuilder.DropForeignKey(
                name: "FK__Checkouts__Stude__5629CD9C",
                table: "Checkouts");

            migrationBuilder.DropForeignKey(
                name: "FK__Courses__Categor__3E52440B",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK__Courses__Instruc__3F466844",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK__Enrollmen__Cours__4F7CD00D",
                table: "Enrollments");

            migrationBuilder.DropForeignKey(
                name: "FK__Enrollmen__Stude__4E88ABD4",
                table: "Enrollments");

            migrationBuilder.DropForeignKey(
                name: "FK__Lectures__Sectio__44FF419A",
                table: "Lectures");

            migrationBuilder.DropForeignKey(
                name: "FK__Reviews__CourseI__534D60F1",
                table: "Reviews");

            migrationBuilder.DropForeignKey(
                name: "FK__Reviews__Student__52593CB8",
                table: "Reviews");

            migrationBuilder.DropForeignKey(
                name: "FK__Sections__Course__4222D4EF",
                table: "Sections");

            migrationBuilder.DropForeignKey(
                name: "FK__StudentCo__Cours__4BAC3F29",
                table: "StudentCourses");

            migrationBuilder.DropForeignKey(
                name: "FK__StudentCo__UserI__4AB81AF0",
                table: "StudentCourses");

            migrationBuilder.DropForeignKey(
                name: "FK__Users__RoleID__398D8EEE",
                table: "Users");

            migrationBuilder.DropTable(
                name: "Documents");

            migrationBuilder.DropTable(
                name: "StudentCertificates");

            migrationBuilder.DropTable(
                name: "SystemSettings");

            migrationBuilder.DropTable(
                name: "Certificates");

            migrationBuilder.DropPrimaryKey(
                name: "PK__Users__1788CCACEF9D4767",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK__StudentC__7B1A1BB4D2465F24",
                table: "StudentCourses");

            migrationBuilder.DropPrimaryKey(
                name: "PK__Sections__80EF08920752F11A",
                table: "Sections");

            migrationBuilder.DropPrimaryKey(
                name: "PK__Role__8AFACE3A672CA399",
                table: "Role");

            migrationBuilder.DropPrimaryKey(
                name: "PK__Reviews__74BC79AEB05343AB",
                table: "Reviews");

            migrationBuilder.DropPrimaryKey(
                name: "PK__Lectures__B739F69F45AA0B10",
                table: "Lectures");

            migrationBuilder.DropPrimaryKey(
                name: "PK__Enrollme__7F6877FB59BADBB3",
                table: "Enrollments");

            migrationBuilder.DropPrimaryKey(
                name: "PK__Courses__C92D71876D4CFFEC",
                table: "Courses");

            migrationBuilder.DropPrimaryKey(
                name: "PK__Checkout__E07EF51CCFBA1268",
                table: "Checkouts");

            migrationBuilder.DropPrimaryKey(
                name: "PK__Categori__19093A2B4E099F62",
                table: "Categories");

            migrationBuilder.AddPrimaryKey(
                name: "PK__Users__1788CCAC981B88AF",
                table: "Users",
                column: "UserID");

            migrationBuilder.AddPrimaryKey(
                name: "PK__StudentC__7B1A1BB406BDC762",
                table: "StudentCourses",
                columns: new[] { "UserID", "CourseID" });

            migrationBuilder.AddPrimaryKey(
                name: "PK__Sections__80EF0892F00F11E0",
                table: "Sections",
                column: "SectionID");

            migrationBuilder.AddPrimaryKey(
                name: "PK__Role__8AFACE3AB9C692EB",
                table: "Role",
                column: "RoleID");

            migrationBuilder.AddPrimaryKey(
                name: "PK__Reviews__74BC79AE02ABBEA8",
                table: "Reviews",
                column: "ReviewID");

            migrationBuilder.AddPrimaryKey(
                name: "PK__Lectures__B739F69F6144E8EB",
                table: "Lectures",
                column: "LectureID");

            migrationBuilder.AddPrimaryKey(
                name: "PK__Enrollme__7F6877FB1A50426C",
                table: "Enrollments",
                column: "EnrollmentID");

            migrationBuilder.AddPrimaryKey(
                name: "PK__Courses__C92D718776EFE5F8",
                table: "Courses",
                column: "CourseID");

            migrationBuilder.AddPrimaryKey(
                name: "PK__Checkout__E07EF51CF6A8F43E",
                table: "Checkouts",
                column: "CheckoutID");

            migrationBuilder.AddPrimaryKey(
                name: "PK__Categori__19093A2B1C92A134",
                table: "Categories",
                column: "CategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK__Checkouts__Cours__5EBF139D",
                table: "Checkouts",
                column: "CourseID",
                principalTable: "Courses",
                principalColumn: "CourseID");

            migrationBuilder.AddForeignKey(
                name: "FK__Checkouts__Stude__5DCAEF64",
                table: "Checkouts",
                column: "StudentID",
                principalTable: "Users",
                principalColumn: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK__Courses__Categor__48CFD27E",
                table: "Courses",
                column: "CategoryID",
                principalTable: "Categories",
                principalColumn: "CategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK__Courses__Instruc__49C3F6B7",
                table: "Courses",
                column: "InstructorID",
                principalTable: "Users",
                principalColumn: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK__Enrollmen__Cours__571DF1D5",
                table: "Enrollments",
                column: "CourseID",
                principalTable: "Courses",
                principalColumn: "CourseID");

            migrationBuilder.AddForeignKey(
                name: "FK__Enrollmen__Stude__5629CD9C",
                table: "Enrollments",
                column: "StudentID",
                principalTable: "Users",
                principalColumn: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK__Lectures__Sectio__4F7CD00D",
                table: "Lectures",
                column: "SectionID",
                principalTable: "Sections",
                principalColumn: "SectionID");

            migrationBuilder.AddForeignKey(
                name: "FK__Reviews__CourseI__5AEE82B9",
                table: "Reviews",
                column: "CourseID",
                principalTable: "Courses",
                principalColumn: "CourseID");

            migrationBuilder.AddForeignKey(
                name: "FK__Reviews__Student__59FA5E80",
                table: "Reviews",
                column: "StudentID",
                principalTable: "Users",
                principalColumn: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK__Sections__Course__4CA06362",
                table: "Sections",
                column: "CourseID",
                principalTable: "Courses",
                principalColumn: "CourseID");

            migrationBuilder.AddForeignKey(
                name: "FK__StudentCo__Cours__534D60F1",
                table: "StudentCourses",
                column: "CourseID",
                principalTable: "Courses",
                principalColumn: "CourseID");

            migrationBuilder.AddForeignKey(
                name: "FK__StudentCo__UserI__52593CB8",
                table: "StudentCourses",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK__Users__RoleID__440B1D61",
                table: "Users",
                column: "RoleID",
                principalTable: "Role",
                principalColumn: "RoleID");
        }
    }
}
