using Dept_WebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace Dept_WebAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext (DbContextOptions<DataContext> options) : base (options) {}

        public DbSet<Funcionario> Funcionarios {get; set; }
    }
}