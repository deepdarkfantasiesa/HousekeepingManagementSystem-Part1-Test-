using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HMSystem.Migrations
{
    public partial class InitAllTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CustomerInfo",
                columns: table => new
                {
                    CustomerID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CustomerName = table.Column<string>(maxLength: 256, nullable: true),
                    IDCard = table.Column<string>(maxLength: 256, nullable: true),
                    Region = table.Column<string>(maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerInfo", x => x.CustomerID);
                });

            migrationBuilder.CreateTable(
                name: "ServicePersonalBaseInfo",
                columns: table => new
                {
                    ServicePersonalID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ServicePersonalName = table.Column<string>(maxLength: 256, nullable: true),
                    ServicePersonalGender = table.Column<int>(nullable: false),
                    BirthDay = table.Column<DateTime>(nullable: false),
                    Type = table.Column<int>(nullable: false),
                    ServiceRegion = table.Column<string>(maxLength: 256, nullable: true),
                    TelephoneNumber = table.Column<string>(maxLength: 256, nullable: true),
                    SelfIntroduction = table.Column<string>(maxLength: 256, nullable: true),
                    NumberOfRoles = table.Column<int>(nullable: false),
                    IDCard = table.Column<string>(maxLength: 256, nullable: true),
                    Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServicePersonalBaseInfo", x => x.ServicePersonalID);
                });

            migrationBuilder.CreateTable(
                name: "OrderInfo",
                columns: table => new
                {
                    OrderID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Price = table.Column<decimal>(nullable: false),
                    Assess = table.Column<int>(nullable: false),
                    CustomerID = table.Column<int>(nullable: false),
                    ServicePersonalBaseID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderInfo", x => x.OrderID);
                    table.ForeignKey(
                        name: "FK_OrderInfo_CustomerInfo_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "CustomerInfo",
                        principalColumn: "CustomerID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderInfo_ServicePersonalBaseInfo_ServicePersonalBaseID",
                        column: x => x.ServicePersonalBaseID,
                        principalTable: "ServicePersonalBaseInfo",
                        principalColumn: "ServicePersonalID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ServicePersonalCertificatesInfo",
                columns: table => new
                {
                    CertificatesID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CertificateOfEmployment = table.Column<string>(maxLength: 256, nullable: true),
                    ProfessionalCertificate = table.Column<string>(maxLength: 256, nullable: true),
                    ServicePersonalID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServicePersonalCertificatesInfo", x => x.CertificatesID);
                    table.ForeignKey(
                        name: "FK_ServicePersonalCertificatesInfo_ServicePersonalBaseInfo_ServicePersonalID",
                        column: x => x.ServicePersonalID,
                        principalTable: "ServicePersonalBaseInfo",
                        principalColumn: "ServicePersonalID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WorkRecordInfo",
                columns: table => new
                {
                    WorkRecordID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    StartTime = table.Column<DateTime>(nullable: false),
                    StopTime = table.Column<DateTime>(nullable: false),
                    ServicePersonalID = table.Column<int>(nullable: false),
                    CustomerID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkRecordInfo", x => x.WorkRecordID);
                    table.ForeignKey(
                        name: "FK_WorkRecordInfo_CustomerInfo_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "CustomerInfo",
                        principalColumn: "CustomerID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WorkRecordInfo_ServicePersonalBaseInfo_ServicePersonalID",
                        column: x => x.ServicePersonalID,
                        principalTable: "ServicePersonalBaseInfo",
                        principalColumn: "ServicePersonalID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderInfo_CustomerID",
                table: "OrderInfo",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderInfo_ServicePersonalBaseID",
                table: "OrderInfo",
                column: "ServicePersonalBaseID");

            migrationBuilder.CreateIndex(
                name: "IX_ServicePersonalCertificatesInfo_ServicePersonalID",
                table: "ServicePersonalCertificatesInfo",
                column: "ServicePersonalID");

            migrationBuilder.CreateIndex(
                name: "IX_WorkRecordInfo_CustomerID",
                table: "WorkRecordInfo",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_WorkRecordInfo_ServicePersonalID",
                table: "WorkRecordInfo",
                column: "ServicePersonalID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderInfo");

            migrationBuilder.DropTable(
                name: "ServicePersonalCertificatesInfo");

            migrationBuilder.DropTable(
                name: "WorkRecordInfo");

            migrationBuilder.DropTable(
                name: "CustomerInfo");

            migrationBuilder.DropTable(
                name: "ServicePersonalBaseInfo");
        }
    }
}
