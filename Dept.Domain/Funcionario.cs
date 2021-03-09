namespace Dept.Domain
{
    public class Funcionario
    {

        public Funcionario(int id, string nome, string sobrenome, string telefone, int departamentoId)
        {
            this.Id = id;
            this.Nome = nome;
            this.Sobrenome = sobrenome;
            this.Telefone = telefone;
            this.DepartamentoId = departamentoId;

        }
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Telefone { get; set; }
        public int DepartamentoId { get; set; }
        public Departamento Departamento { get; set; }
        //public int MyProperty { get; set; }
    }
}