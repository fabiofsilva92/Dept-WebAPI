using System.Linq;
using System.Threading.Tasks;
using Dept.Domain;
using Microsoft.EntityFrameworkCore;

namespace Dept.Repository
{
    public class Repository : IRepository //Implementação da interface
    {
        //Injetando contexto
        private readonly DeptContext _context; 

        public Repository(DeptContext context)
        {   
            _context = context;
        }

        //Gerais
        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }

        public void Update<T>(T entity) where T : class
        {
            _context.Update(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }

        public async Task<bool> SaveChangesAsync()
        {
           return (await _context.SaveChangesAsync()) > 0;
        }

        //Gets
        public async Task<Departamento[]> GetAllDepartamentoAsync()
        {
            IQueryable<Departamento> query = _context.Departamentos;
/*                     .Include(x => x.Id)
                    .Include(x => x.Nome)
                    .Include(x => x.Telefone); */

            query = query.OrderByDescending(x => x.Id);

            return await query.ToArrayAsync();
        }

        public async Task<Departamento> GetAllDepartamentoAsyncById(int DepartamentoId, bool includeFuncionarios = false)
        {
            IQueryable<Departamento> query = _context.Departamentos;
/*                     .Include(x => x.Id)
                    .Include(x => x.Nome)
                    .Include(x => x.Telefone); */

            if(includeFuncionarios){
                query = query.Include(f => f.Funcionarios);
            }                    

            query = query.OrderByDescending(x => x.Id).Where(x => x.Id == DepartamentoId);

            return await query.FirstOrDefaultAsync();
        }

        //FUNCIONARIOS
        public async Task<Funcionario[]> GetAllFuncionarioAsync()
        {
            IQueryable<Funcionario> query = _context.Funcionarios;
/*                     .Include(x => x.Id)
                    .Include(x => x.Nome)
                    .Include(x => x.Sobrenome)
                    .Include(x => x.Telefone)
                    .Include(x => x.DepartamentoId); */


            query = query.AsNoTracking().OrderBy(x => x.Id);

            return await query.ToArrayAsync();
        }

        public async Task<Funcionario> GetAllFuncionarioAsyncById(int FuncionarioId)
        {
            IQueryable<Funcionario> query = _context.Funcionarios;
/*                     .Include(x => x.Id)
                    .Include(x => x.Nome)
                    .Include(x => x.Sobrenome)
                    .Include(x => x.Telefone)
                    .Include(x => x.DepartamentoId); */

            query = query.Where(x => x.Id == FuncionarioId);

            return await query.FirstOrDefaultAsync();
        }


    }
}