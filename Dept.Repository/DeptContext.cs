
using System.Collections.Generic;
using Dept.Domain;
using Microsoft.EntityFrameworkCore;

namespace Dept.Repository
{
    public class DeptContext : DbContext
    {
        public DeptContext (DbContextOptions<DeptContext> options) : base (options) {}

        public DbSet<Funcionario> Funcionarios {get; set; }
        public DbSet<Departamento> Departamentos {get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {

            builder.Entity<Departamento>()
                .HasData(new List<Departamento>(){
                    new Departamento(10, "Recursos Humanos", "222-3535"),
                    new Departamento(11, "Financeiro", "222-3535"),
                    new Departamento(12, "Administrativo", "222-3535"),
                    new Departamento(13, "Comercial", "222-3535"),
                    new Departamento(14, "Manutenção", "222-3535"),
                    new Departamento(15, "Operacional", "222-3535"),
                    new Departamento(16, "TI", "99704-6172"),
                });

            builder.Entity<Funcionario>()
                .HasData(new List<Funcionario>{
                    new Funcionario(1, "Fabio", "Fernandes", "555-3626", 16),
                    new Funcionario(2, "José", "da Silva", "888-9899" , 16),
                    new Funcionario(3, "Thiago", "Oliveira", "964-5896" ,16),
                    new Funcionario(4, "Paloma", "Machado", "562-5233" , 16),
                    new Funcionario(5, "Laura", "Ferreira", "548-8986" ,16),
                    new Funcionario(6, "Lucas", "Paula", "111-2350" ,16),
                    new Funcionario(7, "Edite", "Fernandes", "225-6583" , 16),
                });
        }

    }
}