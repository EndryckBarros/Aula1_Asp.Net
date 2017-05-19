using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CalculadoraWeb3.Models
{
    public class Calculo
    {

        public int Valor1 { get; set; }
        public int Valor2 { get; set; }
        public int Resultado { get; set; }


        public  int CalculoDosNumeros(int op)
        {
            int operacao = op;
            switch (operacao)
            {
                case 1:
                    Resultado = Valor1 + Valor2;
                    break;
                case 2:
                    Resultado = Valor1 - Valor2;
                    break;
                case 3:
                    Resultado = Valor1 * Valor2;
                    break;
                case 4:
                    Resultado = Valor1 / Valor2;
                    break;
            }
           
            return Resultado;
        }
    }
}