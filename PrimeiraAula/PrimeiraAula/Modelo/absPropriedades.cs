using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrimeiraAula.Modelo
{
    public abstract class absPropriedades
    {
        public absPropriedades(String num1, String num2, String op)
        {
            this.num1 = num1;
            this.num2 = num2;
            this.op = op;
        }

        public absPropriedades(Double n1, Double n2, String op)
        {
            this.n1 = n1;
            this.n2 = n2;
            this.op = op;
        }
        public String num1;
        public String num2;
        public Double n1;
        public Double n2;
        public String mensagem;
        public String op;
        public String resposta;
    }
}
