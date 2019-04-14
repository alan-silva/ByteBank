using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class Funcionario
    {
        // 0 - Funcionário
        // 1 - Diretor 
        // 2 - Designer 

        private int _tipo;

        public string Nome { get; set; }
        public string CPF { get; set; }
        public double Salario { get; set; }

   

        public double GetBonificacao()
        {
            
            return Salario * 0.10;
        }


    }
}
