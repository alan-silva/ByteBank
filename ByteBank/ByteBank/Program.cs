
using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {

            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            Funcionario carlos = new Funcionario(2000, "546.879.157-20"); // Codigo 1 Diretor
            carlos.Nome = "Carlos";
         
            carlos.AumentarSalario();
           
            Console.WriteLine("Novo salário do carlos " + carlos.Salario);

            gerenciador.Registrar(carlos);

            Diretor roberta = new Diretor(5000, "454.658.148-3");
            roberta.Nome = "Roberta";
  
            roberta.AumentarSalario();
            Console.WriteLine(" Novo salário de Roberta " + roberta.Salario);

            Funcionario robertaTeste = roberta;

          


             Console.WriteLine("Bonificação de uma referencia de Diretor: " + roberta.GetBonificacao());
            Console.WriteLine("Bonificação de uma referencia Funcuinario: "+ robertaTeste.GetBonificacao());
             

            gerenciador.Registrar(roberta);

            Console.WriteLine(carlos.Nome);
            Console.WriteLine(carlos.GetBonificacao());

            Console.WriteLine(roberta.Nome);
            Console.WriteLine(roberta.GetBonificacao());

            Console.WriteLine("Total de bonificacoes: " + gerenciador.GetTotalBonificacao());

            Console.WriteLine(Funcionario.TotalDeFuncionarios);

            Console.ReadLine();




        }
    }
}
