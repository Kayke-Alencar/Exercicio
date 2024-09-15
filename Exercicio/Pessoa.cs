using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio
{
    internal class Pessoa
    {
        public string nome;
        public string email;
        public string telefone;
        public string nascimeto;

        protected string cpf;
        protected Endereco endereco = new Endereco();

     

        public string CapturarDados(string pergunta)
        {
            Console.WriteLine(pergunta);
            return Console.ReadLine();
        }

        public virtual void Cadastrar()
        {
            string tipo = this.GetType().Name; // devolve nome da clase (no caso seu tipo)
           

            this.nome = this.CapturarDados($"digite o Nome de {tipo}: ");
            this.email = this.CapturarDados($"digite o Email de {tipo}:  ");
            this.telefone = this.CapturarDados($"digite o Telefone de {tipo}: ");
            this.nascimeto = this.CapturarDados($"digite o Nascimento de {tipo}: ");
            this.cpf = this.CapturarDados($"digite o cpf de {tipo}: ");

            this.endereco.cep = this.CapturarDados($"digite o cep de {tipo}: ");
            this.endereco.estado = this.CapturarDados($"digite o estado de {tipo}: ");
            this.endereco.cidade = this.CapturarDados($"digite o Cidade de {tipo}: ");
            this.endereco.Bairro = this.CapturarDados($"digite o Bairro de {tipo}: ");
            this.endereco.rua = this.CapturarDados($"digite a Rua de {tipo}: ");
            this.endereco.NumeroDaCasa= this.CapturarDados("digite o Numero da casa: ");
        }

        public virtual void MostrarCadastro()
        {
            Console.WriteLine($"Nome:{this.nome}\nEmail:{this.email}\nTelefone:{this.telefone}\nNascimento:{this.nascimeto}");
            Console.WriteLine($"Endereco: Rua {this.endereco.rua}, Numero {this.endereco.NumeroDaCasa}, {this.endereco.Bairro}, {this.endereco.cidade}-{this.endereco.estado}");
            Console.WriteLine($"cep:{this.endereco.cep}");
        }
    }
}