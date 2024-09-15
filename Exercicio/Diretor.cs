using exercicio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio
{
    internal class Diretor:Funcionario
    {
        public string departamentoDiretor;
        public void cadastrar(Departamentos departamento)
        {
            base.Cadastrar(departamento);

            this.departamentoDiretor = departamento.nome;
            departamento.gerente = this.nome;
        }
    }


}
