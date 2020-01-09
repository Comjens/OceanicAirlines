using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OceanicAirlines.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Location",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    CreatedTime = table.Column<DateTime>(nullable: false),
                    UpdatedTime = table.Column<DateTime>(nullable: false),
                    Longitude = table.Column<double>(nullable: false),
                    Latitude = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Location", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Shipment",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    CreatedTime = table.Column<DateTime>(nullable: false),
                    UpdatedTime = table.Column<DateTime>(nullable: false),
                    ToId = table.Column<long>(nullable: true),
                    FromId = table.Column<long>(nullable: true),
                    Price = table.Column<double>(nullable: false),
                    NavId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shipment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Shipment_Location_FromId",
                        column: x => x.FromId,
                        principalTable: "Location",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Shipment_Location_ToId",
                        column: x => x.ToId,
                        principalTable: "Location",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Route",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    CreatedTime = table.Column<DateTime>(nullable: false),
                    UpdatedTime = table.Column<DateTime>(nullable: false),
                    FromId = table.Column<long>(nullable: true),
                    ToId = table.Column<long>(nullable: true),
                    Duration = table.Column<double>(nullable: false),
                    Price1 = table.Column<double>(nullable: false),
                    Price2 = table.Column<double>(nullable: false),
                    Price3 = table.Column<double>(nullable: false),
                    ShipmentModelId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Route", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Route_Location_FromId",
                        column: x => x.FromId,
                        principalTable: "Location",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Route_Shipment_ShipmentModelId",
                        column: x => x.ShipmentModelId,
                        principalTable: "Shipment",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Route_Location_ToId",
                        column: x => x.ToId,
                        principalTable: "Location",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ShipmentType",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    CreatedTime = table.Column<DateTime>(nullable: false),
                    UpdatedTime = table.Column<DateTime>(nullable: false),
                    Type = table.Column<string>(nullable: true),
                    Additional = table.Column<double>(nullable: false),
                    Rate = table.Column<double>(nullable: false),
                    ShipmentModelId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShipmentType", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShipmentType_Shipment_ShipmentModelId",
                        column: x => x.ShipmentModelId,
                        principalTable: "Shipment",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Route_FromId",
                table: "Route",
                column: "FromId");

            migrationBuilder.CreateIndex(
                name: "IX_Route_ShipmentModelId",
                table: "Route",
                column: "ShipmentModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Route_ToId",
                table: "Route",
                column: "ToId");

            migrationBuilder.CreateIndex(
                name: "IX_Shipment_FromId",
                table: "Shipment",
                column: "FromId");

            migrationBuilder.CreateIndex(
                name: "IX_Shipment_ToId",
                table: "Shipment",
                column: "ToId");

            migrationBuilder.CreateIndex(
                name: "IX_ShipmentType_ShipmentModelId",
                table: "ShipmentType",
                column: "ShipmentModelId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Route");

            migrationBuilder.DropTable(
                name: "ShipmentType");

            migrationBuilder.DropTable(
                name: "Shipment");

            migrationBuilder.DropTable(
                name: "Location");
        }
    }
}
