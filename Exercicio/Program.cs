using exercicio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Departamentos cozinha = new Departamentos();
            cozinha.cadastrarDepartamento("cozinha");


            Diretor diretor = new Diretor();
            diretor.Cadastrar(cozinha);


            Gerente gerente = new Gerente();
            gerente.cadastrar(cozinha);


            Funcionario funcionario = new Funcionario();
            funcionario.Cadastrar(cozinha);

            Funcionario funcionario1 = new Funcionario();
            funcionario1.Cadastrar(cozinha);


            cozinha.mostrarFuncionarios();

            Cliente cliente = new Cliente();



            Console.ReadKey();

        }
    }
}