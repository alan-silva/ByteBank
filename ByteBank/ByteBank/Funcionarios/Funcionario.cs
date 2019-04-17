using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public abstract class Funcionario
    {
        public static int TotalDeFuncionarios { get; private set; }

        private int _tipo;
       
        public string Nome { get; set; }
        public string CPF { get; private set; }
        public double Salario { get; protected set; }


      

        public Funcionario(double salario, string cpf)
        {
            CPF = cpf;
            Salario = salario;
            TotalDeFuncionarios++;
            Console.WriteLine("Construtor de Funcionário");
        }

        public abstract void AumentarSalario();


        public abstract double GetBonificacao();


    }
}
