using Exercicio;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio
{
    internal class Funcionario:Pessoa
    {
        public string cargo;
        public string departamento;    
        public string turno;

        
        protected int registro;
        protected string tipoDeContrato;
        protected double salario; 


        public void Cadastrar(Departamentos departamento)
        {
            base.Cadastrar(); //vai cadastrar os intens mais gerais
            this.registro = int.Parse(this.CapturarDados($"digite o Registro de {this.GetType().Name}"));
            this.tipoDeContrato = this.CapturarDados($"digite o Tipo do contrato de {this.GetType().Name}");
            this.salario = double.Parse(this.CapturarDados($"digite o Salario de {this.GetType().Name}"));

            this.cargo = this.CapturarDados("digite o Cargo: ");
            this.turno = this.CapturarDados("digite o Turno");

            this.departamento = departamento.nome;
            departamento.addFuncionarios(this.registro);

       
        }
        public override void MostrarCadastro() 
        {
            base.MostrarCadastro();
            Console.WriteLine($"Cargo: {this.cargo}\nSetor:{this.departamento}\nRegistro:{this.registro}\nTurno:{this.turno}\nRegistro:{this.registro}\nTipo de contrato:{this.tipoDeContrato}\nSalario:{this.salario}");
            
        }

    }
}