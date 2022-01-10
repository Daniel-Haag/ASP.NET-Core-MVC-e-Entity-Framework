using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FuncionariosWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace FuncionariosWeb.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Funcionario> Funcionarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Funcionario>().HasData(
                new Funcionario
                {
                    FuncionarioID = 1,
                    Nome = "Haag",
                    Departamento = Departamento.TI,
                    Email = "danni.haag91@gmail.com"
                });
        }
    }
}
