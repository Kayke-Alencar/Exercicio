using Exercicio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio
{
    internal class Gerente:Funcionario
    {
        public string nome;
        public string DepartamentoResponsavel;

        public void cadastrar(Departamentos departamento)
        {
            base.Cadastrar(departamento);

            this.DepartamentoResponsavel = departamento.nome;
            departamento.gerente = this.nome;
        }
    }
}