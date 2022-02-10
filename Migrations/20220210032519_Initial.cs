using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CRUDAPI.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    login = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    password = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    email = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    telephone = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    birth_date = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    mother_name = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    status = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    created_at = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    updated_at = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "id", "birth_date", "created_at", "email", "login", "mother_name", "name", "password", "status", "telephone", "updated_at" },
                values: new object[,]
                {
                    { 1, new DateTime(2003, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 10, 3, 25, 19, 824, DateTimeKind.Utc).AddTicks(5908), "LeonorSantosFernandes@teleworm.us", "Theired1995", "Dias", "Leonor", "Eipai7Da6ut", true, "(11) 8703-2327", new DateTime(2022, 2, 10, 3, 25, 19, 824, DateTimeKind.Utc).AddTicks(5909) },
                    { 18, new DateTime(1970, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 10, 3, 25, 19, 824, DateTimeKind.Utc).AddTicks(6006), "EmilySousaFernandes@jourrapide.com", "Awass2000", "Pereira", "Emily", "aV4zooShoo", true, "(16) 7499-9561", new DateTime(2022, 2, 10, 3, 25, 19, 824, DateTimeKind.Utc).AddTicks(6007) },
                    { 17, new DateTime(1972, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 10, 3, 25, 19, 824, DateTimeKind.Utc).AddTicks(6001), "RebecaBarbosaRodrigues@dayrep.com", "Therintord", "Melo", "Rebeca", "Iema8air9Ei", true, "(18) 8674-7184", new DateTime(2022, 2, 10, 3, 25, 19, 824, DateTimeKind.Utc).AddTicks(6001) },
                    { 16, new DateTime(1974, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 10, 3, 25, 19, 824, DateTimeKind.Utc).AddTicks(5995), "DanielSantosRodrigues@rhyta.com", "Magere01", "Almeida", "Daniel", "ahki3rouP", true, "(48) 8394-9490", new DateTime(2022, 2, 10, 3, 25, 19, 824, DateTimeKind.Utc).AddTicks(5996) },
                    { 15, new DateTime(1976, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 10, 3, 25, 19, 824, DateTimeKind.Utc).AddTicks(5990), "LuizFerreiraAlmeida@rhyta.com", "Fourpried2001", "Santos", "Luiz", "Lae8je7zi", true, "(46) 5457-2796", new DateTime(2022, 2, 10, 3, 25, 19, 824, DateTimeKind.Utc).AddTicks(5990) },
                    { 14, new DateTime(1978, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 10, 3, 25, 19, 824, DateTimeKind.Utc).AddTicks(5984), "DaviMeloPinto@jourrapide.com", "Plicaut", "Lima", "Davi", "yaX8Geen8ae", true, "(28) 5722-9255", new DateTime(2022, 2, 10, 3, 25, 19, 824, DateTimeKind.Utc).AddTicks(5985) },
                    { 13, new DateTime(1980, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 10, 3, 25, 19, 824, DateTimeKind.Utc).AddTicks(5979), "RafaelaCarvalhoGoncalves@dayrep.com", "Hicarrim", "Fernandes", "Rafaela", "aehieQu5sh", true, "(43) 3801-6229", new DateTime(2022, 2, 10, 3, 25, 19, 824, DateTimeKind.Utc).AddTicks(5979) },
                    { 12, new DateTime(1982, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 10, 3, 25, 19, 824, DateTimeKind.Utc).AddTicks(5973), "CarolinaGoncalvesLima@dayrep.com", "Hadeard", "Costa", "Carolina", "Dewea3ooxai", true, "(67) 7410-5849", new DateTime(2022, 2, 10, 3, 25, 19, 824, DateTimeKind.Utc).AddTicks(5974) },
                    { 11, new DateTime(1984, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 10, 3, 25, 19, 824, DateTimeKind.Utc).AddTicks(5968), "GiovannaLimaGoncalves@dayrep.com", "Magur2002", "Cavalcanti", "Giovanna", "ieW2eZii", true, "(61) 9269-9311", new DateTime(2022, 2, 10, 3, 25, 19, 824, DateTimeKind.Utc).AddTicks(5968) },
                    { 10, new DateTime(1986, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 10, 3, 25, 19, 824, DateTimeKind.Utc).AddTicks(5962), "KaueCardosoSouza@dayrep.com", "Artagglacte", "Almeida", "Kauê", "Reew7eisu8", true, "11111111111", new DateTime(2022, 2, 10, 3, 25, 19, 824, DateTimeKind.Utc).AddTicks(5962) },
                    { 9, new DateTime(1988, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 10, 3, 25, 19, 824, DateTimeKind.Utc).AddTicks(5956), "EnzoSouzaOliveira@dayrep.com", "Kelin2001", "Oliveira", "Enzo", "EaVohth5", true, "(12) 6637-3409", new DateTime(2022, 2, 10, 3, 25, 19, 824, DateTimeKind.Utc).AddTicks(5957) },
                    { 8, new DateTime(1990, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 10, 3, 25, 19, 824, DateTimeKind.Utc).AddTicks(5951), "RafaelSouzaAzevedo@teleworm.us", "Curtand", "Ferreira", "Rafael", "auJich6yutie", true, "(11) 2485-5791", new DateTime(2022, 2, 10, 3, 25, 19, 824, DateTimeKind.Utc).AddTicks(5951) },
                    { 7, new DateTime(1992, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 10, 3, 25, 19, 824, DateTimeKind.Utc).AddTicks(5945), "DouglasOliveiraRocha@jourrapide.com", "Marknow", "Azevedo", "Douglas", "Aiv6Iquohcae", true, "(61) 3118-6336", new DateTime(2022, 2, 10, 3, 25, 19, 824, DateTimeKind.Utc).AddTicks(5945) },
                    { 6, new DateTime(1994, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 10, 3, 25, 19, 824, DateTimeKind.Utc).AddTicks(5939), "ThaisDiasPinto@teleworm.us", "Adlial", "Oliveira", "Thaís", "Bahxe1ku8koi", true, "(67) 6101-5582", new DateTime(2022, 2, 10, 3, 25, 19, 824, DateTimeKind.Utc).AddTicks(5940) },
                    { 5, new DateTime(1996, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 10, 3, 25, 19, 824, DateTimeKind.Utc).AddTicks(5934), "JulianFerreiraOliveira@dayrep.com", "Hingere", "Rodrigues", "Julian", "eWae2oos", true, "(31) 5173-6191", new DateTime(2022, 2, 10, 3, 25, 19, 824, DateTimeKind.Utc).AddTicks(5934) },
                    { 4, new DateTime(1998, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 10, 3, 25, 19, 824, DateTimeKind.Utc).AddTicks(5927), "LuizPereiraAlves@armyspy.com", "Youria", "Carvalho", "Luiz", "wee2mo8Ohj", true, "(16) 4636-2302", new DateTime(2022, 2, 10, 3, 25, 19, 824, DateTimeKind.Utc).AddTicks(5928) },
                    { 3, new DateTime(1999, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 10, 3, 25, 19, 824, DateTimeKind.Utc).AddTicks(5922), "BrendaAlmeidaCardoso@jourrapide.com", "Sirsomand", "Cunha", "Brenda", "ohCaoha1Oo", true, "(12) 3650-4890", new DateTime(2022, 2, 10, 3, 25, 19, 824, DateTimeKind.Utc).AddTicks(5922) },
                    { 2, new DateTime(2001, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 10, 3, 25, 19, 824, DateTimeKind.Utc).AddTicks(5916), "MelissaCavalcantiPereira@armyspy.com", "Whords", "Cardoso", "Melissa", "AhFeesha8", true, "(11) 8591-3354", new DateTime(2022, 2, 10, 3, 25, 19, 824, DateTimeKind.Utc).AddTicks(5917) },
                    { 19, new DateTime(1968, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 10, 3, 25, 19, 824, DateTimeKind.Utc).AddTicks(6011), "AntonioPereiraOliveira@dayrep.com", "Drefoldn", "Barros", "Antônio", "hee7Aibuo", true, "(82) 8720-7834", new DateTime(2022, 2, 10, 3, 25, 19, 824, DateTimeKind.Utc).AddTicks(6012) },
                    { 20, new DateTime(1966, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 10, 3, 25, 19, 824, DateTimeKind.Utc).AddTicks(6017), "DouglasLimaCastro@teleworm.us", "Opith1999", "Cunha", "Douglas", "aiyaegh7Oh", true, "(16) 7499-9561", new DateTime(2022, 2, 10, 3, 25, 19, 824, DateTimeKind.Utc).AddTicks(6018) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_email",
                table: "Users",
                column: "email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_login",
                table: "Users",
                column: "login",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
