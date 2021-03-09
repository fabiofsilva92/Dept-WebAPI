using System.Collections.Generic;

namespace Dept.Domain
{
    public class Departamento
    {
        public Departamento(int id, string nome, string telefone)
        {
            this.Id = id;
            this.Nome = nome;
            this.Telefone = telefone;
        }
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }


        public List<Funcionario> Funcionarios { get; set; }
         
    }
}