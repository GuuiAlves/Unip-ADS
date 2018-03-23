using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrimeiraAula.Modelo
{
    public class Validacao : absPropriedades
    {
        public Validacao(String n1, String n2, String op) : base(n1, n2, op)
        {
            Validar();
        }
        public void Validar()
        {
            this.mensagem = "";
            try
            {
                this.n1 = Convert.ToDouble(this.num1);
            }
            catch (FormatException)
            {
                this.mensagem = "Erro de conversão no campo 1 \n";
            }
            try
            {
                this.n2 = Convert.ToDouble(this.num2);
            }
            catch (FormatException)
            {
                this.mensagem += "Erro de conversão no campo 2 \n";
            }
            if (this.num2.Equals("0") && this.op.Equals("/"))
            {
                this.mensagem += "Divisao por 0";
            }
        }
    }
}
