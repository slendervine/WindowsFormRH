using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstWindowsDesktopDomain
{
    public class Cliente
    {
        public Cliente(string nome, string documento, DateTime dataNascimento, int idade, int cargo, decimal salario)
        {
            this.Id = 0;
            this.Nome = nome;
            this.Documento = documento;
            this.DataNascimento = dataNascimento;
            this.Idade = idade;
            this.Cargo = cargo;
            this.Salario = salario;
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Documento { get; set; }
        public DateTime DataNascimento { get; set; }
        public int Idade { get; set; }
        public int Cargo { get; set; }
        public decimal Salario { get; set; }
        public static List<Cliente> ClienteList { get; set; }
        public int EnderecoId { get; set; }

        static Cliente() //nao entendi isso não, quantos construtores eu tenho dentro da classe?
        {
            Cliente.ClienteList = new List<Cliente>();
        }

        public Cliente()
        {
            this.Id = 0;
        }

        public static Cliente Inserir(Cliente novoCliente)
        {
            int id = Cliente.ClienteList.Count > 0 ?
                Cliente.ClienteList.Max(x => x.Id) + 1 : 1;

            novoCliente.Id = id;

            Cliente.ClienteList.Add(novoCliente);
            return novoCliente;
        }

        public static void Editar(Cliente editadoCliente, int clienteId)
        {
            editadoCliente.Id = clienteId;

            int index = ClienteList.FindIndex(x => x.Id == clienteId);
            ClienteList[index] = editadoCliente;

        }

        public static void Excluir(int clienteId)
        {
            int index = ClienteList.FindIndex(x => x.Id == clienteId);
            ClienteList.Remove(ClienteList[index]);
        }

    }
}
