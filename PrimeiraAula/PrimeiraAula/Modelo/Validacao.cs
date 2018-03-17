﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrimeiraAula.Modelo
{
    public class Validacao
    {
        public String num1;
        public String num2;
        public Double n1;
        public Double n2;
        public String mensagem;
        public String op;

        public void Validar()
        {
            this.mensagem = "";
            try
            {
                this.n1 = Convert.ToDouble(this.num1);
            }
            catch (FormatException e)
            {
                this.mensagem = "Erro de conversão do primeiro numero \n";
            }
            try
            {
                this.n2 = Convert.ToDouble(this.num2);
            }
            catch (FormatException e)
            {
                this.mensagem += "Erro de conversão do segundo numero \n";
            }
            if (this.num2.Equals("0") && this.op.Equals("/"))
            {
                this.mensagem += "Erro, divisão por zero";
            }
        }
    }
}