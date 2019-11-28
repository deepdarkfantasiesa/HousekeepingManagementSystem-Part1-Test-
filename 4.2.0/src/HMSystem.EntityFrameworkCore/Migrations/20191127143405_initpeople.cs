using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HMSystem.Migrations
{
    public partial class initpeople : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppPersons",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    Name = table.Column<string>(maxLength: 32, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppPersons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ServicePersonalBaseInfo",
                columns: table => new
                {
                    ServicePersonalID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Id = table.Column<int>(nullable: false),
                    ServicePersonalName = table.Column<string>(maxLength: 256, nullable: true),
                    ServicePersonalGender = table.Column<int>(nullable: false),
                    BirthDay = table.Column<DateTime>(nullable: false),
                    Type = table.Column<int>(nullable: false),
                    ServiceRegion = table.Column<string>(maxLength: 256, nullable: true),
                    TelephoneNumber = table.Column<string>(maxLength: 256, nullable: true),
                    SelfIntroduction = table.Column<string>(maxLength: 256, nullable: true),
                    NumberOfRoles = table.Column<int>(nullable: false),
                    IDCard = table.Column<string>(maxLength: 256, nullable: true),
                    Title = table.Column<string>(maxLength: 256, nullable: false),
                    Description = table.Column<string>(maxLength: 65536, nullable: true),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    State = table.Column<byte>(nullable: false),
                    AssignedPersonId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServicePersonalBaseInfo", x => x.ServicePersonalID);
                    table.ForeignKey(
                        name: "FK_ServicePersonalBaseInfo_AppPersons_AssignedPersonId",
                        column: x => x.AssignedPersonId,
                        principalTable: "AppPersons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ServicePersonalBaseInfo_AssignedPersonId",
                table: "ServicePersonalBaseInfo",
                column: "AssignedPersonId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ServicePersonalBaseInfo");

            migrationBuilder.DropTable(
                name: "AppPersons");
        }
    }
}
