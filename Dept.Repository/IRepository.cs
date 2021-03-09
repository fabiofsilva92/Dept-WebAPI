using System.Threading.Tasks;
using Dept.Domain;

namespace Dept.Repository
{
    public interface IRepository
    {
        
        void Add<T>(T entity) where T: class;
        void Update<T>(T entity) where T: class;
        void Delete<T>(T entity) where T: class;

        Task<bool> SaveChangesAsync();

        //Departamentos

        Task<Departamento[]> GetAllDepartamentoAsync();
        Task<Departamento> GetAllDepartamentoAsyncById(int DepartamentoId, bool includeFuncionarios);


        //Funcionarios

        Task<Funcionario[]> GetAllFuncionarioAsync();
        Task<Funcionario> GetAllFuncionarioAsyncById(int FuncionarioId);

    }
}