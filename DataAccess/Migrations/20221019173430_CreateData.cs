using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class CreateData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Boats
            migrationBuilder.Sql("INSERT INTO Boats VALUES ('Captain07','Red','2022.10.19','2022.10.19')");
            migrationBuilder.Sql("INSERT INTO Boats VALUES ('Captain34','Blue','2022.10.19','2022.10.19')");
            migrationBuilder.Sql("INSERT INTO Boats VALUES ('Captain35','Black','2022.10.19','2022.10.19')");
            migrationBuilder.Sql("INSERT INTO Boats VALUES ('Captain61','White','2022.10.19','2022.10.19')");

            migrationBuilder.Sql("INSERT INTO Boats VALUES ('Captain42','Red','2022.10.19','2022.10.19')");
            migrationBuilder.Sql("INSERT INTO Boats VALUES ('Captain06','Blue','2022.10.19','2022.10.19')");
            migrationBuilder.Sql("INSERT INTO Boats VALUES ('Captain55','Black','2022.10.19','2022.10.19')");
            migrationBuilder.Sql("INSERT INTO Boats VALUES ('Captain08','White','2022.10.19','2022.10.19')");

            //Buses
            migrationBuilder.Sql("INSERT INTO Buses VALUES ('Ford','Red','2022.10.19','2022.10.19')");
            migrationBuilder.Sql("INSERT INTO Buses VALUES ('Man','Blue','2022.10.19','2022.10.19')");
            migrationBuilder.Sql("INSERT INTO Buses VALUES ('Volkswagen','Black','2022.10.19','2022.10.19')");
            migrationBuilder.Sql("INSERT INTO Buses VALUES ('iveco','White','2022.10.19','2022.10.19')");

            migrationBuilder.Sql("INSERT INTO Buses VALUES ('isuzu','Red','2022.10.19','2022.10.19')");
            migrationBuilder.Sql("INSERT INTO Buses VALUES ('Volvo','Blue','2022.10.19','2022.10.19')");
            migrationBuilder.Sql("INSERT INTO Buses VALUES ('Renault','Black','2022.10.19','2022.10.19')");
            migrationBuilder.Sql("INSERT INTO Buses VALUES ('Hyundai','White','2022.10.19','2022.10.19')");

            //Cars
            migrationBuilder.Sql("INSERT INTO Cars VALUES ('4 teker','Red','Ford','False','2022.10.19','2022.10.19')");
            migrationBuilder.Sql("INSERT INTO Cars VALUES ('4 teker','Blue','Renault','True','2022.10.19','2022.10.19')");
            migrationBuilder.Sql("INSERT INTO Cars VALUES ('4 teker','Black','Volkswagen','False','2022.10.19','2022.10.19')");
            migrationBuilder.Sql("INSERT INTO Cars VALUES ('4 teker','White','Audi','True','2022.10.19','2022.10.19')");

            migrationBuilder.Sql("INSERT INTO Cars VALUES ('4 teker','Red','Bmw','True','2022.10.19','2022.10.19')");
            migrationBuilder.Sql("INSERT INTO Cars VALUES ('4 teker','Blue','Hyundai','False','2022.10.19','2022.10.19')");
            migrationBuilder.Sql("INSERT INTO Cars VALUES ('4 teker','Black','Volvo','True','2022.10.19','2022.10.19')");
            migrationBuilder.Sql("INSERT INTO Cars VALUES ('4 teker','White','Mercedes','False','2022.10.19','2022.10.19')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
