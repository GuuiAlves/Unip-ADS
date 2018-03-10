using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrimeiraAula.Modelo
{
    public class Controle
    {
        #region Atributos
        private String num1;
        private String num2;
        private String op;
        private String resposta;
        #endregion

        #region Construtores
        public Controle(String num1, String num2, String op)
        {
            this.num1 = num1;
            this.num2 = num2;
            this.op = op;
            Calcular();
        }
        #endregion

        #region Metodos
        public void Calcular()
        {
            Double n1 = 0.0, n2 = 0.0, resultado = 0.0;
            try
            {
                n1 = Convert.ToDouble(this.num1);
                n2 = Convert.ToDouble(this.num2);
                if (this.op.Equals("+"))
                    resultado = n1 + n2;
                if (this.op.Equals("-"))
                    resultado = n1 - n2;
                if (this.op.Equals("*"))
                    resultado = n1 * n2;
                resposta = resultado.ToString("0.##");
                if (this.op.Equals("/"))
                    if (n2 == 0)
                        this.resposta = "Divisão por zero";
                    else
                    {
                        resultado = n1 / n2;
                        this.resposta = resultado.ToString("0.##");
                    }
            }
            catch (FormatException)
            {
                resposta = "Digite um número válido";
            }
        }
        #endregion

        #region Propriedades
        public String Resposta
        {
            get { return resposta; }
        }
        #endregion
    }
}