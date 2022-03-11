﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace CleanArchMvc.Infra.Data.Migrations
{
    public partial class SeedProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder) {

            migrationBuilder.Sql("INSERT INTO Products (Name, Description, Price, Stock, Image, CategoryId)" + 
                       "VALUES('Caderno Espiral', 'Caderno Espiral 100 folhas', 7.45, 50, 'caderno1.jpg', 1)");

            migrationBuilder.Sql("INSERT INTO Products (Name, Description, Price, Stock, Image, CategoryId)" +
                           "VALUES('Estojo Escolar', 'Estojo Escolar cinza', 5.65, 70, 'estojo1.jpg', 1)");

            migrationBuilder.Sql("INSERT INTO Products (Name, Description, Price, Stock, Image, CategoryId)" +
                            "VALUES('Borracha Escolar', 'Borracha Escolar branca pequena', 3.25, 80, 'borracha1.jpg', 1)");

            migrationBuilder.Sql("INSERT INTO Products (Name, Description, Price, Stock, Image, CategoryId)" +
                            "VALUES('Calculadora Escolar', 'Calculadora Escolar simples', 15.39, 20, 'calculadora1.jpg', 2)");

        }

        protected override void Down(MigrationBuilder migrationBuilder) {

            migrationBuilder.Sql("DELETE FROM Products");
        }
    }
}
