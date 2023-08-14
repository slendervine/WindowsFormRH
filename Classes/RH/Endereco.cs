using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstWindowsDesktopDomain
{
    public class Endereco
    {
        public Endereco(int id, string cep, string logradouro, int estado, string cidade, string bairro, int numero)
        {
            Id = id;
            Cep = cep;
            Logradouro = logradouro;
            Estado = estado;
            Cidade = cidade;
            Numero = numero;
            Bairro = bairro;
        }


        public int Id { get; set; }
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public int Estado { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public int Numero { get; set; }

        public static List<Endereco> EnderecoList { get; set; }
        
        static Endereco() 
        {   
            Endereco.EnderecoList = new List<Endereco>();
        }

        public Endereco()
        {
            this.Id = 0;
        }

        public static Endereco GetEndereco(int enderecoId)
        {
            Endereco endereco = EnderecoList.Find(x => x.Id == enderecoId);

            return endereco;
        }

        public static Endereco Inserir(Endereco novoEndereco)
        {
            int id = Endereco.EnderecoList.Count > 0 ?
                Endereco.EnderecoList.Max(x => x.Id) + 1 : 1;

            novoEndereco.Id = id;

            Endereco.EnderecoList.Add(novoEndereco);
            return novoEndereco;
        }

        public static void Editar(Endereco editadoEndereco, int enderecoId)
        {
            editadoEndereco.Id = enderecoId;

            int index = EnderecoList.FindIndex(x => x.Id == enderecoId);
            EnderecoList[index] = editadoEndereco;

        }

    }
}
