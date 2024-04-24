using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CZ.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InsertDefaultValues : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Categories
            migrationBuilder.Sql("INSERT INTO [Categories] ([Name]) VALUES ('Classic')");
            migrationBuilder.Sql("INSERT INTO [Categories] ([Name]) VALUES ('Gold')");
            migrationBuilder.Sql("INSERT INTO [Categories] ([Name]) VALUES ('Platinum')");
            migrationBuilder.Sql("INSERT INTO [Categories] ([Name]) VALUES ('Diamond')");
            
            // Clients
            migrationBuilder.Sql("INSERT INTO [Clients] ([CategoryId], [Name], [LastName], [DNI], [TucsonSubscriptionNumber], [Key]) VALUES (1, 'Client1', 'LastName1', '12313', 1, NEWID())");
            migrationBuilder.Sql("INSERT INTO [Clients] ([CategoryId], [Name], [LastName], [DNI], [TucsonSubscriptionNumber], [Key]) VALUES (1, 'Client2', 'LastName2', '45566', 2, NEWID())");
            migrationBuilder.Sql("INSERT INTO [Clients] ([CategoryId], [Name], [LastName], [DNI], [TucsonSubscriptionNumber], [Key]) VALUES (2, 'Client3', 'LastName3', '78978', 3, NEWID())");
            migrationBuilder.Sql("INSERT INTO [Clients] ([CategoryId], [Name], [LastName], [DNI], [TucsonSubscriptionNumber], [Key]) VALUES (2, 'Client4', 'LastName4', '14717', 4, NEWID())");
            migrationBuilder.Sql("INSERT INTO [Clients] ([CategoryId], [Name], [LastName], [DNI], [TucsonSubscriptionNumber], [Key]) VALUES (3, 'Client5', 'LastName5', '25852', 5, NEWID())");
            migrationBuilder.Sql("INSERT INTO [Clients] ([CategoryId], [Name], [LastName], [DNI], [TucsonSubscriptionNumber], [Key]) VALUES (4, 'Client6', 'LastName6', '36963', 6, NEWID())");
            
            // Daytime
            migrationBuilder.Sql("INSERT INTO [Daytimes] ([Code], [Name]) VALUES (1, 'Noche')");

            // Tables
            migrationBuilder.Sql("INSERT INTO [Tables] ([CutleryQuantity]) VALUES (2)");
            migrationBuilder.Sql("INSERT INTO [Tables] ([CutleryQuantity]) VALUES (2)");
            migrationBuilder.Sql("INSERT INTO [Tables] ([CutleryQuantity]) VALUES (2)");
            migrationBuilder.Sql("INSERT INTO [Tables] ([CutleryQuantity]) VALUES (2)");
            migrationBuilder.Sql("INSERT INTO [Tables] ([CutleryQuantity]) VALUES (2)");
            migrationBuilder.Sql("INSERT INTO [Tables] ([CutleryQuantity]) VALUES (2)");
            migrationBuilder.Sql("INSERT INTO [Tables] ([CutleryQuantity]) VALUES (2)");
            migrationBuilder.Sql("INSERT INTO [Tables] ([CutleryQuantity]) VALUES (2)");
            migrationBuilder.Sql("INSERT INTO [Tables] ([CutleryQuantity]) VALUES (2)");
            migrationBuilder.Sql("INSERT INTO [Tables] ([CutleryQuantity]) VALUES (2)");
            migrationBuilder.Sql("INSERT INTO [Tables] ([CutleryQuantity]) VALUES (2)");
            migrationBuilder.Sql("INSERT INTO [Tables] ([CutleryQuantity]) VALUES (2)");
            migrationBuilder.Sql("INSERT INTO [Tables] ([CutleryQuantity]) VALUES (2)");
            migrationBuilder.Sql("INSERT INTO [Tables] ([CutleryQuantity]) VALUES (2)");
            migrationBuilder.Sql("INSERT INTO [Tables] ([CutleryQuantity]) VALUES (2)");
            migrationBuilder.Sql("INSERT INTO [Tables] ([CutleryQuantity]) VALUES (2)");
            migrationBuilder.Sql("INSERT INTO [Tables] ([CutleryQuantity]) VALUES (2)");
            migrationBuilder.Sql("INSERT INTO [Tables] ([CutleryQuantity]) VALUES (2)");

            migrationBuilder.Sql("INSERT INTO [Tables] ([CutleryQuantity]) VALUES (4)");
            migrationBuilder.Sql("INSERT INTO [Tables] ([CutleryQuantity]) VALUES (4)");
            migrationBuilder.Sql("INSERT INTO [Tables] ([CutleryQuantity]) VALUES (4)");
            migrationBuilder.Sql("INSERT INTO [Tables] ([CutleryQuantity]) VALUES (4)");
            migrationBuilder.Sql("INSERT INTO [Tables] ([CutleryQuantity]) VALUES (4)");
            migrationBuilder.Sql("INSERT INTO [Tables] ([CutleryQuantity]) VALUES (4)");
            migrationBuilder.Sql("INSERT INTO [Tables] ([CutleryQuantity]) VALUES (4)");
            migrationBuilder.Sql("INSERT INTO [Tables] ([CutleryQuantity]) VALUES (4)");
            migrationBuilder.Sql("INSERT INTO [Tables] ([CutleryQuantity]) VALUES (4)");
            migrationBuilder.Sql("INSERT INTO [Tables] ([CutleryQuantity]) VALUES (4)");
            migrationBuilder.Sql("INSERT INTO [Tables] ([CutleryQuantity]) VALUES (4)");
            migrationBuilder.Sql("INSERT INTO [Tables] ([CutleryQuantity]) VALUES (4)");
            migrationBuilder.Sql("INSERT INTO [Tables] ([CutleryQuantity]) VALUES (4)");
            migrationBuilder.Sql("INSERT INTO [Tables] ([CutleryQuantity]) VALUES (4)");
            migrationBuilder.Sql("INSERT INTO [Tables] ([CutleryQuantity]) VALUES (4)");
            
            migrationBuilder.Sql("INSERT INTO [Tables] ([CutleryQuantity]) VALUES (6)");
            migrationBuilder.Sql("INSERT INTO [Tables] ([CutleryQuantity]) VALUES (6)");
            migrationBuilder.Sql("INSERT INTO [Tables] ([CutleryQuantity]) VALUES (6)");
            migrationBuilder.Sql("INSERT INTO [Tables] ([CutleryQuantity]) VALUES (6)");
            migrationBuilder.Sql("INSERT INTO [Tables] ([CutleryQuantity]) VALUES (6)");
            migrationBuilder.Sql("INSERT INTO [Tables] ([CutleryQuantity]) VALUES (6)");
            migrationBuilder.Sql("INSERT INTO [Tables] ([CutleryQuantity]) VALUES (6)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("TRUNCATE TABLE [Tables]");
            migrationBuilder.Sql("TRUNCATE TABLE [Daytimes]");
            migrationBuilder.Sql("TRUNCATE TABLE [Clients]");
            migrationBuilder.Sql("TRUNCATE TABLE [Categories]");
        }
    }
}
