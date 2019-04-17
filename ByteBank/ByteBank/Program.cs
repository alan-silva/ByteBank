
using ByteBank.Funcionarios;
using ByteBank.Sistemas;
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
            //CalcularBonificacao();

            UsarSistema();
        
            Console.ReadLine();
        }

        public static void UsarSistema()
        {
            SistemaInterno sistemaInterno = new SistemaInterno();
            Diretor roberta = new Diretor("159.753.398-04");
            roberta.Senha = "123";
            sistemaInterno.Logar(roberta,"234");
            sistemaInterno.Logar(roberta, "123");

            GerenteDeConta camila = new GerenteDeConta("326.985.628-89");
            camila.Nome = "Camila";
            camila.Senha = "123";

            
            sistemaInterno.Logar(camila, "234");
            sistemaInterno.Logar(camila, "123");

            ParceiroComercial parceiro = new ParceiroComercial();
            parceiro.Senha = "1234";

            sistemaInterno.Logar(parceiro, "1234");


        }

        public static void CalcularBonificacao()
        {
            GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();

            Funcionario pedro = new Designer("833.222.048-39");
            pedro.Nome = "Pedro";

            Funcionario roberta = new Diretor("833.222.048-31");
            roberta.Nome = "Roberta";

            Funcionario igor = new Auxiliar("833.222.048-30");
            igor.Nome = "Igor";

            Funcionario camila = new GerenteDeConta("833.222.048-32");
            camila.Nome = "Camila";

            gerenciadorBonificacao.Registrar(pedro);
            gerenciadorBonificacao.Registrar(roberta);
            gerenciadorBonificacao.Registrar(igor);
            gerenciadorBonificacao.Registrar(camila);

            Console.WriteLine("Total de Bonificações do mês " +
                gerenciadorBonificacao.GetTotalBonificacao());




        }
    }
}
