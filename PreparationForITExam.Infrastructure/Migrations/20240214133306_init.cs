using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PreparationForITExam.Infrastructure.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    City = table.Column<string>(type: "nvarchar(169)", maxLength: 169, nullable: true),
                    AboutMe = table.Column<string>(type: "nvarchar(700)", maxLength: 700, nullable: true),
                    RoleName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConnectionId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProfilePictureUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ModuleOfCurricular",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModuleOfCurricular", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Schools",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    NormalizedName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    City = table.Column<string>(type: "nvarchar(169)", maxLength: 169, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schools", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Messages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SenderId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SenderName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReceiverId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReceiverName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MessageText = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Messages_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MonUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MonUsers_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NewsComments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: false),
                    PostedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NewsComments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NewsComments_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    ShortDescription = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(3000)", maxLength: 3000, nullable: false),
                    PostedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    UsefulUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Likes = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Posts_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SectionsOfCurricular",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    ModuleOfCurricularId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SectionsOfCurricular", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SectionsOfCurricular_ModuleOfCurricular_ModuleOfCurricularId",
                        column: x => x.ModuleOfCurricularId,
                        principalTable: "ModuleOfCurricular",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Speciality = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    Grade = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SchoolId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Students_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Students_Schools_SchoolId",
                        column: x => x.SchoolId,
                        principalTable: "Schools",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Experience = table.Column<int>(type: "int", nullable: false),
                    Subject = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SchoolId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Teachers_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Teachers_Schools_SchoolId",
                        column: x => x.SchoolId,
                        principalTable: "Schools",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "News",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(3000)", maxLength: 3000, nullable: false),
                    SeenByPeople = table.Column<int>(type: "int", nullable: false),
                    PostedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    MonId = table.Column<int>(type: "int", nullable: false),
                    UsefulUrls = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_News", x => x.Id);
                    table.ForeignKey(
                        name: "FK_News_MonUsers_MonId",
                        column: x => x.MonId,
                        principalTable: "MonUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PostComments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: false),
                    PostedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PostId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostComments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PostComments_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PostComments_Posts_PostId",
                        column: x => x.PostId,
                        principalTable: "Posts",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Exercises",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Content = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    SectionOfCurricularId = table.Column<int>(type: "int", nullable: false),
                    TeacherId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exercises", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Exercises_SectionsOfCurricular_SectionOfCurricularId",
                        column: x => x.SectionOfCurricularId,
                        principalTable: "SectionsOfCurricular",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Exercises_Teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UrlPath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    NewsId = table.Column<int>(type: "int", nullable: true),
                    PostId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Images_News_NewsId",
                        column: x => x.NewsId,
                        principalTable: "News",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Images_Posts_PostId",
                        column: x => x.PostId,
                        principalTable: "Posts",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ExerciseMaterials",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    UrlPath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FileFormat = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ExerciseId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExerciseMaterials", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExerciseMaterials_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExerciseMaterials_Exercises_ExerciseId",
                        column: x => x.ExerciseId,
                        principalTable: "Exercises",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ExerciseStudent",
                columns: table => new
                {
                    FinishedExercisesId = table.Column<int>(type: "int", nullable: false),
                    StudentsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExerciseStudent", x => new { x.FinishedExercisesId, x.StudentsId });
                    table.ForeignKey(
                        name: "FK_ExerciseStudent_Exercises_FinishedExercisesId",
                        column: x => x.FinishedExercisesId,
                        principalTable: "Exercises",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExerciseStudent_Students_StudentsId",
                        column: x => x.StudentsId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Lessons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    SectionOfCurricularId = table.Column<int>(type: "int", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    ExerciseId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lessons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Lessons_Exercises_ExerciseId",
                        column: x => x.ExerciseId,
                        principalTable: "Exercises",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Lessons_SectionsOfCurricular_SectionOfCurricularId",
                        column: x => x.SectionOfCurricularId,
                        principalTable: "SectionsOfCurricular",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LessonComment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    Content = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    LessonId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExerciseId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LessonComment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LessonComment_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LessonComment_Exercises_ExerciseId",
                        column: x => x.ExerciseId,
                        principalTable: "Exercises",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_LessonComment_Lessons_LessonId",
                        column: x => x.LessonId,
                        principalTable: "Lessons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LessonMonUser",
                columns: table => new
                {
                    LessonId = table.Column<int>(type: "int", nullable: false),
                    MonUserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LessonMonUser", x => new { x.LessonId, x.MonUserId });
                    table.ForeignKey(
                        name: "FK_LessonMonUser_Lessons_LessonId",
                        column: x => x.LessonId,
                        principalTable: "Lessons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LessonMonUser_MonUsers_MonUserId",
                        column: x => x.MonUserId,
                        principalTable: "MonUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LessonTeacher",
                columns: table => new
                {
                    LessonsId = table.Column<int>(type: "int", nullable: false),
                    TeachersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LessonTeacher", x => new { x.LessonsId, x.TeachersId });
                    table.ForeignKey(
                        name: "FK_LessonTeacher_Lessons_LessonsId",
                        column: x => x.LessonsId,
                        principalTable: "Lessons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LessonTeacher_Teachers_TeachersId",
                        column: x => x.TeachersId,
                        principalTable: "Teachers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RequestsExercises",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeacherId = table.Column<int>(type: "int", nullable: false),
                    ExerciseId = table.Column<int>(type: "int", nullable: false),
                    ChangedContent = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: false),
                    Suggestion = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequestsExercises", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RequestsExercises_Lessons_ExerciseId",
                        column: x => x.ExerciseId,
                        principalTable: "Lessons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RequestsExercises_Teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RequestsLessons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeacherId = table.Column<int>(type: "int", nullable: false),
                    LessonId = table.Column<int>(type: "int", nullable: false),
                    ChangedContent = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: false),
                    Suggestion = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequestsLessons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RequestsLessons_Lessons_LessonId",
                        column: x => x.LessonId,
                        principalTable: "Lessons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RequestsLessons_Teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LessonMaterials",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    UrlPath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FileFormat = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LessonId = table.Column<int>(type: "int", nullable: true),
                    RequestExerciseId = table.Column<int>(type: "int", nullable: true),
                    RequestLessonId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LessonMaterials", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LessonMaterials_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LessonMaterials_Lessons_LessonId",
                        column: x => x.LessonId,
                        principalTable: "Lessons",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_LessonMaterials_RequestsExercises_RequestExerciseId",
                        column: x => x.RequestExerciseId,
                        principalTable: "RequestsExercises",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_LessonMaterials_RequestsLessons_RequestLessonId",
                        column: x => x.RequestLessonId,
                        principalTable: "RequestsLessons",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0f761db2-ab55-416c-83b9-70abded3d908", "aae86fdc-ee7e-42fd-8150-c3a3688f517b", "Administrator", "ADMINISTRATOR" },
                    { "71281cf3-9730-4d7e-acbb-213edee8291c", "7b72c31c-b513-44bd-8246-97ac76b2195c", "Teacher", "TEACHER" },
                    { "e66d730b-bcf1-41b5-b7e0-3e66056e61d9", "994f81f3-a799-40dd-9142-78997e78d6ba", "Student", "STUDENT" },
                    { "fe750b82-6fe9-472c-bdc5-61f5433d429e", "77fb8c85-a4d3-4535-b0ec-49920bdfad73", "MonUser", "MONUSER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AboutMe", "AccessFailedCount", "City", "ConcurrencyStamp", "ConnectionId", "Email", "EmailConfirmed", "FirstName", "IsActive", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePictureUrl", "RoleName", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "023bafc9-8b7e-4fbd-bb06-2b178fe8ae8b", "Занимавам се с програмиране от 3 години. Интересувам се от кибер сигурност, а именно и това искам да уча след като завърша.", 0, "Миделбург", "60569be1-12bc-4ffb-84e7-46f8ce11e1de", null, "student@gmail.com", false, "Никол", true, "Груева", false, null, "STUDENT@GMAIL.COM", "STUDENT@GMAIL.COM", "AQAAAAEAACcQAAAAEK27Oez3JyMDLagNuENXiHWVsixWGye5pcbpyioDtfxpWMjkan4gt3y6kZ7U8CAt0w==", "0886121262", false, "https://res.cloudinary.com/dmv8nabul/image/upload/v1707334404/nikol_prlrcl.jpg", "Student", "3ba63e7b-11b9-4253-8655-42788afa7d57", false, "student@gmail.com" },
                    { "789061a9-edaa-4a00-9e09-add6a20c8288", "Разработвам това приложение, за да участвам в олимпиада по информационни технологии. Темата си избрах след първата матура по Информатика. Моите учители и приятели, които се явиха на това ДЗИ, имаха проблем с намирането на полезни материали и информация за самата матура. Това приложение се надявам, че би олеснило подготовката, защото хора с еднакви интереси и задачи могат да комуникират и обменят знания. Също така, учители могат да предадат знанията си на ученици, които наистина имат желание да се научат и полагат усилия.", 0, "Казанлък", "d954de93-c03c-4fcc-8f81-379cf05b6c3c", null, "admin@gmail.com", false, "Креса", true, "Цветкова", false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEK2cINaea2HJrYIR0sTztfXpjQCwQKiaWd0YaiLFkSfyht51gisKhEEBXjIJtb3U9g==", "0886121260", false, "https://res.cloudinary.com/dmv8nabul/image/upload/v1707334401/kresa_bkbaoa.jpg", "Administrator", "e67fea8b-2b9a-4041-9463-bc75767cb1b6", false, "admin@gmail.com" },
                    { "7decfb7d-d2df-40a2-a449-dcec04eb091a", "Работя в МОН от 5 години. Преподавам по Информатика в частна школа. Програмирането е моята страст. Обичам фо повече от приятелката ми.", 0, "Кърджали", "8e3fa194-bc36-4f21-b724-6331739a0392", null, "monuser@gmail.com", false, "Валентин", true, "Терзиев", false, null, "MONUSER@GMAIL.COM", "MONUSER@GMAIL.COM", "AQAAAAEAACcQAAAAEJBqXdhDXTukMsuP2bnyoPBQOeF6DnTUklS46zc5ntcW/O5gHX1sCFyBr4qLcbzxLw==", "0886121261", false, "https://res.cloudinary.com/dmv8nabul/image/upload/v1707334408/valentin_u5en92.jpg", "MonUser", "9f594f9d-6a98-4a5e-b739-1dcd04037cef", false, "monuser@gmail.com" },
                    { "9c7f55cd-f0ae-405e-b520-6e1ccc448fcc", "Учителка съм от 12 години. Избрах тази професия, защото работата с деца е моята страст. В работата си опитвам да предам знанията си колкото повече мога. Мой интерес е работата с ASP.NET.", 0, "София", "aea43480-1026-42e0-8837-a775206472f5", null, "teacher@gmail.com", false, "Ивета", true, "Найденова", false, null, "TEACHER@GMAIL.COM", "TEACHER@GMAIL.COM", "AQAAAAEAACcQAAAAEOxL7fzHelH+LY8EUIbl08woX75BPpdnmbtd5QYNYY/1cXlpmpYiF8GvEPeoyLeBBQ==", "0886121262", false, "https://res.cloudinary.com/dmv8nabul/image/upload/v1707334395/iveta_rknyn3.jpg", "Teacher", "9456dd4a-f34d-4554-baaf-b2673cde96fb", false, "teacher@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "ModuleOfCurricular",
                columns: new[] { "Id", "IsActive", "Title" },
                values: new object[,]
                {
                    { 1, true, "Обектно-ориентирано проектиране и програмиране" },
                    { 2, true, "Структури от данни и алгоритми" },
                    { 3, true, "Релационен модел на бази от данни" },
                    { 4, true, "Програмиране на информационни системи" }
                });

            migrationBuilder.InsertData(
                table: "Schools",
                columns: new[] { "Id", "City", "IsActive", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { 1, "София", true, "Профилираната гимназия за изобразителни изкуства \"Професор Николай Райнов\"", "профилираната гимназия за изобразителни изкуства \"професор николай райнов\"" },
                    { 2, "София", true, "Трето Средно Общообразователно Училище \"Марин Дринов\"", "трето средно общообразователно училище \"марин дринов\"" },
                    { 3, "София", true, "118 Средно Общообразователно Училище \"Академик Людмил Стоянов\"", "118 средно общообразователно училище \"академик людмил стоянов\"" },
                    { 4, "София", true, "192 СОУ \"Христо Ботев\"", "192 соу \"христо ботев\"" },
                    { 5, "София", true, "81 Средно Общообразователно Училище \"Виктор Юго\"", "81 средно общообразователно училище \"виктор юго\"" },
                    { 6, "София", true, "Англо-американско училище в София", "англо-американско училище в софия" },
                    { 7, "София", true, "Руски лицей \"Архиепископ Серафим\"", "руски лицей \"архиепископ серафим\"" },
                    { 8, "София", true, "Средно Художествено Училище За Приложни Изкуства \"Свети Лука\"", "средно художествено училище за приложни изкуства \"свети лука\"" },
                    { 9, "София", true, "Частен Английска Гимназия \"Евростандарт\"", "частен английска гимназия \"евростандарт\"" },
                    { 10, "София", true, "Технологично Училище Електронни Системи към Технически Университет - София", "технологично училище електронни системи към технически университет - софия" },
                    { 11, "София", true, "Национална Гимназия За Древни Езици и Култури \"Константин Кирил Философ\"", "национална гимназия за древни езици и култури \"константин кирил философ\"" },
                    { 12, "София", true, "Първа Английска Езикова Гимназия", "първа английска езикова гимназия" },
                    { 13, "София", true, "Частна Професионална Гимназия по Икономика, Туризъм и Информатика \"Булпрогрес\"", "частна професионална гимназия по икономика, туризъм и информатика \"булпрогрес\"" },
                    { 14, "София", true, "78 Средно Общообразователно Училище \"Христо Смирненски\"", "78 средно общообразователно училище \"христо смирненски\"" },
                    { 15, "София", true, "Частно Средно Общообразователно Училище \"Евроучилище Ровел\"", "частно средно общообразователно училище \"евроучилище ровел\"" },
                    { 16, "София", true, "Частна Профилирана Гимназия \"Дружба\"", "частна профилирана гимназия \"дружба\"" },
                    { 17, "София", true, "26 Средно Общообразователно Училище \"Йордан Йовков\"", "26 средно общообразователно училище \"йордан йовков\"" },
                    { 18, "София", true, "Частно Профилирано Средно Общообразователно Училище \"Свети Наум\"", "частно профилирано средно общообразователно училище \"свети наум\"" },
                    { 19, "София", true, "Частно Средно Общообразователно Училище \"Рьорих\"", "частно средно общообразователно училище \"рьорих\"" },
                    { 20, "София", true, "Частно Средно Общообразователно Училище \"Дрита\"", "частно средно общообразователно училище \"дрита\"" },
                    { 21, "София", true, "Средно Специално Училище За Деца с Увреден Слух \"Проф. Д-Р Дечо Денев\"", "средно специално училище за деца с увреден слух \"проф. д-р дечо денев\"" },
                    { 22, "София", true, "74 Средно Общообразователно Училище \"Гоце Делчев\"", "74 средно общообразователно училище \"гоце делчев\"" },
                    { 23, "София", true, "13 Средно Общообразователно Училище \"Св.Св.Кирил и Методий\"", "13 средно общообразователно училище \"св.св.кирил и методий\"" },
                    { 24, "София", true, "30 Средно Общообразователно Училище \"Братя Миладинови\"", "30 средно общообразователно училище \"братя миладинови\"" },
                    { 25, "София", true, "32 СОУ с Изучаване на Чужди Езици \"Свети Климент Охридски\"", "32 соу с изучаване на чужди езици \"свети климент охридски\"" },
                    { 26, "София", true, "134 Средно Общообразователно Училище \"Димчо Дебелянов\"", "134 средно общообразователно училище \"димчо дебелянов\"" },
                    { 27, "София", true, "Национална Професионална Гимназия по Прецизна Техника и Оптика \"М.В.Ломоносов\"", "национална професионална гимназия по прецизна техника и оптика \"м.в.ломоносов\"" },
                    { 28, "София", true, "Професионална Гимназия по Подемна, Строителна и Транспортна Техника", "професионална гимназия по подемна, строителна и транспортна техника" },
                    { 29, "София", true, "Частна Профилирана Гимназия \"Езиков Свят\"", "частна профилирана гимназия \"езиков свят\"" },
                    { 30, "София", true, "105 Средно Общообразователно Училище \"Атанас Далчев\"", "105 средно общообразователно училище \"атанас далчев\"" }
                });

            migrationBuilder.InsertData(
                table: "Schools",
                columns: new[] { "Id", "City", "IsActive", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { 31, "София", true, "119 Средно Общообазователно Училище \"Академик Михаил Арнаудов\"", "119 средно общообазователно училище \"академик михаил арнаудов\"" },
                    { 32, "София", true, "Софийска Професионална Гимназия по Електроника \"Джон Атанасов\"", "софийска професионална гимназия по електроника \"джон атанасов\"" },
                    { 33, "София", true, "Частна Езикова Гимназия \"Проф. Иван Апостолов\"", "частна езикова гимназия \"проф. иван апостолов\"" },
                    { 34, "София", true, "Частна Професионална Гимназия по Мениджмънт и Бизнес Администрация \"Хелиос 2000\"", "частна професионална гимназия по мениджмънт и бизнес администрация \"хелиос 2000\"" },
                    { 35, "София", true, "113 Средно Общообразователно Училище \"Сава Филаретов\"", "113 средно общообразователно училище \"сава филаретов\"" },
                    { 36, "София", true, "Втора Английска Езикова Гимназия \"Томас Джеферсън\"", "втора английска езикова гимназия \"томас джеферсън\"" },
                    { 37, "София", true, "Професионална Гимназия по Транспорт и Енергетика \"Хенри Форд\"", "професионална гимназия по транспорт и енергетика \"хенри форд\"" },
                    { 38, "София", true, "Професионална Гимназия \"А. С. Попов\"", "професионална гимназия \"а. с. попов\"" },
                    { 39, "София", true, "138 Средно Общообразователно Училище \"Никола Беловеждов\"", "138 средно общообразователно училище \"никола беловеждов\"" },
                    { 40, "София", true, "Професионална Гимназия по Транспорт", "професионална гимназия по транспорт" },
                    { 41, "София", true, "Софийска Гимназия по Хлебни и Сладкарски Технологии", "софийска гимназия по хлебни и сладкарски технологии" },
                    { 42, "София", true, "Частна Професионална Гимназия \"Братя Вълчеви\"", "частна професионална гимназия \"братя вълчеви\"" },
                    { 43, "София", true, "19 Средно Общобразователно Училище \"Елин Пелин\"", "19 средно общобразователно училище \"елин пелин\"" },
                    { 44, "София", true, "51-во Средно Общообразователно Училище \"Елисавета Багряна\"", "51-во средно общообразователно училище \"елисавета багряна\"" },
                    { 45, "София", true, "132-ро Средно Общообразователно Училище \"Ваня Войнова\"", "132-ро средно общообразователно училище \"ваня войнова\"" },
                    { 46, "София", true, "Частно Езиково Средно Общообразователно Училище \"Дорис Тенеди\"", "частно езиково средно общообразователно училище \"дорис тенеди\"" },
                    { 47, "София", true, "Частна Математическа Гимназия \"Евклид\"", "частна математическа гимназия \"евклид\"" },
                    { 48, "София", true, "85 Средно Общообразователно Училище \"Отец Паисий\"", "85 средно общообразователно училище \"отец паисий\"" },
                    { 49, "София", true, "21-во Средно Общообразователно Училище \"Христо Ботев\"", "21-во средно общообразователно училище \"христо ботев\"" },
                    { 50, "София", true, "35 Средно Общообразователно Училище \"Добри Войников\"", "35 средно общообразователно училище \"добри войников\"" },
                    { 51, "София", true, "Национална Природо-Математическа Гимназия \"Акад. Л. Чакалов\"", "национална природо-математическа гимназия \"акад. л. чакалов\"" },
                    { 52, "София", true, "Професионална Гимназия по Облекло \"Княгиня Мария Луиза\"", "професионална гимназия по облекло \"княгиня мария луиза\"" },
                    { 53, "София", true, "Софийска Гимназия по Строителство, Архитектура и Геодезия \"Христо Ботев\"", "софийска гимназия по строителство, архитектура и геодезия \"христо ботев\"" },
                    { 54, "София", true, "Национална Финансово - Стопанска Гимназия", "национална финансово - стопанска гимназия" },
                    { 55, "София", true, "Частна Професионална Гимназия \"Банкер\"", "частна професионална гимназия \"банкер\"" },
                    { 56, "София", true, "Софийска Духовна Семинария \"Св. Иван Рилски\"", "софийска духовна семинария \"св. иван рилски\"" },
                    { 57, "София", true, "Частно училище за танцово изкуство \"Галина Сергеевна Уланова\"", "частно училище за танцово изкуство \"галина сергеевна уланова\"" },
                    { 58, "София", true, "40 Средно Общообразователно Училище \"Луи Пастьор\"", "40 средно общообразователно училище \"луи пастьор\"" },
                    { 59, "София", true, "56-то Средно Общообразователно Училище \"Проф. Константин Иречек\"", "56-то средно общообразователно училище \"проф. константин иречек\"" },
                    { 60, "София", true, "79 Средно Общообразователно Училище \"Индира Ганди\"", "79 средно общообразователно училище \"индира ганди\"" },
                    { 61, "София", true, "90 Средно Общообразователно Училище \"Генерал Хосе Де Сан Мартин\"", "90 средно общообразователно училище \"генерал хосе де сан мартин\"" },
                    { 62, "София", true, "96 СОУ с изучаване на чужди езици \"Лев Николаевич Толстой\"", "96 соу с изучаване на чужди езици \"лев николаевич толстой\"" },
                    { 63, "София", true, "97 Средно Общообразователно Училище \"Братя Миладинови\"", "97 средно общообразователно училище \"братя миладинови\"" },
                    { 64, "София", true, "137 Средно Общообразователно Училище \"Ангел Кънчев\"", "137 средно общообразователно училище \"ангел кънчев\"" },
                    { 65, "София", true, "Немска Гимназия \"Ерих Кестнер\"", "немска гимназия \"ерих кестнер\"" },
                    { 66, "София", true, "Частно Средно Училище \"Петко Рачов Славейков\"", "частно средно училище \"петко рачов славейков\"" },
                    { 67, "София", true, "39 Средно Общообразователно Училище \"Петър Динеков\"", "39 средно общообразователно училище \"петър динеков\"" },
                    { 68, "София", true, "128 Средно Общообразователно Училище \"Алберт Айнщайн\"", "128 средно общообразователно училище \"алберт айнщайн\"" },
                    { 69, "София", true, "131 СОУ \"Климент Аркадиевич Тимирязев\"", "131 соу \"климент аркадиевич тимирязев\"" },
                    { 70, "София", true, "144 Средно Общообразователно Училище \"Народни Будители\"", "144 средно общообразователно училище \"народни будители\"" },
                    { 71, "София", true, "145 Средно Общообразователно Училище \"Симеон Радев\"", "145 средно общообразователно училище \"симеон радев\"" },
                    { 72, "София", true, "Спортно Училище \"Ген. Владимир Стойчев\"", "спортно училище \"ген. владимир стойчев\"" }
                });

            migrationBuilder.InsertData(
                table: "Schools",
                columns: new[] { "Id", "City", "IsActive", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { 73, "София", true, "Частна Профилирана Гимназия с Чуждоезиково Обучение \"Меридиан 22\"", "частна профилирана гимназия с чуждоезиково обучение \"меридиан 22\"" },
                    { 74, "София", true, "Частно Средно Общообразователно Училище с Ранно Чуждоезиково Обучение Еспа", "частно средно общообразователно училище с ранно чуждоезиково обучение еспа" },
                    { 75, "София", true, "Професионална Гимназия \"Интербизнес\"", "професионална гимназия \"интербизнес\"" },
                    { 76, "София", true, "101 Средно Общообразователно Училище \"Бачо Киро\"", "101 средно общообразователно училище \"бачо киро\"" },
                    { 77, "София", true, "153-та Профилирана Гимназия \"Неофит Рилски\"", "153-та профилирана гимназия \"неофит рилски\"" },
                    { 78, "София", true, "Частна Професионална Гимназия по Туризъм \"Свети Мина\"", "частна професионална гимназия по туризъм \"свети мина\"" },
                    { 79, "София", true, "170 Средно Общообразователно Училище \"Васил Левски\" кв.Курило", "170 средно общообразователно училище \"васил левски\" кв.курило" },
                    { 80, "София", true, "Първо Средно Общообразователно Училище \"Пенчо П. Славейков\"", "първо средно общообразователно училище \"пенчо п. славейков\"" },
                    { 81, "София", true, "164та Гимназия с преподаване на Испански език \"Мигел Де Сервантес\"", "164та гимназия с преподаване на испански език \"мигел де сервантес\"" },
                    { 82, "София", true, "Софийска Математическа Гимназия \"Паисий Хилендарски\"", "софийска математическа гимназия \"паисий хилендарски\"" },
                    { 83, "София", true, "Професионална Гимназия по Механоелектротехника \"Н.Й.Вапцаров\"", "професионална гимназия по механоелектротехника \"н.й.вапцаров\"" },
                    { 84, "София", true, "Софийска Професионална Гимназия по Туризъм", "софийска професионална гимназия по туризъм" },
                    { 85, "София", true, "Частно Средно Общообразователно Училище \"Увекинд\"", "частно средно общообразователно училище \"увекинд\"" },
                    { 86, "София", true, "Първа Частна Английска Гимназия \"Уилям Шекспир\"", "първа частна английска гимназия \"уилям шекспир\"" },
                    { 87, "София", true, "66-то СОУ \"Филип Станиславов\"", "66-то соу \"филип станиславов\"" },
                    { 88, "София", true, "88 Средно Общообразователно Училище \"Димитър Попниколов\"", "88 средно общообразователно училище \"димитър попниколов\"" },
                    { 89, "София", true, "Национално Средно Общообразователно Училище \"София\"", "национално средно общообразователно училище \"софия\"" },
                    { 90, "София", true, "Частна Профилирана Езикова Гимназия \"Д-Р Мария Монтесори\"", "частна профилирана езикова гимназия \"д-р мария монтесори\"" },
                    { 91, "София", true, "Частно Средно Общообразователно Училище \"Евростар\"", "частно средно общообразователно училище \"евростар\"" },
                    { 92, "София", true, "95 СОУ \"Проф. Иван Шишманов\"", "95 соу \"проф. иван шишманов\"" },
                    { 93, "София", true, "130 Средно Общообразователно Училище \"Стефан Караджа\"", "130 средно общообразователно училище \"стефан караджа\"" },
                    { 94, "София", true, "166 Спортно Училище \"Васил Левски\"", "166 спортно училище \"васил левски\"" },
                    { 95, "София", true, "14 Средно Общообразователно Училище \"Проф. Д-Р Асен Златаров\"", "14 средно общообразователно училище \"проф. д-р асен златаров\"" },
                    { 96, "София", true, "29 Средно Общообразователно Училище \"Кузман Шапкарев\"", "29 средно общообразователно училище \"кузман шапкарев\"" },
                    { 97, "София", true, "Професионална Гимназия по Железопътен Транспорт \"Никола Корчев\"", "професионална гимназия по железопътен транспорт \"никола корчев\"" },
                    { 98, "София", true, "ПГ по Вътрешна Архитектура и Дървообработване", "пг по вътрешна архитектура и дървообработване" },
                    { 99, "София", true, "23 Средно Общообразователно Училище \"Фредерик Жолио-Кюри\"", "23 средно общообразователно училище \"фредерик жолио-кюри\"" },
                    { 100, "София", true, "31 Средно Училище за Чужди Езици и Мениджмънт \"Иван Вазов\"", " 31 средно училище за чужди езици и мениджмънт \"иван вазов\"" },
                    { 101, "София", true, "138 СОУ \"Проф. Васил Златарски\"", "138 соу \"проф. васил златарски\"" },
                    { 102, "София", true, "157 Гимназия с изучаване на чужд език \"Сесар Вайехо\"", "157 гимназия с изучаване на чужд език \"сесар вайехо\"" },
                    { 103, "София", true, "Първа Частна Математическа Гимназия", "първа частна математическа гимназия" },
                    { 104, "София", true, "Частна Профилирана Гимназия с Изучаване на Чужди Езици \"Св. Св. Кирил и Методий\"", "частна профилирана гимназия с изучаване на чужди езици \"св. св. кирил и методий\"" },
                    { 105, "София", true, "Частна Профилирана Гимназия \"Образователни Технологии\"", "частна профилирана гимназия \"образователни технологии\"" },
                    { 106, "София", true, "Седмо Средно Общообразователно Училище \"Свети Седмочисленици\"", "седмо средно общообразователно училище \"свети седмочисленици\"" },
                    { 107, "София", true, "9-та Френска Езикова Гимназия \"Алфонс Дьо Ламартин\"", "9-та френска езикова гимназия \"алфонс дьо ламартин\"" },
                    { 108, "София", true, "12 Средно Общообразователно Училище \"Цар Иван Асен II\"", "12 средно общообразователно училище \"цар иван асен ii\"" },
                    { 109, "София", true, "8 Средно Общообразователно Училище \"Васил Левски\"", "8 средно общообразователно училище \"васил левски\"" },
                    { 110, "София", true, "55 Средно Общообразователно Училище \"Петко Каравелов\"", "55 средно общообразователно училище \"петко каравелов\"" },
                    { 111, "София", true, "Професионална Гимназия по Телекомуникации", "професионална гимназия по телекомуникации" },
                    { 112, "София", true, "Частна Гимназия с Езиков и Хуманитарен Профил \"Проф.Д-Р В. Златарски\"", "частна гимназия с езиков и хуманитарен профил \"проф.д-р в. златарски\"" },
                    { 113, "София", true, "Частна Професионална Гимназия по Мултимедия, Компютърен Графичен Дизайн и Анимация", "частна професионална гимназия по мултимедия, компютърен графичен дизайн и анимация" },
                    { 114, "София", true, "22 Средно Общообразователно Училище \"Георги Стойков Раковски\"", "22 средно общообразователно училище \"георги стойков раковски\"" }
                });

            migrationBuilder.InsertData(
                table: "Schools",
                columns: new[] { "Id", "City", "IsActive", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { 115, "София", true, "121 Средно Общообразователно Училище \"Георги Измирлиев\"", "121 средно общообразователно училище \"георги измирлиев\"" },
                    { 116, "София", true, "Професионална Гимназия по Текстил и Моден Дизайн", "професионална гимназия по текстил и моден дизайн" },
                    { 117, "София", true, "Частно Соу по Изкуства и Чужди Езици \"Артис\"", "частно соу по изкуства и чужди езици \"артис\"" },
                    { 118, "София", true, "Частно Средно Общообразувателно Училище \"Авицена\"", "частно средно общообразувателно училище \"авицена\"" },
                    { 119, "София", true, "18 Средно Общообразователно Училище \"Уилям Гладстон\"", "18 средно общообразователно училище \"уилям гладстон\"" },
                    { 120, "София", true, "Професионална Гимназия по Туризъм \"Алеко Константинов\"", "професионална гимназия по туризъм \"алеко константинов\"" },
                    { 121, "София", true, "2 Средно Общообразователно Училище \"Академик Емилиян Станев\"", "2 средно общообразователно училище \"академик емилиян станев\"" },
                    { 122, "София", true, "Професионална Гимназия по Екология и Биотехнологии \"Проф. Д-Р Асен Златаров\"", "професионална гимназия по екология и биотехнологии \"проф. д-р асен златаров\"" },
                    { 123, "София", true, "Частно Средно Общообразователно Училище \"Св. Георги\"", "частно средно общообразователно училище \"св. георги\"" },
                    { 124, "София", true, "140 Среднообщообразователно Училище \"Иван Богоров\"", "140 среднообщообразователно училище \"иван богоров\"" },
                    { 125, "София", true, "91 Гимназия с Преподаване на Немски Език \"Проф. Константин Гълъбов\"", "91 гимназия с преподаване на немски език \"проф. константин гълъбов\"" },
                    { 126, "София", true, "Вечерно Средно Общообразователно Училище \"Пеньо Пенев\"", "вечерно средно общообразователно училище \"пеньо пенев\"" },
                    { 127, "София", true, "Профилирана Гимназия с Интензивно Изучаване на Румънски Език", "профилирана гимназия с интензивно изучаване на румънски език" },
                    { 128, "София", true, "Професионална Гимназия по Текстилни и Кожени Изделия", "професионална гимназия по текстилни и кожени изделия" },
                    { 129, "София", true, "Софийска Техническа Гимназия", "софийска техническа гимназия" },
                    { 130, "София", true, "Професионална Гимназия по Строителство и Енергетика", "професионална гимназия по строителство и енергетика" },
                    { 131, "София", true, "Частна Профилирана Гимназия \"Веда\"", "частна профилирана гимназия \"веда\"" },
                    { 132, "София", true, "Професионална Гимназия по Фризьорство и Козметика \"Княгиня Евдокия\"", "професионална гимназия по фризьорство и козметика \"княгиня евдокия\"" },
                    { 133, "София", true, "Професионална Гимназия по Хранително Вкусови Технологии \"Проф.Д-Р Г. Павлов\"", "професионална гимназия по хранително вкусови технологии \"проф.д-р г. павлов\"" },
                    { 134, "София", true, "68 Средно Общообразователно Училище \"Академик Никола Обрешков\"", "68 средно общообразователно училище \"академик никола обрешков\"" },
                    { 135, "София", true, "69 Средно Общообразователно Училище \"Димитър Маринов\"", "69 средно общообразователно училище \"димитър маринов\"" },
                    { 136, "София", true, "17 Соу \"Дамян Груев\" с Ранно Обучение по Френски Език", "17 соу \"дамян груев\" с ранно обучение по френски език" },
                    { 137, "София", true, "28 Средно Общообразователно Училище \"Алеко Константинов\"", "28 средно общообразователно училище \"алеко константинов\"" },
                    { 138, "София", true, "57-мо Спортно Училище \"Свети Наум Охридски\"", "57-мо спортно училище \"свети наум охридски\"" },
                    { 139, "София", true, "123 Средно Общообразователно Училище \"Стефан Стамболов\"", "123 средно общообразователно училище \"стефан стамболов\"" },
                    { 140, "София", true, "135 Средно Общообразователно Училище \"Ян Амос Коменски\"", "135 средно общообразователно училище \"ян амос коменски\"" },
                    { 141, "София", true, "Професионална Гимназия по Битова и Електротранспортна Техника", "професионална гимназия по битова и електротранспортна техника" },
                    { 142, "София", true, "Частно Средно Общообразователно Училище \"Орфей\"", "частно средно общообразователно училище \"орфей\"" },
                    { 143, "София", true, "36 Средно Общообразователно Училище \"Максим Горки\"", "36 средно общообразователно училище \"максим горки\"" },
                    { 144, "София", true, "Профилирана Гимназия с Изучаване на Чужди Езици \"Свети Методий\"", "профилирана гимназия с изучаване на чужди езици \"свети методий\"" },
                    { 145, "София", true, "117 Средно Общообразователно Училище \"Св.Св.Кирил и Методий\" (Град Бухово)", "117 средно общообразователно училище \"св.св.кирил и методий\" (град бухово)" },
                    { 146, "София", true, "Професионална Гимназия по Металургия \"Акад. Ив. П. Бардин\"", "професионална гимназия по металургия \"акад. ив. п. бардин\"" },
                    { 147, "София", true, "Първа Частна Професионална Гимназия по Охрана и Сигурност \"Св.Георги Победоносец\"", "първа частна професионална гимназия по охрана и сигурност \"св.георги победоносец\"" },
                    { 148, "София", true, "27 Средно Общообразователно Училище \"Акад. Г. Караславов\"", "27 средно общообразователно училище \"акад. г. караславов\"" },
                    { 149, "София", true, "37 Средно Общообразователно Училище \"Райна Княгиня\"", "37 средно общообразователно училище \"райна княгиня\"" },
                    { 150, "София", true, "33 Езикова Гимназия \"Света София\"", "33 езикова гимназия \"света софия\"" },
                    { 151, "София", true, "10 Средно Общообразователно Училище \"Теодор Траянов\"", "10 средно общообразователно училище \"теодор траянов\"" },
                    { 152, "София", true, "15 Средно Общообразователно Училище \"Адам Мицкевич\"", "15 средно общообразователно училище \"адам мицкевич\"" },
                    { 153, "София", true, "54 Средно Общообразователно Училище \"Св.Иван Рилски\"", "54 средно общообразователно училище \"св.иван рилски\"" },
                    { 154, "София", true, "Професионална Гимназия по Химични и Микробиологични Технологии \"Професор Пенчо Райков\"", "професионална гимназия по химични и микробиологични технологии \"професор пенчо райков\"" },
                    { 155, "София", true, "149 Средно Общообразователно Училище \"Иван Хаджийски\"", "149 средно общообразователно училище \"иван хаджийски\"" },
                    { 156, "София", true, "Професионална Гимназия по Електротехника и Автоматика", "професионална гимназия по електротехника и автоматика" }
                });

            migrationBuilder.InsertData(
                table: "Schools",
                columns: new[] { "Id", "City", "IsActive", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { 157, "София", true, "Професионална Гимназия по Селско Стопанство \"Бузема\"", "професионална гимназия по селско стопанство \"бузема\"" },
                    { 158, "София", true, "71 Средно Общообразователно Училище \"Пейо Яворов\"", "71 средно общообразователно училище \"пейо яворов\"" },
                    { 159, "София", true, "24 Средно Общообразователно Училище \"П. К. Яворов\"", "24 средно общообразователно училище \"п. к. яворов\"" },
                    { 160, "София", true, "44 Средно Общообразователно Училище \"Неофит Бозвели\"", "44 средно общообразователно училище \"неофит бозвели\"" },
                    { 161, "София", true, "Професионална Гимназия по Топлинна и Хладилна Техника \"Карл Фон Линде\"", "професионална гимназия по топлинна и хладилна техника \"карл фон линде\"" },
                    { 162, "София", true, "93-То Средно Общообразователно Училище \"Александър Теодоров - Балан\"", "93-то средно общообразователно училище \"александър теодоров - балан\"" },
                    { 163, "София", true, "94-То Средно Общообразователно Училище \"Димитър Страшимиров\"", "94-то средно общообразователно училище \"димитър страшимиров\"" },
                    { 164, "София", true, "Професионална Гимназия по Транспорт \"Макгахан\"", "професионална гимназия по транспорт \"макгахан\"" },
                    { 165, "София", true, "127 Средно Общообразователно Училище \"Иван Николаевич Денкоглу\"", "127 средно общообразователно училище \"иван николаевич денкоглу\"" },
                    { 166, "София", true, "133 Средно Общообразователно Училище \"А. С. Пушкин\"", "133 средно общообразователно училище \"а. с. пушкин\"" },
                    { 167, "София", true, "47 Соу \"Христо Г. Данов\"", "47 соу \"христо г. данов\"" },
                    { 168, "София", true, "73 СОУ с Преподаване на Чужди Езици \"Владислав Граматик\"", "73 соу с преподаване на чужди езици \"владислав граматик\"" },
                    { 169, "София", true, "Национална Търговско - Банкова Гимназия", "национална търговско - банкова гимназия" },
                    { 170, "София", true, "Частна Професионална Гимназия по Банково Дело, Търговия и Финанси", "частна професионална гимназия по банково дело, търговия и финанси" },
                    { 171, "София", true, "Частна професионална гимназия по мениджмънт в спорта и в туризма \"Свети Йоан Кръстител и Света Анна\"", "частна професионална гимназия по мениджмънт в спорта и в туризма \"свети йоан кръстител и света анна\"" },
                    { 172, "София", true, "Частна Профилирана Гимназия \"Пейо К. Яворов\"", "частна профилирана гимназия \"пейо к. яворов\"" },
                    { 173, "София", true, "Частна Профилирана Гимназия Балканика", "частна профилирана гимназия балканика" },
                    { 174, "София", true, "Частна Профилирана Гимназия с Изучаване на Английски Език \"Софийска Езикова Гимназия\"", "частна профилирана гимназия с изучаване на английски език \"софийска езикова гимназия\"" },
                    { 175, "Пловдив", true, "Средно Общообразователно Училище \"Свети Свети Кирил и Методий\"", "средно общообразователно училище \"свети свети кирил и методий\"" },
                    { 176, "Пловдив", true, "Средно Общообразователно Училище \"Любен Каравелов\"", "средно общообразователно училище \"любен каравелов\"" },
                    { 177, "Пловдив", true, "Професионална Гимназия по Облекло \"Ана Май\"", "професионална гимназия по облекло \"ана май\"" },
                    { 178, "Пловдив", true, "Професионална Гимназия по Машиностроене Пловдив", "професионална гимназия по машиностроене пловдив" },
                    { 179, "Пловдив", true, "Професионална Гимназия по Кожени Изделия и Текстил \"Д-Р Иван Богоров\"", "професионална гимназия по кожени изделия и текстил \"д-р иван богоров\"" },
                    { 180, "Пловдив", true, "Езикова Гимназия \"Иван Вазов\"", "езикова гимназия \"иван вазов\"" },
                    { 181, "Пловдив", true, "Професионална Гимназия по Вътрешна Архитектура и Дървообработване \"Христо Ботев\"", "професионална гимназия по вътрешна архитектура и дървообработване \"христо ботев\"" },
                    { 182, "Пловдив", true, "Средно Общообразователно Училище \"Свети Константин - Кирил Философ\"", "средно общообразователно училище \"свети константин - кирил философ\"" },
                    { 183, "Пловдив", true, "Национална Търговска Гимназия", "национална търговска гимназия" },
                    { 184, "Пловдив", true, "Професионална Гимназия По битова Техника", "професионална гимназия по битова техника" },
                    { 185, "Пловдив", true, "Средно Общообразователно Училище \"Димитър Матевски\"", "средно общообразователно училище \"димитър матевски\"" },
                    { 186, "Пловдив", true, "Средно Общообразователно Училище \"Свети Софроний Врачански\"", "средно общообразователно училище \"свети софроний врачански\"" },
                    { 187, "Пловдив", true, "Частна Профилирана Гимназия \"Академик Любомир Илиев\"", "частна профилирана гимназия \"академик любомир илиев\"" },
                    { 188, "Пловдив", true, "Национална Гимназия За Сценични и Екранни Изкуства", "национална гимназия за сценични и екранни изкуства" },
                    { 189, "Пловдив", true, "Гимназия с Хуманитарен Профил \"Св. Св. Кирил и Методий\"", "гимназия с хуманитарен профил \"св. св. кирил и методий\"" },
                    { 190, "Пловдив", true, "Средно Общообразователно Училище \"Св.Паисий Хилендарски\"", "средно общообразователно училище \"св.паисий хилендарски\"" },
                    { 191, "Пловдив", true, "Средно Общообразователно Училище \"Свети Климент Охридски\"", "средно общообразователно училище \"свети климент охридски\"" },
                    { 192, "Пловдив", true, "Средно Общообразователно Училище \"Свети Патриарх Евтимий\"", "средно общообразователно училище \"свети патриарх евтимий\"" },
                    { 193, "Пловдив", true, "Професионална Гимназия по Електротехника и Електроника", "професионална гимназия по електротехника и електроника" },
                    { 194, "Пловдив", true, "Професионална Гимназия по Туризъм \"Проф. Д-Р Асен Златаров\"", "професионална гимназия по туризъм \"проф. д-р асен златаров\"" },
                    { 195, "Пловдив", true, "Средно Общообразователно Училище \"Найден Геров\"", "средно общообразователно училище \"найден геров\"" },
                    { 196, "Пловдив", true, "Професионална Гимназия по Транспорт \"Гоце Делчев\"", "професионална гимназия по транспорт \"гоце делчев\"" },
                    { 197, "Пловдив", true, "Професионална Гимназия по Строителни Технологии \"Пеньо Пенев\"", "професионална гимназия по строителни технологии \"пеньо пенев\"" },
                    { 198, "Пловдив", true, "Образцова Математическа Гимназия \"Академик Кирил Попов\"", "образцова математическа гимназия \"академик кирил попов\"" }
                });

            migrationBuilder.InsertData(
                table: "Schools",
                columns: new[] { "Id", "City", "IsActive", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { 199, "Пловдив", true, "Средно Общообразователно Училище \"Никола Йонков Вапцаров\"", "средно общообразователно училище \"никола йонков вапцаров\"" },
                    { 200, "Пловдив", true, "Средно Общообразователноучилище \"Пейо Крачолов Яворов\"", "средно общообразователноучилище \"пейо крачолов яворов\"" },
                    { 201, "Пловдив", true, "Френска Езикова Гимназия \"Антоан Дьо Сент Екзюпери\"", "френска езикова гимназия \"антоан дьо сент екзюпери\"" },
                    { 202, "Пловдив", true, "Вечерна Гимназия \"Христо Смирненски\"", "вечерна гимназия \"христо смирненски\"" },
                    { 203, "Пловдив", true, "Професионална Гимназия по Хранителни Технологии и Техника", "професионална гимназия по хранителни технологии и техника" },
                    { 204, "Пловдив", true, "Професионална Гимназия по Механотехника \"Професор Цветан Лазаров\"", "професионална гимназия по механотехника \"професор цветан лазаров\"" },
                    { 205, "Пловдив", true, "Средно Общообразователно Училище \"Свети Седмочисленици\"", "средно общообразователно училище \"свети седмочисленици\"" },
                    { 206, "Пловдив", true, "Частно Средно общообразователно Училище \"Дружба\"", "частно средно общообразователно училище \"дружба\"" },
                    { 207, "Пловдив", true, "Частна Професионална Гимназия по Икономика и Търговия Пловдив", "частна професионална гимназия по икономика и търговия пловдив" },
                    { 208, "Пловдив", true, "Частна Профилирана Гимназия с Чуждоезиково Обучение \"Стоянстрой\"", "частна профилирана гимназия с чуждоезиково обучение \"стоянстрой\"" },
                    { 209, "Пловдив", true, "Средно Общообразователно Училище \"Цар Симеон Велики\"", "средно общообразователно училище \"цар симеон велики\"" },
                    { 210, "Пловдив", true, "Средно Общообразователно Училище \"Симон Боливар\"", "средно общообразователно училище \"симон боливар\"" },
                    { 211, "Пловдив", true, "Професионална Гимназия по Строителство, Архитектура и Геодезия", "професионална гимназия по строителство, архитектура и геодезия" },
                    { 212, "Пловдив", true, "Средно Общообразователно Училище \"Христо Груев Данов\"", "средно общообразователно училище \"христо груев данов\"" },
                    { 213, "Пловдив", true, "Езикова Гимназия \"Пловдив\"", "езикова гимназия \"пловдив\"" },
                    { 214, "Пловдив", true, "Професионална Гимназия по Подемна, Строителна и Транспортна Техника", "професионална гимназия по подемна, строителна и транспортна техника" },
                    { 215, "Пловдив", true, "Средно Общообразователно Училище \"Братя Миладинови\"", "средно общообразователно училище \"братя миладинови\"" },
                    { 216, "Пловдив", true, "Средно Общообразователно Училище \"Константин Величков\"", "средно общообразователно училище \"константин величков\"" },
                    { 217, "Пловдив", true, "Средно-Общообразователно Училище \"Черноризец Храбър\"", "средно-общообразователно училище \"черноризец храбър\"" },
                    { 218, "Пловдив", true, "Частна Профилиранагимназия с Профил Чуждоезиков \"Едмънд Бърк\"", "частна профилиранагимназия с профил чуждоезиков \"едмънд бърк\"" },
                    { 219, "Пловдив", true, "Частна Професионална Гимназия по Икономика и Управление", "частна професионална гимназия по икономика и управление" },
                    { 220, "Пловдив", true, "Частна Профилирана Гимназия \"Класик\"", "частна профилирана гимназия \"класик\"" },
                    { 221, "Пловдив", true, "Частна Професионална Гимназия \"Академик Любомир Илиев\"", "частна професионална гимназия \"академик любомир илиев\"" },
                    { 222, "Варна", true, "Средно Общообразователно Училище \"Любен Каравелов\"", "средно общообразователно училище \"любен каравелов\"" },
                    { 223, "Варна", true, "Професионална Гимназия по Строителство, Архитектура и Геодезия \"Васил Левски\"", "професионална гимназия по строителство, архитектура и геодезия \"васил левски\"" },
                    { 224, "Варна", true, "Математическа Гимназия \"Д-р Петър Берон\"", "математическа гимназия \"д-р петър берон\"" },
                    { 225, "Варна", true, "?V Езикова Гимназия \"Фредерик Жолио - Кюри\"", "?v езикова гимназия \"фредерик жолио - кюри\"" },
                    { 226, "Варна", true, "Професионална Гимназия по Икономика \"Д-р Иван Богоров\"", "професионална гимназия по икономика \"д-р иван богоров\"" },
                    { 227, "Варна", true, "Първа Езикова Гимназия", "първа езикова гимназия" },
                    { 228, "Варна", true, "Средно Общообразователно Училище \"Гео Милев\"", "средно общообразователно училище \"гео милев\"" },
                    { 229, "Варна", true, "Седмо Средно Общообразователно Училище \"Найден Геров\"", "седмо средно общообразователно училище \"найден геров\"" },
                    { 230, "Варна", true, "Частна Профилирана Гимназия по Информационни Технологии и Обществени Комуникации \"Антоан Дьо Сент-Екзюпери\"", "частна профилирана гимназия по информационни технологии и обществени комуникации \"антоан дьо сент-екзюпери\"" },
                    { 231, "Варна", true, "Трета Природоматематическа Гимназия \"Академик Методий Попов\"", "трета природоматематическа гимназия \"академик методий попов\"" },
                    { 232, "Варна", true, "VIII Средно Общообразователно Училище с Преподаване на Чужди Езици \"Ал. С. Пушкин\"", "viii средно общообразователно училище с преподаване на чужди езици \"ал. с. пушкин\"" },
                    { 233, "Варна", true, "Средно Общообразователно Училище \"Васил Друмев\"", "средно общообразователно училище \"васил друмев\"" },
                    { 234, "Варна", true, "Гимназия с Преподаване на Чужди Езици \"Йоан Екзарх\"", "гимназия с преподаване на чужди езици \"йоан екзарх\"" },
                    { 235, "Варна", true, "Професионална Техническа Гимназия", "професионална техническа гимназия" },
                    { 236, "Варна", true, "Професионална Гимназия по Сградостроителство \"Кольо Фичето\"", "професионална гимназия по сградостроителство \"кольо фичето\"" },
                    { 237, "Варна", true, "Частна Търговска Гимназия", "частна търговска гимназия" },
                    { 238, "Варна", true, "Частна Професионална Гимназия \"Бизнесбанк Училище\"", "частна професионална гимназия \"бизнесбанк училище\"" },
                    { 239, "Варна", true, "Частна Професионална Гимназия по Управление на Туризма \"Константин Фотинов\"", "частна професионална гимназия по управление на туризма \"константин фотинов\"" },
                    { 240, "Варна", true, "Частна Езикова Гимназия с Изучаване на Чужди Езици \"Джордж Байрон\"", "частна езикова гимназия с изучаване на чужди езици \"джордж байрон\"" }
                });

            migrationBuilder.InsertData(
                table: "Schools",
                columns: new[] { "Id", "City", "IsActive", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { 241, "Варна", true, "Варненска Търговска Гимназия \"Георги Стойков Раковски\"", "варненска търговска гимназия \"георги стойков раковски\"" },
                    { 242, "Варна", true, "Професионална Гимназия по Текстил и Моден Дизайн", "професионална гимназия по текстил и моден дизайн" },
                    { 243, "Варна", true, "Професионална Гимназия по Горско Стопанство и Дървообработване \"Николай Хайтов\"", "професионална гимназия по горско стопанство и дървообработване \"николай хайтов\"" },
                    { 244, "Варна", true, "Професионална Гимназия по Електротехника", "професионална гимназия по електротехника" },
                    { 245, "Варна", true, "Професионална Гимназия по Туризъм \"Проф. Д-Р Асен Златаров\"", "професионална гимназия по туризъм \"проф. д-р асен златаров\"" },
                    { 246, "Варна", true, "Първо СОУ \"Димчо Дебелянов\"", "първо соу \"димчо дебелянов\"" },
                    { 247, "Варна", true, "Частна Езикова Гимназия \"Никанор\"", "частна езикова гимназия \"никанор\"" },
                    { 248, "Варна", true, "Частна професионална гимназия по икономика \"Атанас Буров\"", "частна професионална гимназия по икономика \"атанас буров\"" },
                    { 249, "Варна", true, "Средно Общообразователно Училище \"Елин Пелин\"", "средно общообразователно училище \"елин пелин\"" },
                    { 250, "Варна", true, "Средно Общообразователно Училище \"Пейо Крачолов Яворов\"", "средно общообразователно училище \"пейо крачолов яворов\"" },
                    { 251, "Варна", true, "Средно Общообразователно Училище \"Свети Климент Охридски\"", "средно общообразователно училище \"свети климент охридски\"" },
                    { 252, "Варна", true, "Национална Гимназия За Хуманитарни Науки и Изкуства \"Константин Преславски\"", "национална гимназия за хуманитарни науки и изкуства \"константин преславски\"" },
                    { 253, "Варна", true, "Професионална Гимназия по Химични и Хранително-Вкусови Технологии \"Дм.Ив.Менделеев\"", "професионална гимназия по химични и хранително-вкусови технологии \"дм.ив.менделеев\"" },
                    { 254, "Варна", true, "Професионална Гимназия по Машиностроене и Транспорт", "професионална гимназия по машиностроене и транспорт" },
                    { 255, "Варна", true, "Частна Професионална Гимназия Със Специалности с Интензивно Изучаване на Чужди Езици", "частна професионална гимназия със специалности с интензивно изучаване на чужди езици" },
                    { 256, "Варна", true, "Варненска Морска Гимназия \"Свети Николай Чудотворец\"", "варненска морска гимназия \"свети николай чудотворец\"" },
                    { 257, "Варна", true, "Второ Средно Общообразователно Училище", "второ средно общообразователно училище" },
                    { 258, "Варна", true, "Американска гимназия на България", "американска гимназия на българия" },
                    { 259, "Бургас", true, "Професионална Гимназия по Химични Технологии \"Академик Н. Д. Зелинский\"", "професионална гимназия по химични технологии \"академик н. д. зелинский\"" },
                    { 260, "Бургас", true, "Природоматематическа Гимназия \"Академик Никола Обрешков\"", "природоматематическа гимназия \"академик никола обрешков\"" },
                    { 261, "Бургас", true, "Професионална Гимназия по Строителство, Архитектура и Геодезия \"Кольо Фичето\"", "професионална гимназия по строителство, архитектура и геодезия \"кольо фичето\"" },
                    { 262, "Бургас", true, "Професионална Гимназия по Електротехника и Електроника \"Константин Фотинов\"", "професионална гимназия по електротехника и електроника \"константин фотинов\"" },
                    { 263, "Бургас", true, "Гимназия За Романски Езици Г. С. Раковски", "гимназия за романски езици г. с. раковски" },
                    { 264, "Бургас", true, "Средно Общообразователно Училище \"Добри Чинтулов\"", "средно общообразователно училище \"добри чинтулов\"" },
                    { 265, "Бургас", true, "Средно Общообразователноучилище \"Йордан Йовков\"", "средно общообразователноучилище \"йордан йовков\"" },
                    { 266, "Бургас", true, "Професионална Гимназия по Механоелектротехника и Електроника", "професионална гимназия по механоелектротехника и електроника" },
                    { 267, "Бургас", true, "Търговска Гимназия", "търговска гимназия" },
                    { 268, "Бургас", true, "Вечерна Гимназия \"Захари Стоянов\"", "вечерна гимназия \"захари стоянов\"" },
                    { 269, "Бургас", true, "Частна Профилирана Гимназия с Изучаване на Английски Език \"Британика\"", "частна профилирана гимназия с изучаване на английски език \"британика\"" },
                    { 270, "Бургас", true, "Гимназия с Преподаване на Английски Език \"Гео Милев\"", "гимназия с преподаване на английски език \"гео милев\"" },
                    { 271, "Бургас", true, "Средно Общообразователно Училище \"Константин Преславски\"", "средно общообразователно училище \"константин преславски\"" },
                    { 272, "Бургас", true, "Средно Общообразователно Училище \"Иван Вазов\"", "средно общообразователно училище \"иван вазов\"" },
                    { 273, "Бургас", true, "Средно Общообразователно Училище \"Димчо Дебелянов\"", "средно общообразователно училище \"димчо дебелянов\"" },
                    { 274, "Бургас", true, "Средно Общообразователно Училище \"Константин Петканов\"", "средно общообразователно училище \"константин петканов\"" },
                    { 275, "Бургас", true, "Средно Общообразователно Училище \"Петко Росен\"", "средно общообразователно училище \"петко росен\"" },
                    { 276, "Бургас", true, "Средно Общообразователно Училище с Хуманитарно-Естетически Профил \"Св.Св. Кирил и Методий\"", "средно общообразователно училище с хуманитарно-естетически профил \"св.св. кирил и методий\"" },
                    { 277, "Бургас", true, "Гимназия с Преподаване на Немски Език \"Гьоте\"", "гимназия с преподаване на немски език \"гьоте\"" },
                    { 278, "Бургас", true, "Гимназия За Чужди Езици \"Васил Левски\"", "гимназия за чужди езици \"васил левски\"" },
                    { 279, "Бургас", true, "Професионална Гимназия по Туризъм \"Проф.Д-Р Асен Златаров\"", "професионална гимназия по туризъм \"проф.д-р асен златаров\"" },
                    { 280, "Бургас", true, "Професионална Гимназия по Морско Корабоплаване и Риболов \"Свети Никола\"", "професионална гимназия по морско корабоплаване и риболов \"свети никола\"" },
                    { 281, "Бургас", true, "Професионална Гимназия по Транспорт", "професионална гимназия по транспорт" },
                    { 282, "Бургас", true, "Професионална Техническа Гимназия", "професионална техническа гимназия" }
                });

            migrationBuilder.InsertData(
                table: "Schools",
                columns: new[] { "Id", "City", "IsActive", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { 283, "Бургас", true, "Професионална Гимназия по Дървообработване \"Георги Кондолов\"", "професионална гимназия по дървообработване \"георги кондолов\"" },
                    { 284, "Бургас", true, "Професионална Гимназия по Сградостроителство и Инсталации \"Пеньо Пенев\"", "професионална гимназия по сградостроителство и инсталации \"пеньо пенев\"" },
                    { 285, "Бургас", true, "Първо Частно Прогимназиално Училище", "първо частно прогимназиално училище" },
                    { 286, "Русе", true, "Професионална Гимназия по Механотехника", "професионална гимназия по механотехника" },
                    { 287, "Русе", true, "Частна Профилирана Гимназия \"Джордж Байрон\"", "частна профилирана гимназия \"джордж байрон\"" },
                    { 288, "Русе", true, "Средно Общообразователноучилище \"Васил Левски\"", "средно общообразователноучилище \"васил левски\"" },
                    { 289, "Русе", true, "Професионална Гимназия по Зърнопреработвателни и Хранителни Технологии \"Проф.Д-р Асен Златаров\"", "професионална гимназия по зърнопреработвателни и хранителни технологии \"проф.д-р асен златаров\"" },
                    { 290, "Русе", true, "Професионална Гимназия по Икономика и Управление \"Елиас Канети\"", "професионална гимназия по икономика и управление \"елиас канети\"" },
                    { 291, "Русе", true, "Професионална Гимназия по Дървообработване и Вътрешна Архитектура \"Йосиф Вондрак\"", "професионална гимназия по дървообработване и вътрешна архитектура \"йосиф вондрак\"" },
                    { 292, "Русе", true, "Професионална Гимназия по Химични Технологии и Биотехнологии \"Проф. Димитър Баларев\"", "професионална гимназия по химични технологии и биотехнологии \"проф. димитър баларев\"" },
                    { 293, "Русе", true, "Средно Общообразователно Училище с Преподаване на Немски Език \"Фридрих Шилер\"", "средно общообразователно училище с преподаване на немски език \"фридрих шилер\"" },
                    { 294, "Русе", true, "Математическа Гимназия \"Баба Тонка\"", "математическа гимназия \"баба тонка\"" },
                    { 295, "Русе", true, "Английска Гимназия \"Гео Милев\"", "английска гимназия \"гео милев\"" },
                    { 296, "Русе", true, "Средно Общообразователно Училище За Европейски Езици \"Свети Константин-Кирил Философ\"", "средно общообразователно училище за европейски езици \"свети константин-кирил философ\"" },
                    { 297, "Русе", true, "Първо Частно Средно Общообразователно Училище \"Леонардо Да Винчи\"", "първо частно средно общообразователно училище \"леонардо да винчи\"" },
                    { 298, "Русе", true, "Професионална Гимназия по Електротехника и Електроника \"Апостол Арнаудов\"", "професионална гимназия по електротехника и електроника \"апостол арнаудов\"" },
                    { 299, "Русе", true, "Професионална Гимназия по Облекло \"Недка Иван Лазарова\"", "професионална гимназия по облекло \"недка иван лазарова\"" },
                    { 300, "Русе", true, "Професионална Гимназия по Туризъм \"Иван П. Павлов\"", "професионална гимназия по туризъм \"иван п. павлов\"" },
                    { 301, "Русе", true, "Професионална Гимназия по Речно Корабостроене и Корабоплаване", "професионална гимназия по речно корабостроене и корабоплаване" },
                    { 302, "Русе", true, "Професионална Гимназия по Транспорт", "професионална гимназия по транспорт" },
                    { 303, "Русе", true, "Професионална Гимназия по Строителство, Архитектура и Геодезия \"Пеньо Пенев\"", "професионална гимназия по строителство, архитектура и геодезия \"пеньо пенев\"" },
                    { 304, "Русе", true, "Професионална Гимназия по Промишлени Технологии \"Атанас Цонев Буров\"", "професионална гимназия по промишлени технологии \"атанас цонев буров\"" },
                    { 305, "Русе", true, "Средно Общообразователно Училище \"Йордан Йовков\"", "средно общообразователно училище \"йордан йовков\"" },
                    { 306, "Русе", true, "Средно Общообразователно Училище \"Христо Ботев\"", "средно общообразователно училище \"христо ботев\"" },
                    { 307, "Русе", true, "Средно Общообразователно Училище \"Възраждане\"", "средно общообразователно училище \"възраждане\"" },
                    { 308, "Русе", true, "Средно Общообразователно Духовно Училище", "средно общообразователно духовно училище" },
                    { 309, "Русе", true, "Частна Профилирана Гимназия \"Джон Атанасов\"", "частна профилирана гимназия \"джон атанасов\"" },
                    { 310, "Русе", true, "Професионална Гимназия по Селско Стопанство \"Ангел Кънчев\"", "професионална гимназия по селско стопанство \"ангел кънчев\"" },
                    { 311, "Русе", true, "Общежитие За Средношколци", "общежитие за средношколци" },
                    { 312, "Стара Загора", true, "Търговска Гимназия \"Княз Симеон Търновски\" ", "търговска гимназия \"княз симеон търновски\" " },
                    { 313, "Стара Загора", true, "Средно Общообразователно Училище \"Железник\"", "средно общообразователно училище \"железник\"" },
                    { 314, "Стара Загора", true, "Природоматематическа Гимназия \"Гео Милев\" Стара Загора", "природоматематическа гимназия \"гео милев\" стара загора" },
                    { 315, "Стара Загора", true, "Средно Общообразователно Училище \"Максим Горки\"", "средно общообразователно училище \"максим горки\"" },
                    { 316, "Стара Загора", true, "Средно Общообразователно Училище \"Иван Вазов\"", "средно общообразователно училище \"иван вазов\"" },
                    { 317, "Стара Загора", true, "Професионална Гимназия по Механотехника и Транспорт \"Н. Й. Вапцаров\"", "професионална гимназия по механотехника и транспорт \"н. й. вапцаров\"" },
                    { 318, "Стара Загора", true, "Професионална Гимназия по Биотехнологии и Химични Технологии \"Димитрий Менделеев\"", "професионална гимназия по биотехнологии и химични технологии \"димитрий менделеев\"" },
                    { 319, "Стара Загора", true, "Професионална Гимназия по Ветеринарна Медицина \"Иван П. Павлов\"", "професионална гимназия по ветеринарна медицина \"иван п. павлов\"" },
                    { 320, "Стара Загора", true, "Професионална Гимназия по Електроника \"Джон Атанасов\"", "професионална гимназия по електроника \"джон атанасов\"" },
                    { 321, "Стара Загора", true, "Професионална Гимназия по Строителство,Архитектура и Геодезия \"Лубор Байер\"", "професионална гимназия по строителство,архитектура и геодезия \"лубор байер\"" },
                    { 322, "Стара Загора", true, "Гимназия с Преподаване на Чужди Езици \"Ромен Ролан\"", "гимназия с преподаване на чужди езици \"ромен ролан\"" },
                    { 323, "Стара Загора", true, "Средно Общообразователно Училище \"Христо Смирненски\"", "средно общообразователно училище \"христо смирненски\"" },
                    { 324, "Стара Загора", true, "Средно Общообразователно Училище \"Васил Левски\"", "средно общообразователно училище \"васил левски\"" }
                });

            migrationBuilder.InsertData(
                table: "Schools",
                columns: new[] { "Id", "City", "IsActive", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { 325, "Стара Загора", true, "Гимназия \"Христо Ботев\" Стара Загора", "гимназия \"христо ботев\" стара загора" },
                    { 326, "Стара Загора", true, "Вечерно Соу \"Захари Стоянов\"", "вечерно соу \"захари стоянов\"" },
                    { 327, "Стара Загора", true, "Професионална Гимназияпо Електротехника \"Г. С. Раковски\"", "професионална гимназияпо електротехника \"г. с. раковски\"" },
                    { 328, "Стара Загора", true, "Професионална Гимназия по Строителствои Дървообработване \"Инж. Недьо Ранчев\"", "професионална гимназия по строителствои дървообработване \"инж. недьо ранчев\"" },
                    { 329, "Стара Загора", true, "Професионална Гимназия по Облекло и Хранене \"Райна Княгиня\"", "професионална гимназия по облекло и хранене \"райна княгиня\"" },
                    { 330, "Стара Загора", true, "Частна Профилирана Гимназия \"Траяна\"", "частна профилирана гимназия \"траяна\"" },
                    { 331, "Стара Загора", true, "Частна Професионална Гимназия по Управление на Туризма \"Константин Фотинов\"", "частна професионална гимназия по управление на туризма \"константин фотинов\"" },
                    { 332, "Плевен", true, "Гимназия с Преподаване на Чужди Езици", "гимназия с преподаване на чужди езици" },
                    { 333, "Плевен", true, "Математическа Гимназия \"Гео Милев\"", "математическа гимназия \"гео милев\"" },
                    { 334, "Плевен", true, "Средно Общообразователно Училище \"Стоян Заимов\"", "средно общообразователно училище \"стоян заимов\"" },
                    { 335, "Плевен", true, "Средно Общообразователно Училище \"Иван Вазов\"", "средно общообразователно училище \"иван вазов\"" },
                    { 336, "Плевен", true, "Средно Общообразователно Училище \"Пейо Крачолов Яворов\"", "средно общообразователно училище \"пейо крачолов яворов\"" },
                    { 337, "Плевен", true, "Държавна Финансово-Стопанска Гимназия \"Интелект\"", "държавна финансово-стопанска гимназия \"интелект\"" },
                    { 338, "Плевен", true, "Професионална Гимназия по Хранително-Вкусови Технологии \"Луи Пастьор\"", "професионална гимназия по хранително-вкусови технологии \"луи пастьор\"" },
                    { 339, "Плевен", true, "Професионална Гимназия по Строителство, Архитектура и Геодезия \"Никола Фичев\"", "професионална гимназия по строителство, архитектура и геодезия \"никола фичев\"" },
                    { 340, "Плевен", true, "Професионална Гимназия по Транспорт \"Проф. Цветан Лазаров\"", "професионална гимназия по транспорт \"проф. цветан лазаров\"" },
                    { 341, "Плевен", true, "Професионална Гимназия по Електроника и Химични Технологии \"Проф. Асен Златаров\"", "професионална гимназия по електроника и химични технологии \"проф. асен златаров\"" },
                    { 342, "Плевен", true, "Професионална Гимназия по Лозарство и Винарство \"Александър Стамболийски\"", "професионална гимназия по лозарство и винарство \"александър стамболийски\"" },
                    { 343, "Плевен", true, "Професионална Гимназия по Подемна, Строителна и Транспортна Техника \"Г.С.Раковски\"", "професионална гимназия по подемна, строителна и транспортна техника \"г.с.раковски\"" },
                    { 344, "Плевен", true, "Професионална Гимназия по Туризъм \"Алеко Константинов\"", "професионална гимназия по туризъм \"алеко константинов\"" },
                    { 345, "Плевен", true, "Професионална Гимназия по Облекло и Текстил", "професионална гимназия по облекло и текстил" },
                    { 346, "Плевен", true, "Професионална Гимназия по Механо-електротехника", "професионална гимназия по механо-електротехника" },
                    { 347, "Плевен", true, "Прогимназия \"Цветан Спасов\"", "прогимназия \"цветан спасов\"" },
                    { 348, "Плевен", true, "Средно Общообразователно Училище \"Анастасия Димитрова\"", "средно общообразователно училище \"анастасия димитрова\"" },
                    { 349, "Плевен", true, "Средно Общообразователно Училище \"Христо Смирненски\"", "средно общообразователно училище \"христо смирненски\"" },
                    { 350, "Плевен", true, "Професионална Гимназия по Мениджмънт и Хранителни Технологии", "професионална гимназия по мениджмънт и хранителни технологии" },
                    { 351, "Плевен", true, "Професионална Гимназия по Ресторантьорство, Търговия и Обслужване", "професионална гимназия по ресторантьорство, търговия и обслужване" },
                    { 352, "Плевен", true, "Частна Профилирана Гимназия \"Иком Интелект\"", "частна профилирана гимназия \"иком интелект\"" },
                    { 353, "Плевен", true, "Професионална Гимназия \"Захарий Зограф\"", "професионална гимназия \"захарий зограф\"" },
                    { 354, "Плевен", true, "Общоградско Средношколско Общежитие", "общоградско средношколско общежитие" },
                    { 355, "Добрич", true, "Професионална Гимназия по Механотехника и Електротехника \"Михаил Василиевич Ломоносов\"", "професионална гимназия по механотехника и електротехника \"михаил василиевич ломоносов\"" },
                    { 356, "Добрич", true, "Профилирана Гимназия по Туризъм и Предприемачество \"Райко Цончев\"", "профилирана гимназия по туризъм и предприемачество \"райко цончев\"" },
                    { 357, "Добрич", true, "Професионална Гимназия по Ветеринарна Медицина \"Проф. Д-Р Георги Павлов\"", "професионална гимназия по ветеринарна медицина \"проф. д-р георги павлов\"" },
                    { 358, "Добрич", true, "Професионална Гимназия по Аграрно Стопанство", "професионална гимназия по аграрно стопанство" },
                    { 359, "Добрич", true, "Средно Общообразователно Училище \"Димитър Талев - Гр. Добрич\"", "средно общообразователно училище \"димитър талев - гр. добрич\"" },
                    { 360, "Добрич", true, "Средно Общообразователно Училище \"Дора Габе\"", "средно общообразователно училище \"дора габе\"" },
                    { 361, "Добрич", true, "Средно Общообразователно Училище \"Петко Рачов Славейков\"", "средно общообразователно училище \"петко рачов славейков\"" },
                    { 362, "Добрич", true, "Природоматематическа Гимназия \"Иван Вазов\"", "природоматематическа гимназия \"иван вазов\"" },
                    { 363, "Добрич", true, "Езикова Гимназия \"Гео Милев\"", "езикова гимназия \"гео милев\"" },
                    { 364, "Добрич", true, "Частна Профилирана Гимназия \"Леонардо Да Винчи\"", "частна профилирана гимназия \"леонардо да винчи\"" },
                    { 365, "Добрич", true, "Професионална Гимназия по Транспорт, Обслужване и Лека Промишленост", "професионална гимназия по транспорт, обслужване и лека промишленост" },
                    { 366, "Добрич", true, "Средно Общообразователно Училище \"Свети Климент Охридски\"", "средно общообразователно училище \"свети климент охридски\"" }
                });

            migrationBuilder.InsertData(
                table: "Schools",
                columns: new[] { "Id", "City", "IsActive", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { 367, "Добрич", true, "Средно Общообразователно Училище \"Любен Каравелов\"", "средно общообразователно училище \"любен каравелов\"" },
                    { 368, "Добрич", true, "Финансово-Стопанска Гимназия \"Васил Левски\"", "финансово-стопанска гимназия \"васил левски\"" },
                    { 369, "Добрич", true, "Професионална Гимназия по Строителство и Архитектура \"Пеньо Пенев\"", "професионална гимназия по строителство и архитектура \"пеньо пенев\"" },
                    { 370, "Добрич", true, "Професионална Гимназия по Туризъм \"П. К. Яворов\"", "професионална гимназия по туризъм \"п. к. яворов\"" },
                    { 371, "Сливен", true, "Професионална Гимназия по Текстил и Облекло \"Добри Желязков\"", "професионална гимназия по текстил и облекло \"добри желязков\"" },
                    { 372, "Сливен", true, "Природо - Математическа Гимназия \"Добри П. Чинтулов\"", "природо - математическа гимназия \"добри п. чинтулов\"" },
                    { 373, "Сливен", true, "10-то Средно Общообразователно Училище \"Йордан Йовков\"", "10-то средно общообразователно училище \"йордан йовков\"" },
                    { 374, "Сливен", true, "11-то Средно Общообразователно Училище \"Константин Константинов\"", "11-то средно общообразователно училище \"константин константинов\"" },
                    { 375, "Сливен", true, "Професионална Гимназия по Електротехника и Електроника \"Мария Склодовска-Кюри\"", "професионална гимназия по електротехника и електроника \"мария склодовска-кюри\"" },
                    { 376, "Сливен", true, "Професионална Гимназия по Икономика \"Професор Д-r Димитър Табаков\"", "професионална гимназия по икономика \"професор д-r димитър табаков\"" },
                    { 377, "Сливен", true, "Професионална Гимназия по Хотелиерство и Туризъм \"Акад. Неделчо Неделчев\"", "професионална гимназия по хотелиерство и туризъм \"акад. неделчо неделчев\"" },
                    { 378, "Сливен", true, "Сливенска Професионална Гимназия по Строителство и Геодезия \"Арх. Георги Козаров\"", "сливенска професионална гимназия по строителство и геодезия \"арх. георги козаров\"" },
                    { 379, "Сливен", true, "Гимназия с преподаване на западни езици \"Захари Стоянов\"", "гимназия с преподаване на западни езици \"захари стоянов\"" },
                    { 380, "Сливен", true, "Хуманитарна Гимназия \"Дамян Дамянов\"", "хуманитарна гимназия \"дамян дамянов\"" },
                    { 381, "Сливен", true, "5-то Средно Общообразователно Училище \"Пейо Крачолов Яворов\"", "5-то средно общообразователно училище \"пейо крачолов яворов\"" },
                    { 382, "Шумен", true, "Професионална Гимназия по Строителство, Архитектура и Геодезия", "професионална гимназия по строителство, архитектура и геодезия" },
                    { 383, "Шумен", true, "Професионална Гимназия по Облекло, Хранене и Химични Технологии \"Проф. Д-Р Асен Златаров\"", "професионална гимназия по облекло, хранене и химични технологии \"проф. д-р асен златаров\"" },
                    { 384, "Шумен", true, "Средно Общообразователно Училище \"Панайот Волов\"", "средно общообразователно училище \"панайот волов\"" },
                    { 385, "Шумен", true, "Гимназия с Преподаване на Чужди Езици \"Никола Йонков Вапцаров\"", "гимназия с преподаване на чужди езици \"никола йонков вапцаров\"" },
                    { 386, "Шумен", true, "Средно Общообразователно Училище \"Васил Левски\"", "средно общообразователно училище \"васил левски\"" },
                    { 387, "Шумен", true, "Професионална Гимназия по Механотехника, Електроника, Телекомуникации и Транспорт \"Христо Ботев\"", "професионална гимназия по механотехника, електроника, телекомуникации и транспорт \"христо ботев\"" },
                    { 388, "Шумен", true, "Професионална Гимназия по Машиностроене", "професионална гимназия по машиностроене" },
                    { 389, "Шумен", true, "Професионална Гимназия по Икономика", "професионална гимназия по икономика" },
                    { 390, "Шумен", true, "Професионална Гимназия по Селско Стопанство и Хранителни Технологии", "професионална гимназия по селско стопанство и хранителни технологии" },
                    { 391, "Шумен", true, "Средно Общообразователно Училище \"Трайко Симеонов\"", "средно общообразователно училище \"трайко симеонов\"" },
                    { 392, "Шумен", true, "Средно Общообразователно Училище \"Йоан Екзарх Български\"", "средно общообразователно училище \"йоан екзарх български\"" },
                    { 393, "Шумен", true, "Средно Общообразователно Училище \"Сава Доброплодни\"", "средно общообразователно училище \"сава доброплодни\"" },
                    { 395, "Перник", true, "Природо-Математическа Гимназия \"Христо Смирненски\"", "природо-математическа гимназия \"христо смирненски\"" },
                    { 396, "Перник", true, "Гимназия с Преподаване на Чужди Езици \"Симеон Радев\"", "гимназия с преподаване на чужди езици \"симеон радев\"" },
                    { 397, "Перник", true, "Професионална Техничека Гимназия \"Юрий Гагарин\"", "професионална техничека гимназия \"юрий гагарин\"" },
                    { 398, "Перник", true, "Технологична Професионална Гимназия \"Мария Кюри\"", "технологична професионална гимназия \"мария кюри\"" },
                    { 399, "Перник", true, "Професионална Гимназия по Икономика", "професионална гимназия по икономика" },
                    { 400, "Перник", true, "Средно Общообразователно Училище \"Свети Климент Охридски\"", "средно общообразователно училище \"свети климент охридски\"" },
                    { 401, "Перник", true, "Пето Средно Общообразователно Училище \"Петко Рачов Славейков\"", "пето средно общообразователно училище \"петко рачов славейков\"" },
                    { 402, "Перник", true, "Шесто Средно Общообразователно Училище \"Св. Св. Кирил и Методий\"", "шесто средно общообразователно училище \"св. св. кирил и методий\"" },
                    { 403, "Перник", true, "СОУ с Разширено Изучаване на Чужди Езици \"Д-Р Петър Берон\"", "соу с разширено изучаване на чужди езици \"д-р петър берон\"" },
                    { 404, "Перник", true, "Професионална Гимназия по Енергетика и Минна Промишленост \"Христо Ботев\"", "професионална гимназия по енергетика и минна промишленост \"христо ботев\"" },
                    { 405, "Перник", true, "Професионална Гимназия по Облекло и Туризъм \"Свети Иван Рилски\"", "професионална гимназия по облекло и туризъм \"свети иван рилски\"" },
                    { 406, "Ямбол", true, "Професионална Гимназия по Хранителни Технологии и Туризъм", "професионална гимназия по хранителни технологии и туризъм" },
                    { 407, "Ямбол", true, "Гимназия \"Васил Левски\"", "гимназия \"васил левски\"" },
                    { 408, "Ямбол", true, "Математическа Гимназия \"Атанас Радев\"", "математическа гимназия \"атанас радев\"" },
                    { 409, "Ямбол", true, "Гимназия с Преподаване на Чужди Езици \"Васил Карагьозов\"", "гимназия с преподаване на чужди езици \"васил карагьозов\"" }
                });

            migrationBuilder.InsertData(
                table: "Schools",
                columns: new[] { "Id", "City", "IsActive", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { 410, "Ямбол", true, "Професионална Гимназия по Икономика \"Георги Стойков Раковски\"", "професионална гимназия по икономика \"георги стойков раковски\"" },
                    { 411, "Ямбол", true, "Професионална Гимназия по Строителство и Геодезия \"К. Фичето\"", "професионална гимназия по строителство и геодезия \"к. фичето\"" },
                    { 412, "Ямбол", true, "Професионална Гимназия по Подемна, Строителна и Транспортна Техника \"Н. Й. Вапцаров\"", "професионална гимназия по подемна, строителна и транспортна техника \"н. й. вапцаров\"" },
                    { 413, "Ямбол", true, "Професионална Гимназия по Лека Промишленост, Екология и Химични Технологии", "професионална гимназия по лека промишленост, екология и химични технологии" },
                    { 414, "Ямбол", true, "Професионална Гимназия по Земеделие \"Христо Ботев\"", "професионална гимназия по земеделие \"христо ботев\"" },
                    { 415, "Хасково", true, "Професионална Гимназия по Туризъм \"Александър Паскалев\"", "професионална гимназия по туризъм \"александър паскалев\"" },
                    { 416, "Хасково", true, "Гимназия с Преподаванена Чужди Езици \"Проф. Д-Р Асен Златаров\"", "гимназия с преподаванена чужди езици \"проф. д-р асен златаров\"" },
                    { 417, "Хасково", true, "Професионална Гимназия по Дървообработване и Строителство \"Цар Иван Асен ?I\"", "професионална гимназия по дървообработване и строителство \"цар иван асен ?i\"" },
                    { 418, "Хасково", true, "Средно Общообразователно Училище \"Васил Левски\"", "средно общообразователно училище \"васил левски\"" },
                    { 419, "Хасково", true, "Природо-Математическа Гимназия \"Академик Боян Петканчин\"", "природо-математическа гимназия \"академик боян петканчин\"" },
                    { 420, "Хасково", true, "Професионална Гимназия по Транспорт \"Н.Й.Вапцаров\"", "професионална гимназия по транспорт \"н.й.вапцаров\"" },
                    { 421, "Хасково", true, "Професионална Гимназия по Механоелектротехника \"Стойчо и Кица Марчеви\"", "професионална гимназия по механоелектротехника \"стойчо и кица марчеви\"" },
                    { 422, "Хасково", true, "Финансово-Стопанска Гимназия \"Атанас Буров\"", "финансово-стопанска гимназия \"атанас буров\"" },
                    { 423, "Хасково", true, "Средно Общообразователно Училище \"Св.Паисий Хилендарски\"", "средно общообразователно училище \"св.паисий хилендарски\"" },
                    { 424, "Хасково", true, "Професионална Гимназия по Селско Стопанство", "професионална гимназия по селско стопанство" },
                    { 425, "Хасково", true, "Професионална Гимназия по Лека Промишленост", "професионална гимназия по лека промишленост" },
                    { 426, "Пазарджик", true, "Професионална Гимназия по Облекло", "професионална гимназия по облекло" },
                    { 427, "Пазарджик", true, "Професионална Гимназия по Промишлени Технологии", "професионална гимназия по промишлени технологии" },
                    { 428, "Пазарджик", true, "Средно Общообразователно Училище \"Георги Брегов\"", "средно общообразователно училище \"георги брегов\"" },
                    { 429, "Пазарджик", true, "Професионална Гимназия по Строителство и Архитектура", "професионална гимназия по строителство и архитектура" },
                    { 430, "Пазарджик", true, "Математическа Гимназия \"Константин Величков\"", "математическа гимназия \"константин величков\"" },
                    { 431, "Пазарджик", true, "Гимназия \"Иван Сергеевич Аксаков\"", "гимназия \"иван сергеевич аксаков\"" },
                    { 432, "Пазарджик", true, "Професионална Гимназияпо Механоелектротехника", "професионална гимназияпо механоелектротехника" },
                    { 433, "Пазарджик", true, "Езикова Гимназия \"Бертолт Брехт\"", "езикова гимназия \"бертолт брехт\"" },
                    { 434, "Пазарджик", true, "Средно Общообразователно Училище \"Георги Бенковски\"", "средно общообразователно училище \"георги бенковски\"" },
                    { 435, "Пазарджик", true, "Средно Общообразователно Училище \"Д-Р Петър Берон\"", "средно общообразователно училище \"д-р петър берон\"" },
                    { 436, "Пазарджик", true, "Професионална Гимназия по Икономика и Мениджмънт", "професионална гимназия по икономика и мениджмънт" },
                    { 437, "Пазарджик", true, "Прогимназия \"Св. Св. Кирил и Методий\"", "прогимназия \"св. св. кирил и методий\"" },
                    { 438, "Пазарджик", true, "Професионална Гимназия по Селско Стопанство \"Царица Йоанна\"", "професионална гимназия по селско стопанство \"царица йоанна\"" },
                    { 439, "Пазарджик", true, "Професионална Гимназия по Химични и Хранителни Технологии", "професионална гимназия по химични и хранителни технологии" },
                    { 440, "Благоевград", true, "Езикова Гимназия \"Акад. Людмил Стоянов\"", "езикова гимназия \"акад. людмил стоянов\"" },
                    { 441, "Благоевград", true, "Природо-Математическа Гимназия \"Акад. Сергей Павлович Корольов\"", "природо-математическа гимназия \"акад. сергей павлович корольов\"" },
                    { 442, "Благоевград", true, "Частна Професионална Гимназия по Предприемачество и Нови Технологии \"Полет\"", "частна професионална гимназия по предприемачество и нови технологии \"полет\"" },
                    { 443, "Благоевград", true, "Професионална Гимназия по Икономика \"Иван Илиев\"", "професионална гимназия по икономика \"иван илиев\"" },
                    { 444, "Благоевград", true, "Средно Общообразователно Училище с Изучаване на Чужди Езици \"Свети Климент Охридски\"", "средно общообразователно училище с изучаване на чужди езици \"свети климент охридски\"" },
                    { 445, "Благоевград", true, "Професионална Гимназия по Текстил и Облекло", "професионална гимназия по текстил и облекло" },
                    { 446, "Благоевград", true, "Национална Хуманитарна Гимназия \"Св.Св.Кирил и Методий\"", "национална хуманитарна гимназия \"св.св.кирил и методий\"" },
                    { 447, "Благоевград", true, "Професионална Гимназия по Електротехника и Електроника \"Никола Йонков Вапцаров\"", "професионална гимназия по електротехника и електроника \"никола йонков вапцаров\"" },
                    { 448, "Благоевград", true, "Седмо Средно Общообразователно Училище \"Кузман Шапкарев\"", "седмо средно общообразователно училище \"кузман шапкарев\"" },
                    { 449, "Благоевград", true, "Професионална Гимназия по Строителство, Архитектура и Геодезия \"В.Левски\"", "професионална гимназия по строителство, архитектура и геодезия \"в.левски\"" },
                    { 450, "Благоевград", true, "Професионална Техническа Гимназия \"Ичко Бойчев\"", "професионална техническа гимназия \"ичко бойчев\"" },
                    { 451, "Благоевград", true, "Осмо Средно Общообразователно Училище \"Арсени Костенцев\"", "осмо средно общообразователно училище \"арсени костенцев\"" }
                });

            migrationBuilder.InsertData(
                table: "Schools",
                columns: new[] { "Id", "City", "IsActive", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { 452, "Благоевград", true, "Средно Общообразователно Училище \"Иван Вазов\"", "средно общообразователно училище \"иван вазов\"" },
                    { 453, "Благоевград", true, "Пето Средно Общообразователно Училище \"Георги Измирлиев\"", "пето средно общообразователно училище \"георги измирлиев\"" },
                    { 454, "Благоевград", true, "Частна Вечерна Гимназия \"Димитър & Йоан\"", "частна вечерна гимназия \"димитър & йоан\"" },
                    { 455, "Велико Търново", true, "Професионална Гимназия по Строителство, Архитектура и Геодезия \"Ангел Попов\"", "професионална гимназия по строителство, архитектура и геодезия \"ангел попов\"" },
                    { 456, "Велико Търново", true, "Хуманитарна Гимназия \"Св.Св. Кирил и Методий\"", "хуманитарна гимназия \"св.св. кирил и методий\"" },
                    { 457, "Велико Търново", true, "Частна Профилирана Гимназия \"Американски Колеж - Аркус\"", "частна профилирана гимназия \"американски колеж - аркус\"" },
                    { 458, "Велико Търново", true, "Природо-математическа Гимназия \"Васил Друмев\"", "природо-математическа гимназия \"васил друмев\"" },
                    { 459, "Велико Търново", true, "Езикова Гимназия \"Проф. Д-Р Асен Златаров\"", "езикова гимназия \"проф. д-р асен златаров\"" },
                    { 460, "Велико Търново", true, "Средно Общообразователно Училище \"Владимир Комаров\"", "средно общообразователно училище \"владимир комаров\"" },
                    { 461, "Велико Търново", true, "Старопрестолна Гимназия по Икономика", "старопрестолна гимназия по икономика" },
                    { 462, "Велико Търново", true, "Професионална Гимназия по Моден Дизайн", "професионална гимназия по моден дизайн" },
                    { 463, "Велико Търново", true, "Професионална Гимназия по Туризъм \"Д-Р Васил Берон\"", "професионална гимназия по туризъм \"д-р васил берон\"" },
                    { 464, "Велико Търново", true, "Професионална Гимназия по Сградостроителство \"Кольо Фичето\"", "професионална гимназия по сградостроителство \"кольо фичето\"" },
                    { 465, "Велико Търново", true, "Частна Професионална Гимназия по Мениджмънт", "частна професионална гимназия по мениджмънт" },
                    { 466, "Велико Търново", true, "Средно Общообразователно Училище \"Емилиян Станев\"", "средно общообразователно училище \"емилиян станев\"" },
                    { 467, "Велико Търново", true, "Средно Общообразователно Училище \"Вела Благоева\"", "средно общообразователно училище \"вела благоева\"" },
                    { 468, "Велико Търново", true, "Средно Общообразователно Училище \"Георги Стойков Раковски\"", "средно общообразователно училище \"георги стойков раковски\"" },
                    { 469, "Велико Търново", true, "Професионална Гимназия по Електроника \"Александър Степанович Попов\"", "професионална гимназия по електроника \"александър степанович попов\"" },
                    { 470, "Враца", true, "Професионална Гимназия по Строителство и Архитектура", "професионална гимназия по строителство и архитектура" },
                    { 471, "Враца", true, "Професионална Гимназия по Търговия и Ресторантьорство", "професионална гимназия по търговия и ресторантьорство" },
                    { 472, "Враца", true, "Средно Общообразователно Училище \"Козма Тричков\"", "средно общообразователно училище \"козма тричков\"" },
                    { 473, "Враца", true, "Природо Математическа Гимназия \"Академик Иван Ценов\"", "природо математическа гимназия \"академик иван ценов\"" },
                    { 474, "Враца", true, "Средно Общообразователно Училище \"Отец Паисий\"", "средно общообразователно училище \"отец паисий\"" },
                    { 475, "Враца", true, "Професионална Техническа Гимназия \"Н.Йонков Вапцаров\"", "професионална техническа гимназия \"н.йонков вапцаров\"" },
                    { 476, "Враца", true, "Средно Общообразователно Училище \"Христо Ботев\"", "средно общообразователно училище \"христо ботев\"" },
                    { 477, "Враца", true, "Езикова Гимназия \"Йоан Екзарх\"", "езикова гимназия \"йоан екзарх\"" },
                    { 478, "Враца", true, "Средно Общообразователно Училище \"Васил Кънчов\"", "средно общообразователно училище \"васил кънчов\"" },
                    { 479, "Враца", true, "Професионална Гимназия по Лека Промишленост и Услуги - Враца", "професионална гимназия по лека промишленост и услуги - враца" },
                    { 480, "Враца", true, "Среднообщообразователно Училище \"Никола Войводов\"", "среднообщообразователно училище \"никола войводов\"" },
                    { 481, "Габрово", true, "Професионална Гимназия по Туризъм \"Пенчо Семов\"", "професионална гимназия по туризъм \"пенчо семов\"" },
                    { 482, "Габрово", true, "Национална Априловска Гимназия", "национална априловска гимназия" },
                    { 483, "Габрово", true, "Природоматематическа Гимназия \"Академик Иван Гюзелев\"", "природоматематическа гимназия \"академик иван гюзелев\"" },
                    { 484, "Габрово", true, "Професионална Гимназия по Строителство", "професионална гимназия по строителство" },
                    { 485, "Габрово", true, "Професионална Гимназия по Текстил и Моден Дизайн", "професионална гимназия по текстил и моден дизайн" },
                    { 486, "Габрово", true, "Средно Общо Образователно Училище \"Отец Паисий\"", "средно общо образователно училище \"отец паисий\"" },
                    { 487, "Габрово", true, "Средно Общообразователно Училище \"Райчо Каролев\"", "средно общообразователно училище \"райчо каролев\"" },
                    { 488, "Габрово", true, "Професионалнатехническа Гимназия \"Д-Р Никола Василиади\"", "професионалнатехническа гимназия \"д-р никола василиади\"" },
                    { 489, "Видин", true, "Професионална Техническа Гимназия \"Васил Левски\"", "професионална техническа гимназия \"васил левски\"" },
                    { 490, "Видин", true, "Средно Общообразователно Училище \"Любен Каравелов\"", "средно общообразователно училище \"любен каравелов\"" },
                    { 491, "Видин", true, "Професионална Гимназия по Облекло и Хранене \"Михалаки Георгиев\"", "професионална гимназия по облекло и хранене \"михалаки георгиев\"" },
                    { 492, "Видин", true, "Професионална Гимназия \"Проф. Д-Р Асен Златаров\"", "професионална гимназия \"проф. д-р асен златаров\"" },
                    { 493, "Видин", true, "Средно Общообразователно Училище \"Петко Рачов Славейков\"", "средно общообразователно училище \"петко рачов славейков\"" }
                });

            migrationBuilder.InsertData(
                table: "Schools",
                columns: new[] { "Id", "City", "IsActive", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { 494, "Видин", true, "Средно Общообразователно Училище \"Цар Симеон Велики\"", "средно общообразователно училище \"цар симеон велики\"" },
                    { 495, "Видин", true, "Природоматематическа Гимназия \"Екзарх Антим I\"", "природоматематическа гимназия \"екзарх антим i\"" },
                    { 496, "Видин", true, "Гимназия с Преподаване на Чужди Езици \"Йордан Радичков\"", "гимназия с преподаване на чужди езици \"йордан радичков\"" },
                    { 497, "Видин", true, "Средно Общообразователно Училище \"Христо Ботев\"", "средно общообразователно училище \"христо ботев\"" },
                    { 498, "Видин", true, "Средно Общообразователно Училище \"Св. Св. Кирил и Методий\"", "средно общообразователно училище \"св. св. кирил и методий\"" },
                    { 499, "Асеновград", true, "Средно Общообразователно Училище \"Свети Свети Кирил и Методий\"", "средно общообразователно училище \"свети свети кирил и методий\"" },
                    { 500, "Асеновград", true, "Професионална Гимназия по Хранително-Вкусови Технологии \"Св. Димитрий Солунски\"", "професионална гимназия по хранително-вкусови технологии \"св. димитрий солунски\"" },
                    { 501, "Асеновград", true, "Средно Общообразователно Училище \"Свети Княз Борис I\"", "средно общообразователно училище \"свети княз борис i\"" },
                    { 502, "Асеновград", true, "Професионална Гимназия \"Свети Патриарх Евтимий\"", "професионална гимназия \"свети патриарх евтимий\"" },
                    { 503, "Асеновград", true, "Професионална Гимназия \"Цар Иван Асен II\"", "професионална гимназия \"цар иван асен ii\"" },
                    { 504, "Казанлък", true, "Професионална Гимназия \"Иван Хаджиенов\"", "професионална гимназия \"иван хаджиенов\"" },
                    { 505, "Казанлък", true, "Национална Гимназия по Пластични Изкуства и Дизайн \"Академик Дечко Узунов\"", "национална гимназия по пластични изкуства и дизайн \"академик дечко узунов\"" },
                    { 506, "Казанлък", true, "Гимназия \"Академик Петко Стайнов\"", "гимназия \"академик петко стайнов\"" },
                    { 507, "Казанлък", true, "Природоматематическа Гимназаия \"Никола Обрешков\"", "природоматематическа гимназаия \"никола обрешков\"" },
                    { 508, "Казанлък", true, "Средно Общообразователно Училище \"Екзарх Антим I\"", "средно общообразователно училище \"екзарх антим i\"" },
                    { 509, "Казанлък", true, "Професионална Гимназия по Лека Промишленост и Туризъм", "професионална гимназия по лека промишленост и туризъм" },
                    { 510, "Казанлък", true, "Хуманитарна Гимназия \"Св.Св.Кирил и Методий\"", "хуманитарна гимназия \"св.св.кирил и методий\"" },
                    { 511, "Казанлък", true, "Професионална Гимназия по Транспорт и Транспортен Мениджмънт", "професионална гимназия по транспорт и транспортен мениджмънт" },
                    { 512, "Казанлък", true, "Професионална Гимназия по Строителство", "професионална гимназия по строителство" },
                    { 513, "Кюстендил", true, "Професионална Гимназия по Дървообработване и Горско Стопанство \"Г. С. Раковски\"", "професионална гимназия по дървообработване и горско стопанство \"г. с. раковски\"" },
                    { 514, "Кюстендил", true, "Природоматематическа Гимназия \"Проф. Емануил Иванов\"", "природоматематическа гимназия \"проф. емануил иванов\"" },
                    { 515, "Кюстендил", true, "Професионална Гимназия по Икономика и Мениджмънт \"Йордан Захариев\"", "професионална гимназия по икономика и мениджмънт \"йордан захариев\"" },
                    { 516, "Кюстендил", true, "Професионална Гимназия по Туризъм \"Никола Йонков Вапцаров\"", "професионална гимназия по туризъм \"никола йонков вапцаров\"" },
                    { 517, "Кюстендил", true, "Гимназия \"Неофит Рилски\"", "гимназия \"неофит рилски\"" },
                    { 518, "Кюстендил", true, "Езикова Гимназия \"Д-Р Петър Берон\"", "езикова гимназия \"д-р петър берон\"" },
                    { 519, "Кюстендил", true, "Професионална Техническа Гимназия \"Джон Атанасов\"", "професионална техническа гимназия \"джон атанасов\"" },
                    { 520, "Кюстендил", true, "Професионална Гимназия по Лека Промишленост \"Владимир Димитров-Майстора\"", "професионална гимназия по лека промишленост \"владимир димитров-майстора\"" },
                    { 521, "Кърджали", true, "Средно Общообразователно Училище с Природо-Математическа Насоченост \"Отец Паисий\"", "средно общообразователно училище с природо-математическа насоченост \"отец паисий\"" },
                    { 522, "Кърджали", true, "Средно Общообразователно Училище \"Петко Рачов Славейков\"", "средно общообразователно училище \"петко рачов славейков\"" },
                    { 523, "Кърджали", true, "Гимназия с Преподаване на Чужди Езици \"Христо Ботев\"", "гимназия с преподаване на чужди езици \"христо ботев\"" },
                    { 524, "Кърджали", true, "Професионална Гимназия по Икономика \"Алеко Константинов\"", "професионална гимназия по икономика \"алеко константинов\"" },
                    { 525, "Кърджали", true, "Професионална Гимназия по Туризъм \"Проф. Д-р Асен Златаров\"", "професионална гимназия по туризъм \"проф. д-р асен златаров\"" },
                    { 526, "Кърджали", true, "Професионална Гимназия \"Васил Левски\"", "професионална гимназия \"васил левски\"" },
                    { 527, "Кърджали", true, "Професионална Гимназия по Електротехника и Електроника \"Капитан Петко Войвода\"", "професионална гимназия по електротехника и електроника \"капитан петко войвода\"" },
                    { 528, "Кърджали", true, "Средно Общообразователно Училище \"Йордан Йовков\"", "средно общообразователно училище \"йордан йовков\"" },
                    { 529, "Кърджали", true, "Средно Общообразователно Училище \"Владимир Димитров - Майстора\"", "средно общообразователно училище \"владимир димитров - майстора\"" },
                    { 530, "Кърджали", true, "СОУ \"Свети Климент Охридски\"", "соу \"свети климент охридски\"" },
                    { 531, "Кърджали", true, "Професионална Гимназия по Облекло и Дизай \"Евридика\"", "професионална гимназия по облекло и дизай \"евридика\"" },
                    { 532, "Кърджали", true, "Професионална Гимназия по Селско и Горско Стопанство", "професионална гимназия по селско и горско стопанство" },
                    { 533, "Кърджали", true, "Професионална Гимназия по Строителство \"Христо Смирненски\"", "професионална гимназия по строителство \"христо смирненски\"" },
                    { 534, "Монтана", true, "Професионална Гимназия по Строителство, Архитектура и Геодезия", "професионална гимназия по строителство, архитектура и геодезия" },
                    { 535, "Монтана", true, "Природо-Математическа Гимназия \"Свети Климент Охридски\"", "природо-математическа гимназия \"свети климент охридски\"" }
                });

            migrationBuilder.InsertData(
                table: "Schools",
                columns: new[] { "Id", "City", "IsActive", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { 536, "Монтана", true, "Второ Средно Общообразователно Училище \"Никола Йонков Вапцаров\"", "второ средно общообразователно училище \"никола йонков вапцаров\"" },
                    { 537, "Монтана", true, "Професионална Техническа Гимназия \"Юрий Гагарин\"", "професионална техническа гимназия \"юрий гагарин\"" },
                    { 538, "Монтана", true, "Финансово-Стопанска Гимназия \"Васил Левски\"", "финансово-стопанска гимназия \"васил левски\"" },
                    { 539, "Монтана", true, "Гимназия с Преподаване на Чужди Езици \"Петърбогдан\"", "гимназия с преподаване на чужди езици \"петърбогдан\"" },
                    { 540, "Монтана", true, "Пето Средно Общообразователно Училище \"Христо Ботев\"", "пето средно общообразователно училище \"христо ботев\"" },
                    { 541, "Монтана", true, "Осмо Средно Общообразователно Училище \"Отец Паисий\"", "осмо средно общообразователно училище \"отец паисий\"" },
                    { 542, "Монтана", true, "Девето Средно Общообразователно Училище \"Йордан Радичков\"", "девето средно общообразователно училище \"йордан радичков\"" },
                    { 543, "Монтана", true, "Професионална Гимназия по Лека Промишленост", "професионална гимназия по лека промишленост" },
                    { 544, "Монтана", true, "Професионална Гимназия по Електротехника \"Христо Ботев\"", "професионална гимназия по електротехника \"христо ботев\"" },
                    { 545, "Димитровград", true, "Професионална Гимназия Димитровград", "професионална гимназия димитровград" },
                    { 546, "Димитровград", true, "Професионална Гимназия по Химични и Хранителни Технологии \"Проф. Д-Р Асен Златаров\"", "професионална гимназия по химични и хранителни технологии \"проф. д-р асен златаров\"" },
                    { 547, "Димитровград", true, "Природо-Математическа Гимназия със Засилено изучаване на Чужди Езици \"Иван Вазов\"", "природо-математическа гимназия със засилено изучаване на чужди езици \"иван вазов\"" },
                    { 548, "Димитровград", true, "Средно Общообразователно Училище \"Любен Каравелов\"", "средно общообразователно училище \"любен каравелов\"" },
                    { 549, "Димитровград", true, "Езикова Гимназия \"Д-Р Иван Богоров\"", "езикова гимназия \"д-р иван богоров\"" },
                    { 550, "Димитровград", true, "Средно Общообразователно Училище \"Васил Левски\"", "средно общообразователно училище \"васил левски\"" },
                    { 551, "Търговище", true, "Второ Средно Общообразователно Училище \"Професор Никола Маринов\"", "второ средно общообразователно училище \"професор никола маринов\"" },
                    { 552, "Търговище", true, "Първо Средно Общообразователно Училище \"Свети Седмочисленици\"", "първо средно общообразователно училище \"свети седмочисленици\"" },
                    { 553, "Търговище", true, "Профилирана Гимназия с Изучаване на Чужди Езици \"Митрополит Андрей\"", "профилирана гимназия с изучаване на чужди езици \"митрополит андрей\"" },
                    { 554, "Търговище", true, "Пг по Икономическа Информатика \"Джон Атанасов\"", "пг по икономическа информатика \"джон атанасов\"" },
                    { 555, "Търговище", true, "Професионална Техническа Гимназия \"Цар Симеон Велики\"", "професионална техническа гимназия \"цар симеон велики\"" },
                    { 556, "Търговище", true, "Професионална Гимназия по Туризъм и Хранително-Вкусови Технологии \"Алеко Константинов\"", "професионална гимназия по туризъм и хранително-вкусови технологии \"алеко константинов\"" },
                    { 557, "Търговище", true, "Професионална Гимназия по Земеделие", "професионална гимназия по земеделие" },
                    { 558, "Търговище", true, "Професионална Гимназия по Електротехника и Строителство", "професионална гимназия по електротехника и строителство" },
                    { 559, "Силистра", true, "Природоматематическа Гимназия \"Св.Климент Охридски\"", "природоматематическа гимназия \"св.климент охридски\"" },
                    { 560, "Силистра", true, "Езикова Гимназия \"Пейо Яворов\"", "езикова гимназия \"пейо яворов\"" },
                    { 561, "Силистра", true, "Професионална Гимназия по Механотехника \"Владимир Комаров\"", "професионална гимназия по механотехника \"владимир комаров\"" },
                    { 562, "Силистра", true, "Професионална Гимназия по Строителство \"Пеньо Пенев\"", "професионална гимназия по строителство \"пеньо пенев\"" },
                    { 563, "Силистра", true, "Средно Общообразователно Училище \"Юрий Алексеевич Гагарин\"", "средно общообразователно училище \"юрий алексеевич гагарин\"" },
                    { 564, "Силистра", true, "Средно Общообразователно Училище \"Никола Йонков Вапцаров\"", "средно общообразователно училище \"никола йонков вапцаров\"" },
                    { 565, "Силистра", true, "Професионална Гимназия по Стопанскоуправление, Администрация и Услуги \"Атанас Буров\"", "професионална гимназия по стопанскоуправление, администрация и услуги \"атанас буров\"" },
                    { 566, "Силистра", true, "Професионална Земеделска Гимназия \"Добруджа\"", "професионална земеделска гимназия \"добруджа\"" },
                    { 567, "Силистра", true, "Професионална Гимназия Полека Промишленост \"Пенчо Славейков\"", "професионална гимназия полека промишленост \"пенчо славейков\"" },
                    { 568, "Силистра", true, "Професионална Гимназия по Производствени Технологии \"Евлогий Георгиев\"", "професионална гимназия по производствени технологии \"евлогий георгиев\"" },
                    { 569, "Силистра", true, "Обединено Общежитие За Средношколци \"Младост\"", "обединено общежитие за средношколци \"младост\"" },
                    { 570, "Ловеч", true, "Професионална Гимназия по Ветеринарна Медицина \"Проф. Д-Р Димитър Димов\"", "професионална гимназия по ветеринарна медицина \"проф. д-р димитър димов\"" },
                    { 571, "Ловеч", true, "Средно Общообразователно Училище \"Тодор Кирков\"", "средно общообразователно училище \"тодор кирков\"" },
                    { 572, "Ловеч", true, "редно Общообразователно Училище \"Св.Климент Охридски\"", "редно общообразователно училище \"св.климент охридски\"" },
                    { 573, "Ловеч", true, "Природо-Математическа Гимназия", "природо-математическа гимназия" },
                    { 574, "Ловеч", true, "Гимназия За Чужди Езици \"Екзарх Йосиф I\"", "гимназия за чужди езици \"екзарх йосиф i\"" },
                    { 575, "Ловеч", true, "Професионална Гимназия по Кожарство, Облекло и Химични Технологии \"Марийка и Маринчо Караконови\"", "професионална гимназия по кожарство, облекло и химични технологии \"марийка и маринчо караконови\"" },
                    { 576, "Ловеч", true, "Професионална Гимназия по Икономика, Търговия и Услуги", "професионална гимназия по икономика, търговия и услуги" },
                    { 577, "Ловеч", true, "Средно Общообразователно Училище \"Панайот Пипков\"", "средно общообразователно училище \"панайот пипков\"" }
                });

            migrationBuilder.InsertData(
                table: "Schools",
                columns: new[] { "Id", "City", "IsActive", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { 578, "Ловеч", true, "Професионална Гимназия по Механоелектротехника", "професионална гимназия по механоелектротехника" },
                    { 579, "Дупница", true, "Средно Общообразователно Училище \"Св. Паисий Хилендарски\"", "средно общообразователно училище \"св. паисий хилендарски\"" },
                    { 580, "Дупница", true, "Гимназия \"Христо Ботев\"", "гимназия \"христо ботев\"" },
                    { 581, "Дупница", true, "Вечерно Средно Общообразователно Училище \"Димчо Дебелянов\"", "вечерно средно общообразователно училище \"димчо дебелянов\"" },
                    { 582, "Дупница", true, "Професионална Гимназия по Облекло и Стопанско Управление", "професионална гимназия по облекло и стопанско управление" },
                    { 583, "Дупница", true, "Професионална Гимназия по Транспорт", "професионална гимназия по транспорт" },
                    { 584, "Дупница", true, "Професионална Гимназия \"Акад. Сергей П. Корольов\"", "професионална гимназия \"акад. сергей п. корольов\"" },
                    { 585, "Дупница", true, "Професионална Гимназия по Хранително - Вкусови и Химични Технологии", "професионална гимназия по хранително - вкусови и химични технологии" },
                    { 586, "Разград", true, "Професионална Техническа Гимназия \"Шандор Петьофи\"", "професионална техническа гимназия \"шандор петьофи\"" },
                    { 587, "Разград", true, "Професионална Гимназия по Химични Технологии и Биотехнологии \"Мария Кюри\"", "професионална гимназия по химични технологии и биотехнологии \"мария кюри\"" },
                    { 588, "Разград", true, "Природо-математическа Гимназия \"Акад.Никола Обрешков\"", "природо-математическа гимназия \"акад.никола обрешков\"" },
                    { 589, "Разград", true, "Професионална Гимназия по Икономика \"Робер Шуман\"", "професионална гимназия по икономика \"робер шуман\"" },
                    { 590, "Разград", true, "Професионална Гимназия по Селско Стопанство и Хранително-Вкусови Технологии \"Ангел Кънчев\"", "професионална гимназия по селско стопанство и хранително-вкусови технологии \"ангел кънчев\"" },
                    { 591, "Разград", true, "Професионална Гимназия по Транспорт и Строителство \"Христо Смирненски\"", "професионална гимназия по транспорт и строителство \"христо смирненски\"" },
                    { 592, "Разград", true, "Гимназия с Преподаване на Чужди Езици \"Екзарх Йосиф\"", "гимназия с преподаване на чужди езици \"екзарх йосиф\"" },
                    { 593, "Разград", true, "Средно Общообразователно Училище \"Христо Ботев\"", "средно общообразователно училище \"христо ботев\"" },
                    { 594, "Разград", true, "Професионална Гимназия по Облекло \"Станка Николица Спасо-Еленина\"", "професионална гимназия по облекло \"станка николица спасо-еленина\"" },
                    { 595, "Разград", true, "Общежитие За Средношколци Гр. Разград", "общежитие за средношколци гр. разград" },
                    { 596, "Разград", true, "Средно Общообразователно Училище \"Цветан Радославов\"", "средно общообразователно училище \"цветан радославов\"" },
                    { 597, "Разград", true, "Средно Общообразователноучилище \"Николай Катранов\"", "средно общообразователноучилище \"николай катранов\"" },
                    { 598, "Разград", true, "Държавна Търговска Гимназия \"Димитър Хадживасилев\"", "държавна търговска гимназия \"димитър хадживасилев\"" },
                    { 599, "Разград", true, "Професионална Гимназия \"Проф. Д-Р Асен Златаров\"", "професионална гимназия \"проф. д-р асен златаров\"" },
                    { 600, "Разград", true, "Професионална Гимназия по Лека Промишленост и Строителство", "професионална гимназия по лека промишленост и строителство" },
                    { 601, "Разград", true, "Средно Общообразователно Училище \"Алеко Константинов\"", "средно общообразователно училище \"алеко константинов\"" },
                    { 602, "Разград", true, "Средно Общообразователно Училище \"Димитър Благоев\"", "средно общообразователно училище \"димитър благоев\"" },
                    { 603, "Горна Оряховица", true, "Професионална Техническа Гимназия \"Васил Левски\"", "професионална техническа гимназия \"васил левски\"" },
                    { 604, "Горна Оряховица", true, "Професионална Гимназия по Лека Промишленост и Икономика \"Атанас Буров\"", "професионална гимназия по лека промишленост и икономика \"атанас буров\"" },
                    { 605, "Горна Оряховица", true, "Средно Общообразователно Училище \"Георги Измирлиев\"", "средно общообразователно училище \"георги измирлиев\"" },
                    { 606, "Горна Оряховица", true, "Средно Общообразователно Училище \"Вичо Грънчаров\"", "средно общообразователно училище \"вичо грънчаров\"" },
                    { 607, "Горна Оряховица", true, "Професионална Гимназия по Електротехника и Електроника \"Михайло Василиевич Ломоносов\"", "професионална гимназия по електротехника и електроника \"михайло василиевич ломоносов\"" },
                    { 608, "Горна Оряховица", true, "Професионална Гимназия по Хранителни Технологии \"Проф.Д-Р Асен Златаров\"", "професионална гимназия по хранителни технологии \"проф.д-р асен златаров\"" },
                    { 609, "Горна Оряховица", true, "Професионална Гимназия по Железопътен Транспорт \"Н.Й.Вапцаров\"", "професионална гимназия по железопътен транспорт \"н.й.вапцаров\"" },
                    { 611, "Смолян", true, "Гимназия с Преподаване на Чужди Езици \"Иван Вазов\"", "гимназия с преподаване на чужди езици \"иван вазов\"" },
                    { 612, "Смолян", true, "Професионална Гимназия по Икономика \"Карл Маркс\"", "професионална гимназия по икономика \"карл маркс\"" },
                    { 613, "Смолян", true, "Природоматематическа Гимназия \"Васил Левски\"", "природоматематическа гимназия \"васил левски\"" },
                    { 614, "Смолян", true, "Средно Общообразователно Училище \"Отец Паисий\"", "средно общообразователно училище \"отец паисий\"" },
                    { 615, "Смолян", true, "Професионална Гимназия Потехника и Технологии \"Христо Ботев\"", "професионална гимназия потехника и технологии \"христо ботев\"" },
                    { 616, "Смолян", true, "Професионална Гимназия по Строителство \"Никола Вапцаров\"", "професионална гимназия по строителство \"никола вапцаров\"" },
                    { 617, "Смолян", true, "Професионална Гимназия по Туризъм", "професионална гимназия по туризъм" },
                    { 618, "Смолян", true, "Частна Професионална Гимназия по Управление на Туризма \"Константин Фотинов\"", "частна професионална гимназия по управление на туризма \"константин фотинов\"" },
                    { 619, "Петрич", true, "Професионална Гимназия по Механоелектротехника \"Юрий Гагарин\"", "професионална гимназия по механоелектротехника \"юрий гагарин\"" },
                    { 620, "Петрич", true, "Професионална Гимназия по Икономика и Туризъм \"Проф. Д-Р Асен Златаров\"", "професионална гимназия по икономика и туризъм \"проф. д-р асен златаров\"" }
                });

            migrationBuilder.InsertData(
                table: "Schools",
                columns: new[] { "Id", "City", "IsActive", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { 621, "Петрич", true, "Средно Общообразователно Училище \"Никола Йонков Вапцаров\"", "средно общообразователно училище \"никола йонков вапцаров\"" },
                    { 622, "Петрич", true, "Гимназия \"Пейо К. Яворов\"", "гимназия \"пейо к. яворов\"" },
                    { 623, "Петрич", true, "Средно Общообразователно Училище \"Антон Попов\"", "средно общообразователно училище \"антон попов\"" },
                    { 624, "Петрич", true, "Професионална Гимназия по Лека Промишленост \"А.А. - Малчика\"", "професионална гимназия по лека промишленост \"а.а. - малчика\"" },
                    { 625, "Самоков", true, "Професионална Гимназия по Туризъм", "професионална гимназия по туризъм" },
                    { 626, "Самоков", true, "Профилирана Гимназия \"Константин Фотинов\"", "профилирана гимназия \"константин фотинов\"" },
                    { 627, "Самоков", true, "Професионална Техническа Гимназия \"Никола Й. Вапцаров\"", "професионална техническа гимназия \"никола й. вапцаров\"" },
                    { 628, "Самоков", true, "Средно Общообразователно Училище \"Отец Паисий\"", "средно общообразователно училище \"отец паисий\"" },
                    { 629, "Велинград", true, "Професионална Гимназия по Горско Стопанство \"Христо Ботев\"", "професионална гимназия по горско стопанство \"христо ботев\"" },
                    { 630, "Велинград", true, "Средно Общообразователно Училище \"Васил Левски\"", "средно общообразователно училище \"васил левски\"" },
                    { 631, "Велинград", true, "Средно Общообразователно Училище \"Св. Св. Кирил и Методий\"", "средно общообразователно училище \"св. св. кирил и методий\"" },
                    { 632, "Велинград", true, "Професионална Гимназия по Дървообработване \"Иван Вазов\"", "професионална гимназия по дървообработване \"иван вазов\"" },
                    { 633, "Велинград", true, "Професионална Гимназия по Икономика и Туризъм \"Алеко Константинов\"", "професионална гимназия по икономика и туризъм \"алеко константинов\"" },
                    { 634, "Карлово", true, "Професионална Гимназия \"Братя Евлогий и Христо Георгиеви\"", "професионална гимназия \"братя евлогий и христо георгиеви\"" },
                    { 635, "Карлово", true, "Професионална Гимназия по Железопътен Транспорт \"Христо Смирненски\"", "професионална гимназия по железопътен транспорт \"христо смирненски\"" },
                    { 636, "Карлово", true, "Средно Общообразователно Училище \"Васил Левски\"", "средно общообразователно училище \"васил левски\"" },
                    { 637, "Карлово", true, "Средно Общообразователно Училище \"Христо Проданов\"", "средно общообразователно училище \"христо проданов\"" },
                    { 638, "Нова Загора", true, "Средно Общообразователно Училище \"Христо Ботев\"", "средно общообразователно училище \"христо ботев\"" },
                    { 639, "Нова Загора", true, " Средно Общообразователно Училище \"Иван Вазов\"", " средно общообразователно училище \"иван вазов\"" },
                    { 640, "Нова Загора", true, "Професионална Гимназия по Селско Стопанство", "професионална гимназия по селско стопанство" },
                    { 641, "Нова Загора", true, "Професионална Гимназия по Техника и Технологии \"Атанас Димитров\"", "професионална гимназия по техника и технологии \"атанас димитров\"" },
                    { 642, "Троян", true, "Средно Общообразователноучилище \"Васил Левски\"", "средно общообразователноучилище \"васил левски\"" },
                    { 643, "Троян", true, "Средно Общообразователно Училище \"Свети Климент Охридски\"", "средно общообразователно училище \"свети климент охридски\"" },
                    { 644, "Троян", true, "Професионална Гимназия по Механоелектротехника", "професионална гимназия по механоелектротехника" },
                    { 645, "Ботевград", true, "Природо-Математическа Гимназия \"Акад. Проф. Д-р Асен Златаров\"", "природо-математическа гимназия \"акад. проф. д-р асен златаров\"" },
                    { 646, "Ботевград", true, "Професионална Гимназия по Техника и Мениджмънт \"Христо Ботев\"", "професионална гимназия по техника и мениджмънт \"христо ботев\"" },
                    { 647, "Ботевград", true, "Техническа Професионална Гимназия \"Стамен Панчев\"", "техническа професионална гимназия \"стамен панчев\"" },
                    { 648, "Пещера", true, "Средно Общообразователно Училище \"Свети Климент Охридски\" (Град Пещера)", "средно общообразователно училище \"свети климент охридски\" (град пещера)" },
                    { 649, "Пещера", true, "Професионална Гимназия по Хранително Вкусови Технологии \"Атанас Ченгелев\"", "професионална гимназия по хранително вкусови технологии \"атанас ченгелев\"" },
                    { 650, "Пещера", true, "Професионална Гимназия по Лека Промишленост и Машиностроене \"Васил Левски\"", "професионална гимназия по лека промишленост и машиностроене \"васил левски\"" },
                    { 651, "Харманли", true, "Професионална Гимназия по Електропромишленост и Текстил \"Захари Стоянов\"", "професионална гимназия по електропромишленост и текстил \"захари стоянов\"" },
                    { 652, "Харманли", true, "Средно Общообразователно Училище \"Неофит Рилски\"", "средно общообразователно училище \"неофит рилски\"" },
                    { 653, "Карнобат", true, "Средно Общообразователно Училище \"Св. Св. Кирил и Методий\"", "средно общообразователно училище \"св. св. кирил и методий\"" },
                    { 654, "Карнобат", true, "Средно Общообразователно Училище \"Христо Ботев\"", "средно общообразователно училище \"христо ботев\"" },
                    { 655, "Карнобат", true, "Професионална Гимназия по Селско Стопанство", "професионална гимназия по селско стопанство" },
                    { 656, "Карнобат", true, "Професионална Гимназия по Облекло", "професионална гимназия по облекло" },
                    { 657, "Свиленград", true, "Средно Общообразователно Училище \"Д-р Петър Берон\"", "средно общообразователно училище \"д-р петър берон\"" },
                    { 658, "Свиленград", true, "Професионална Гимназия по Селско Стопанство и Икономика \"Христо Ботев\"", "професионална гимназия по селско стопанство и икономика \"христо ботев\"" },
                    { 659, "Перник", true, "Професионална Гимназия по Техника и Строителство \"Арх.Йордан Миланов\"", "професионална гимназия по техника и строителство \"арх.йордан миланов\"" },
                    { 660, "Ямбол", true, "Професионална Техническа Гимназия \"Иван Райнов\"", "професионална техническа гимназия \"иван райнов\"" },
                    { 661, "Кюстендил", true, "Професионална Гимназия по Селско Стопанство \"Свети Климент Охридски\"", "професионална гимназия по селско стопанство \"свети климент охридски\"" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "e66d730b-bcf1-41b5-b7e0-3e66056e61d9", "023bafc9-8b7e-4fbd-bb06-2b178fe8ae8b" },
                    { "0f761db2-ab55-416c-83b9-70abded3d908", "789061a9-edaa-4a00-9e09-add6a20c8288" },
                    { "fe750b82-6fe9-472c-bdc5-61f5433d429e", "7decfb7d-d2df-40a2-a449-dcec04eb091a" },
                    { "71281cf3-9730-4d7e-acbb-213edee8291c", "9c7f55cd-f0ae-405e-b520-6e1ccc448fcc" }
                });

            migrationBuilder.InsertData(
                table: "MonUsers",
                columns: new[] { "Id", "IsActive", "UserId" },
                values: new object[] { 1, true, "7decfb7d-d2df-40a2-a449-dcec04eb091a" });

            migrationBuilder.InsertData(
                table: "SectionsOfCurricular",
                columns: new[] { "Id", "IsActive", "ModuleOfCurricularId", "Title" },
                values: new object[,]
                {
                    { 1, true, 1, "Въведение" },
                    { 2, true, 1, "Програмиране на C#" },
                    { 3, true, 1, "Обектно-ориентиран подход" },
                    { 4, true, 1, "Графичен интергейс" },
                    { 5, true, 1, "Още за обектно-ориентирания подход" },
                    { 6, true, 2, "Въведение" },
                    { 7, true, 2, "Структури от данни" },
                    { 8, true, 2, "Абстрактни типове" },
                    { 9, true, 2, "Комбинаторни структури" },
                    { 10, true, 2, "Нелинейни и други АТ" },
                    { 11, true, 2, "Разработване на проект" },
                    { 12, true, 3, "Въведение" },
                    { 13, true, 3, "Релационен модел на Бази от данни" },
                    { 14, true, 3, "Система за управление на Бази от данни" },
                    { 15, true, 3, "Интегриране на Бази от данни в ИС" },
                    { 16, true, 4, "Сървър за база от данни" },
                    { 17, true, 4, "Работа по проекти" },
                    { 18, true, 4, "SQL SERVER със C#" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Grade", "IsActive", "SchoolId", "Speciality", "UserId" },
                values: new object[] { 1, 12, true, 152, "Приложен програмист", "023bafc9-8b7e-4fbd-bb06-2b178fe8ae8b" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Experience", "IsActive", "SchoolId", "Status", "Subject", "UserId" },
                values: new object[] { 1, 12, true, 289, "Waiting", "Информатика", "9c7f55cd-f0ae-405e-b520-6e1ccc448fcc" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "Content", "IsActive", "SectionOfCurricularId", "TeacherId", "Title" },
                values: new object[,]
                {
                    { 1, "", true, 1, null, "Компютърът" },
                    { 2, "", true, 1, null, "Езици за програмиране" },
                    { 3, "", true, 1, null, "Инструменти и IDE" },
                    { 4, "", true, 1, null, "IDE Visual Studio" },
                    { 5, "", true, 2, null, "Елементи на програмата" },
                    { 6, "", true, 2, null, "Основни типове операции и оператори" },
                    { 7, "", true, 2, null, "Изчислителни процеси. Линейни процеси" },
                    { 8, "", true, 2, null, "Линейни изчислителни процеси. Упражнение" },
                    { 9, "", true, 2, null, "Сравнения и логически операции" },
                    { 10, "", true, 2, null, "Разклонени изчислителни процеси" },
                    { 11, "", true, 2, null, "Циклични изчислителни процеси" },
                    { 12, "", true, 2, null, "Оператори за цикъл с условие" },
                    { 13, "", true, 2, null, "Оператори за цикъл. Упражнение" },
                    { 14, "", true, 3, null, "Обекти и класове от обекти" },
                    { 15, "", true, 3, null, "Класове" },
                    { 16, "", true, 3, null, "Клас с контролирани атрибути" },
                    { 17, "", true, 3, null, "Функции и методи" },
                    { 18, "", true, 3, null, "Конструктори" },
                    { 19, "", true, 3, null, "Предаване на аргументи" },
                    { 20, "", true, 3, null, "Упражнение" },
                    { 21, "", true, 4, null, "Елементи на графичние интерфейс" },
                    { 22, "", true, 4, null, "Графични компоненти" },
                    { 23, "", true, 4, null, "Упражнение" },
                    { 24, "", true, 4, null, "Упражнение" },
                    { 25, "", true, 4, null, "Агрегатни типове" },
                    { 26, "", true, 4, null, "Файлове" },
                    { 27, "", true, 4, null, "Четене на обекти от файл" },
                    { 28, "", true, 5, null, "Документиране на клас. Сериализация" },
                    { 29, "", true, 5, null, "Капсулиране. Статични атрибути и методи" },
                    { 30, "", true, 5, null, "Йерархия от класове" },
                    { 31, "", true, 5, null, "Полиморфизъм" },
                    { 32, "", true, 5, null, "Абстракция класове. Интерфейси" },
                    { 33, "", true, 5, null, "Изключения" },
                    { 34, "", true, 12, null, "Информация и данни" },
                    { 35, "", true, 12, null, "Информационни системи и процеси" },
                    { 36, "", true, 12, null, "Файлов подход и подход с бази от данни" },
                    { 37, "", true, 12, null, "Упражнение" },
                    { 38, "", true, 13, null, "Множества и релации" },
                    { 39, "", true, 13, null, "Релационна база от данни" },
                    { 40, "", true, 13, null, "Операции с релации" },
                    { 41, "", true, 13, null, "Типове данни с релации" },
                    { 42, "", true, 13, null, "Типове данни. Ключове" }
                });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "Content", "IsActive", "SectionOfCurricularId", "TeacherId", "Title" },
                values: new object[,]
                {
                    { 43, "", true, 13, null, "Нормализация" },
                    { 44, "", true, 13, null, "Модел обект-взаимодействие" },
                    { 45, "", true, 13, null, "Нива на абстракция. Аномалии" },
                    { 46, "", true, 13, null, "Проектиране на БД. Упражнение" },
                    { 47, "", true, 14, null, "Програмата MS Access" },
                    { 48, "", true, 14, null, "Езикът SQL. Заявки" },
                    { 49, "", true, 14, null, "Заявка SELECT" },
                    { 50, "", true, 14, null, "Клаузите ORDER BY и GROUP BY" },
                    { 51, "", true, 14, null, "Екранни форми. Контрол на данните" },
                    { 52, "", true, 14, null, "Търсене на данни" },
                    { 53, "", true, 14, null, "Създаване и редактиране на таблици със SQL" },
                    { 54, "", true, 14, null, "Упражнение" },
                    { 55, "", true, 14, null, "Отчети" },
                    { 56, "", true, 14, null, "Връзки между таблиците. Съединиение" },
                    { 57, "", true, 14, null, "Влагане на заявки" },
                    { 58, "", true, 14, null, "Упражнение" },
                    { 59, "", true, 15, null, "Интегриране на БД в MS Access" },
                    { 60, "", true, 15, null, "Интегриране на БД със C#" },
                    { 61, "", true, 15, null, "Упражнение" },
                    { 62, "", true, 6, null, "Алгоритми" },
                    { 63, "", true, 6, null, "UML-диаграми упражнение" },
                    { 64, "", true, 6, null, "Сложност на алгоритми" },
                    { 65, "", true, 6, null, "Обектно-ориентирано програмиране - преговор" },
                    { 66, "", true, 6, null, "Реализация на алгоритми чрез методи" },
                    { 67, "", true, 6, null, "Рекурсия и интеграция" },
                    { 68, "", true, 6, null, "Сложност на програми" },
                    { 69, "", true, 7, null, "Едномерен масив - преговор" },
                    { 70, "", true, 7, null, "Сортиране на масив" },
                    { 71, "", true, 7, null, "Работа със сортирани масиви" },
                    { 72, "", true, 7, null, "Сортиране на масив" },
                    { 73, "", true, 7, null, "Работа със сортирани масиви" },
                    { 74, "", true, 7, null, "Низове" },
                    { 75, "", true, 7, null, "Масиви от знаци" },
                    { 76, "", true, 7, null, "Многомерни масиви" },
                    { 77, "", true, 8, null, "Основни понятия" },
                    { 78, "", true, 8, null, "Вградени АТ в C#" },
                    { 79, "", true, 8, null, "Списъци" },
                    { 80, "", true, 8, null, "Опашки" },
                    { 81, "", true, 8, null, "Стек" },
                    { 82, "", true, 8, null, "Упражнение" },
                    { 83, "", true, 9, null, "Графи" },
                    { 84, "", true, 9, null, "Дървета" }
                });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "Content", "IsActive", "SectionOfCurricularId", "TeacherId", "Title" },
                values: new object[,]
                {
                    { 85, "", true, 9, null, "Обхождане на графи" },
                    { 86, "", true, 9, null, "Най-къс път в граф" },
                    { 87, "", true, 9, null, "Хеш-таблица. Речник" },
                    { 88, "", true, 10, null, "Работа по проект" },
                    { 89, "", true, 10, null, "Примерни проекти" },
                    { 90, "", true, 16, null, "Информационни системи и бази от данни" },
                    { 91, "", true, 16, null, "Упражнение - преговор" },
                    { 92, "", true, 16, null, "Сървър база от данни" },
                    { 93, "", true, 16, null, "Таблици" },
                    { 94, "", true, 16, null, "Въвеждане на данни" },
                    { 95, "", true, 16, null, "Езикът SQL - преговор с допълнение" },
                    { 96, "", true, 16, null, "Създаване н=и изпълнение на заявки" },
                    { 97, "", true, 16, null, "Съхранени процедури" },
                    { 98, "", true, 16, null, "Още за съхранените процедури" },
                    { 99, "", true, 16, null, "Подържане на база от данни" },
                    { 100, "", true, 16, null, "Клиентът Azure Data Studio" },
                    { 101, "", true, 16, null, "Упражнение" },
                    { 102, "", true, 17, null, "Фази при разработване на проекти" },
                    { 103, "", true, 17, null, "Екип, документиране и защита на проекти" },
                    { 104, "", true, 18, null, "Езикът C# - преговор" },
                    { 105, "", true, 18, null, "Свързване с базата данни" },
                    { 106, "", true, 18, null, "Четене от база данни" },
                    { 107, "", true, 18, null, "Приложение с графичен интерфейс" },
                    { 108, "", true, 18, null, "Редактиране на данни" },
                    { 109, "", true, 18, null, "Упражнение" },
                    { 110, "", true, 18, null, "Интегриране с лента от менюта" },
                    { 111, "", true, 18, null, "Още функционалност в ИС УЧИСЕ" }
                });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "Id", "Content", "ExerciseId", "IsActive", "SectionOfCurricularId", "Title" },
                values: new object[,]
                {
                    { 1, "", 1, true, 1, "Компютърът" },
                    { 2, "", 2, true, 1, "Езици за програмиране" },
                    { 3, "", 3, true, 1, "Инструменти и IDE" },
                    { 4, "", 4, true, 1, "IDE Visual Studio" },
                    { 5, "", 5, true, 2, "Елементи на програмата" },
                    { 6, "", 6, true, 2, "Основни типове операции и оператори" },
                    { 7, "", 7, true, 2, "Изчислителни процеси. Линейни процеси" },
                    { 8, "", 8, true, 2, "Линейни изчислителни процеси. Упражнение" },
                    { 9, "", 9, true, 2, "Сравнения и логически операции" },
                    { 10, "", 10, true, 2, "Разклонени изчислителни процеси" },
                    { 11, "", 11, true, 2, "Циклични изчислителни процеси" },
                    { 12, "", 12, true, 2, "Оператори за цикъл с условие" },
                    { 13, "", 13, true, 2, "Оператори за цикъл. Упражнение" },
                    { 14, "", 14, true, 3, "Обекти и класове от обекти" },
                    { 15, "", 15, true, 3, "Класове" },
                    { 16, "", 16, true, 3, "Клас с контролирани атрибути" },
                    { 17, "", 17, true, 3, "Функции и методи" },
                    { 18, "", 18, true, 3, "Конструктори" },
                    { 19, "", 19, true, 3, "Предаване на аргументи" },
                    { 20, "", 20, true, 3, "Упражнение" },
                    { 21, "", 21, true, 4, "Елементи на графичние интерфейс" },
                    { 22, "", 22, true, 4, "Графични компоненти" },
                    { 23, "", 23, true, 4, "Упражнение" },
                    { 24, "", 24, true, 4, "Упражнение" },
                    { 25, "", 25, true, 4, "Агрегатни типове" },
                    { 26, "", 26, true, 4, "Файлове" },
                    { 27, "", 27, true, 4, "Четене на обекти от файл" },
                    { 28, "", 28, true, 5, "Документиране на клас. Сериализация" },
                    { 29, "", 29, true, 5, "Капсулиране. Статични атрибути и методи" },
                    { 30, "", 30, true, 5, "Йерархия от класове" },
                    { 31, "", 31, true, 5, "Полиморфизъм" },
                    { 32, "", 32, true, 5, "Абстракция класове. Интерфейси" },
                    { 33, "", 33, true, 5, "Изключения" },
                    { 34, "", 34, true, 12, "Информация и данни" },
                    { 35, "", 35, true, 12, "Информационни системи и процеси" },
                    { 36, "", 36, true, 12, "Файлов подход и подход с бази от данни" },
                    { 37, "", 37, true, 12, "Упражнение" },
                    { 38, "", 38, true, 13, "Множества и релации" },
                    { 39, "", 39, true, 13, "Релационна база от данни" },
                    { 40, "", 40, true, 13, "Операции с релации" },
                    { 41, "", 41, true, 13, "Типове данни с релации" },
                    { 42, "", 42, true, 13, "Типове данни. Ключове" }
                });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "Id", "Content", "ExerciseId", "IsActive", "SectionOfCurricularId", "Title" },
                values: new object[,]
                {
                    { 43, "", 43, true, 13, "Нормализация" },
                    { 44, "", 44, true, 13, "Модел обект-взаимодействие" },
                    { 45, "", 45, true, 13, "Нива на абстракция. Аномалии" },
                    { 46, "", 46, true, 13, "Проектиране на БД. Упражнение" },
                    { 47, "", 47, true, 14, "Програмата MS Access" },
                    { 48, "", 48, true, 14, "Езикът SQL. Заявки" },
                    { 49, "", 49, true, 14, "Заявка SELECT" },
                    { 50, "", 50, true, 14, "Клаузите ORDER BY и GROUP BY" },
                    { 51, "", 51, true, 14, "Екранни форми. Контрол на данните" },
                    { 52, "", 52, true, 14, "Търсене на данни" },
                    { 53, "", 53, true, 14, "Създаване и редактиране на таблици със SQL" },
                    { 54, "", 54, true, 14, "Упражнение" },
                    { 55, "", 55, true, 14, "Отчети" },
                    { 56, "", 56, true, 14, "Връзки между таблиците. Съединиение" },
                    { 57, "", 57, true, 14, "Влагане на заявки" },
                    { 58, "", 58, true, 14, "Упражнение" },
                    { 59, "", 59, true, 15, "Интегриране на БД в MS Access" },
                    { 60, "", 60, true, 15, "Интегриране на БД със C#" },
                    { 61, "", 61, true, 15, "Упражнение" },
                    { 62, "", 62, true, 6, "Алгоритми" },
                    { 63, "", 63, true, 6, "UML-диаграми упражнение" },
                    { 64, "", 64, true, 6, "Сложност на алгоритми" },
                    { 65, "", 65, true, 6, "Обектно-ориентирано програмиране - преговор" },
                    { 66, "", 66, true, 6, "Реализация на алгоритми чрез методи" },
                    { 67, "", 67, true, 6, "Рекурсия и интеграция" },
                    { 68, "", 68, true, 6, "Сложност на програми" },
                    { 69, "", 69, true, 7, "Едномерен масив - преговор" },
                    { 70, "", 70, true, 7, "Сортиране на масив" },
                    { 71, "", 71, true, 7, "Работа със сортирани масиви" },
                    { 72, "", 72, true, 7, "Сортиране на масив" },
                    { 73, "", 73, true, 7, "Работа със сортирани масиви" },
                    { 74, "", 74, true, 7, "Низове" },
                    { 75, "", 75, true, 7, "Масиви от знаци" },
                    { 76, "", 76, true, 7, "Многомерни масиви" },
                    { 77, "", 77, true, 8, "Основни понятия" },
                    { 78, "", 78, true, 8, "Вградени АТ в C#" },
                    { 79, "", 79, true, 8, "Списъци" },
                    { 80, "", 80, true, 8, "Опашки" },
                    { 81, "", 81, true, 8, "Стек" },
                    { 82, "", 82, true, 8, "Упражнение" },
                    { 83, "", 83, true, 9, "Графи" },
                    { 84, "", 84, true, 9, "Дървета" }
                });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "Id", "Content", "ExerciseId", "IsActive", "SectionOfCurricularId", "Title" },
                values: new object[,]
                {
                    { 85, "", 85, true, 9, "Обхождане на графи" },
                    { 86, "", 86, true, 9, "Най-къс път в граф" },
                    { 87, "", 87, true, 9, "Хеш-таблица. Речник" },
                    { 88, "", 88, true, 10, "Работа по проект" },
                    { 89, "", 89, true, 10, "Примерни проекти" },
                    { 90, "", 90, true, 16, "Информационни системи и бази от данни" },
                    { 91, "", 91, true, 16, "Упражнение - преговор" },
                    { 92, "", 92, true, 16, "Сървър база от данни" },
                    { 93, "", 93, true, 16, "Таблици" },
                    { 94, "", 94, true, 16, "Въвеждане на данни" },
                    { 95, "", 95, true, 16, "Езикът SQL - преговор с допълнение" },
                    { 96, "", 96, true, 16, "Създаване н=и изпълнение на заявки" },
                    { 97, "", 97, true, 16, "Съхранени процедури" },
                    { 98, "", 98, true, 16, "Още за съхранените процедури" },
                    { 99, "", 99, true, 16, "Подържане на база от данни" },
                    { 100, "", 100, true, 16, "Клиентът Azure Data Studio" },
                    { 101, "", 101, true, 16, "Упражнение" },
                    { 102, "", 102, true, 17, "Фази при разработване на проекти" },
                    { 103, "", 103, true, 17, "Екип, документиране и защита на проекти" },
                    { 104, "", 104, true, 18, "Езикът C# - преговор" },
                    { 105, "", 105, true, 18, "Свързване с базата данни" },
                    { 106, "", 106, true, 18, "Четене от база данни" },
                    { 107, "", 107, true, 18, "Приложение с графичен интерфейс" },
                    { 108, "", 108, true, 18, "Редактиране на данни" },
                    { 109, "", 109, true, 18, "Упражнение" },
                    { 110, "", 110, true, 18, "Интегриране с лента от менюта" },
                    { 111, "", 111, true, 18, "Още функционалност в ИС УЧИСЕ" }
                });

            migrationBuilder.InsertData(
                table: "LessonMonUser",
                columns: new[] { "LessonId", "MonUserId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 3, 1 },
                    { 4, 1 },
                    { 5, 1 },
                    { 6, 1 },
                    { 7, 1 },
                    { 8, 1 },
                    { 9, 1 },
                    { 10, 1 },
                    { 11, 1 },
                    { 12, 1 },
                    { 13, 1 },
                    { 14, 1 },
                    { 15, 1 },
                    { 16, 1 },
                    { 17, 1 },
                    { 18, 1 },
                    { 19, 1 },
                    { 20, 1 },
                    { 21, 1 },
                    { 22, 1 },
                    { 23, 1 },
                    { 24, 1 },
                    { 25, 1 },
                    { 26, 1 },
                    { 27, 1 },
                    { 28, 1 },
                    { 29, 1 },
                    { 30, 1 },
                    { 31, 1 },
                    { 32, 1 },
                    { 33, 1 },
                    { 34, 1 },
                    { 35, 1 },
                    { 36, 1 },
                    { 37, 1 },
                    { 38, 1 },
                    { 39, 1 },
                    { 40, 1 },
                    { 41, 1 },
                    { 42, 1 }
                });

            migrationBuilder.InsertData(
                table: "LessonMonUser",
                columns: new[] { "LessonId", "MonUserId" },
                values: new object[,]
                {
                    { 43, 1 },
                    { 44, 1 },
                    { 45, 1 },
                    { 46, 1 },
                    { 47, 1 },
                    { 48, 1 },
                    { 49, 1 },
                    { 50, 1 },
                    { 51, 1 },
                    { 52, 1 },
                    { 53, 1 },
                    { 54, 1 },
                    { 55, 1 },
                    { 56, 1 },
                    { 57, 1 },
                    { 58, 1 },
                    { 59, 1 },
                    { 60, 1 },
                    { 61, 1 },
                    { 62, 1 },
                    { 63, 1 },
                    { 64, 1 },
                    { 65, 1 },
                    { 66, 1 },
                    { 67, 1 },
                    { 68, 1 },
                    { 69, 1 },
                    { 70, 1 },
                    { 71, 1 },
                    { 72, 1 },
                    { 73, 1 },
                    { 74, 1 },
                    { 75, 1 },
                    { 76, 1 },
                    { 77, 1 },
                    { 78, 1 },
                    { 79, 1 },
                    { 80, 1 },
                    { 81, 1 },
                    { 82, 1 },
                    { 83, 1 },
                    { 84, 1 }
                });

            migrationBuilder.InsertData(
                table: "LessonMonUser",
                columns: new[] { "LessonId", "MonUserId" },
                values: new object[,]
                {
                    { 85, 1 },
                    { 86, 1 },
                    { 87, 1 },
                    { 88, 1 },
                    { 89, 1 },
                    { 90, 1 },
                    { 91, 1 },
                    { 92, 1 },
                    { 93, 1 },
                    { 94, 1 },
                    { 95, 1 },
                    { 96, 1 },
                    { 97, 1 },
                    { 98, 1 },
                    { 99, 1 },
                    { 100, 1 },
                    { 101, 1 },
                    { 102, 1 },
                    { 103, 1 },
                    { 104, 1 },
                    { 105, 1 },
                    { 106, 1 },
                    { 107, 1 },
                    { 108, 1 },
                    { 109, 1 },
                    { 110, 1 },
                    { 111, 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ExerciseMaterials_ExerciseId",
                table: "ExerciseMaterials",
                column: "ExerciseId");

            migrationBuilder.CreateIndex(
                name: "IX_ExerciseMaterials_UserId",
                table: "ExerciseMaterials",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Exercises_SectionOfCurricularId",
                table: "Exercises",
                column: "SectionOfCurricularId");

            migrationBuilder.CreateIndex(
                name: "IX_Exercises_TeacherId",
                table: "Exercises",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_ExerciseStudent_StudentsId",
                table: "ExerciseStudent",
                column: "StudentsId");

            migrationBuilder.CreateIndex(
                name: "IX_Images_NewsId",
                table: "Images",
                column: "NewsId");

            migrationBuilder.CreateIndex(
                name: "IX_Images_PostId",
                table: "Images",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_LessonComment_ExerciseId",
                table: "LessonComment",
                column: "ExerciseId");

            migrationBuilder.CreateIndex(
                name: "IX_LessonComment_LessonId",
                table: "LessonComment",
                column: "LessonId");

            migrationBuilder.CreateIndex(
                name: "IX_LessonComment_UserId",
                table: "LessonComment",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_LessonMaterials_LessonId",
                table: "LessonMaterials",
                column: "LessonId");

            migrationBuilder.CreateIndex(
                name: "IX_LessonMaterials_RequestExerciseId",
                table: "LessonMaterials",
                column: "RequestExerciseId");

            migrationBuilder.CreateIndex(
                name: "IX_LessonMaterials_RequestLessonId",
                table: "LessonMaterials",
                column: "RequestLessonId");

            migrationBuilder.CreateIndex(
                name: "IX_LessonMaterials_UserId",
                table: "LessonMaterials",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_LessonMonUser_MonUserId",
                table: "LessonMonUser",
                column: "MonUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Lessons_ExerciseId",
                table: "Lessons",
                column: "ExerciseId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Lessons_SectionOfCurricularId",
                table: "Lessons",
                column: "SectionOfCurricularId");

            migrationBuilder.CreateIndex(
                name: "IX_LessonTeacher_TeachersId",
                table: "LessonTeacher",
                column: "TeachersId");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_UserId",
                table: "Messages",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_MonUsers_UserId",
                table: "MonUsers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_News_MonId",
                table: "News",
                column: "MonId");

            migrationBuilder.CreateIndex(
                name: "IX_NewsComments_UserId",
                table: "NewsComments",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_PostComments_PostId",
                table: "PostComments",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_PostComments_UserId",
                table: "PostComments",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_UserId",
                table: "Posts",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_RequestsExercises_ExerciseId",
                table: "RequestsExercises",
                column: "ExerciseId");

            migrationBuilder.CreateIndex(
                name: "IX_RequestsExercises_TeacherId",
                table: "RequestsExercises",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_RequestsLessons_LessonId",
                table: "RequestsLessons",
                column: "LessonId");

            migrationBuilder.CreateIndex(
                name: "IX_RequestsLessons_TeacherId",
                table: "RequestsLessons",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_SectionsOfCurricular_ModuleOfCurricularId",
                table: "SectionsOfCurricular",
                column: "ModuleOfCurricularId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_SchoolId",
                table: "Students",
                column: "SchoolId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_UserId",
                table: "Students",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_SchoolId",
                table: "Teachers",
                column: "SchoolId");

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_UserId",
                table: "Teachers",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "ExerciseMaterials");

            migrationBuilder.DropTable(
                name: "ExerciseStudent");

            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DropTable(
                name: "LessonComment");

            migrationBuilder.DropTable(
                name: "LessonMaterials");

            migrationBuilder.DropTable(
                name: "LessonMonUser");

            migrationBuilder.DropTable(
                name: "LessonTeacher");

            migrationBuilder.DropTable(
                name: "Messages");

            migrationBuilder.DropTable(
                name: "NewsComments");

            migrationBuilder.DropTable(
                name: "PostComments");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "News");

            migrationBuilder.DropTable(
                name: "RequestsExercises");

            migrationBuilder.DropTable(
                name: "RequestsLessons");

            migrationBuilder.DropTable(
                name: "Posts");

            migrationBuilder.DropTable(
                name: "MonUsers");

            migrationBuilder.DropTable(
                name: "Lessons");

            migrationBuilder.DropTable(
                name: "Exercises");

            migrationBuilder.DropTable(
                name: "SectionsOfCurricular");

            migrationBuilder.DropTable(
                name: "Teachers");

            migrationBuilder.DropTable(
                name: "ModuleOfCurricular");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Schools");
        }
    }
}
