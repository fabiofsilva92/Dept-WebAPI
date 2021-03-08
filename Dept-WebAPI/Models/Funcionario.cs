namespace Dept_WebAPI.Models
{
    public class Funcionario
    {
        public int FuncionarioId { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Telefone { get; set; }
        public int DepartamentoId { get; set; }
        //public int MyProperty { get; set; }
    }
}