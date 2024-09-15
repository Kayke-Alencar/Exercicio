using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio
{
    internal class Departamentos
    {
        public string nome;
        public string gerente;
        public string diretor;
        public int[] funcionarios = new int[500]; //vai conter os registros dos funcionarios(no maximo 500 funcionarios)
        public int qntdFuncionarios = 0;


        public void cadastrarDepartamento(string nome)
        {
            this.nome = nome;
        }

        public void addFuncionarios(int funcionario)
        {
            funcionarios[qntdFuncionarios] = funcionario;
            qntdFuncionarios++;
        }

        public void mostrarFuncionarios()
        {


            for (int i = 0; i <= qntdFuncionarios -1; i++)
            {
                Console.WriteLine(funcionarios[i]);
            }
        
        
        }

    }
}