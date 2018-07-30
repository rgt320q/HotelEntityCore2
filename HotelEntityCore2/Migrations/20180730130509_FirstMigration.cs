using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelEntityCore2.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Rezervations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Arrivaldate = table.Column<DateTime>(nullable: false),
                    DepartureDate = table.Column<DateTime>(nullable: false),
                    RoomNo = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    TatolDays = table.Column<int>(nullable: false),
                    TotalChildren = table.Column<int>(nullable: false),
                    TotalChildrenWithPrice = table.Column<int>(nullable: false),
                    TotalAdult = table.Column<int>(nullable: false),
                    TotalPersons = table.Column<int>(nullable: false),
                    AccommodationType = table.Column<string>(nullable: true),
                    BoardType = table.Column<string>(nullable: true),
                    Breakfast = table.Column<string>(nullable: true),
                    Lunch = table.Column<string>(nullable: true),
                    Dinner = table.Column<string>(nullable: true),
                    InsertDateTime = table.Column<DateTime>(nullable: false),
                    UpdateDateTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rezervations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Guests",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    SurName = table.Column<string>(nullable: true),
                    GuestEmail = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    BirthDay = table.Column<DateTime>(nullable: false),
                    IdentityType = table.Column<string>(nullable: true),
                    IdentityNumber = table.Column<string>(nullable: true),
                    IdentitySerialNo = table.Column<string>(nullable: true),
                    Gender = table.Column<string>(nullable: true),
                    GuestMartialStatus = table.Column<string>(nullable: true),
                    FatherName = table.Column<string>(nullable: true),
                    MotherName = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    District = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    CarPlate = table.Column<string>(nullable: true),
                    RezervationNote = table.Column<string>(nullable: true),
                    GuestSequenceNo = table.Column<int>(nullable: false),
                    InsertDateTime = table.Column<DateTime>(nullable: false),
                    UpdateDateTime = table.Column<DateTime>(nullable: false),
                    RezervationId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Guests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Guests_Rezervations_RezervationId",
                        column: x => x.RezervationId,
                        principalTable: "Rezervations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DailyAdultPrice = table.Column<double>(nullable: false),
                    DailyGuestPrice = table.Column<double>(nullable: false),
                    ExtrasPrice = table.Column<double>(nullable: false),
                    DiscountPrice = table.Column<double>(nullable: false),
                    ChildPrice = table.Column<double>(nullable: false),
                    TotalPrice = table.Column<double>(nullable: false),
                    RoomPrice = table.Column<double>(nullable: false),
                    BreakfastPrice = table.Column<double>(nullable: false),
                    LunchPrice = table.Column<double>(nullable: false),
                    DinnerPrice = table.Column<double>(nullable: false),
                    TotalChildPrice = table.Column<double>(nullable: false),
                    TotalAccommodationPrice = table.Column<double>(nullable: false),
                    TotalRoomPrice = table.Column<double>(nullable: false),
                    TotalBreakFastPrice = table.Column<double>(nullable: false),
                    TotalLunchPrice = table.Column<double>(nullable: false),
                    TotalDinnerPrice = table.Column<double>(nullable: false),
                    TotalPersonPrice = table.Column<double>(nullable: false),
                    InsertDateTime = table.Column<DateTime>(nullable: false),
                    UpdateDateTime = table.Column<DateTime>(nullable: false),
                    RezervationId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Payments_Rezervations_RezervationId",
                        column: x => x.RezervationId,
                        principalTable: "Rezervations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Guests_RezervationId",
                table: "Guests",
                column: "RezervationId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_RezervationId",
                table: "Payments",
                column: "RezervationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Guests");

            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "Rezervations");
        }
    }
}
