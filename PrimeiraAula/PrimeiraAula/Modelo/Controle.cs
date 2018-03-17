using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrimeiraAula.Modelo
{
    public class Controle
    {
        public String num1;
        public String num2;
        public String op;
        public String resposta;
        public String mensagem;

        public void Executar()
        {
            this.mensagem = "";
            Validacao valida = new Validacao();
            valida.num1 = this.num1;
            valida.num2 = this.num2;
            valida.op = this.op;
            valida.Validar();
            if (valida.mensagem.Equals(""))
            {
                Calculos calculos = new Calculos();
                calculos.n1 = valida.n1;
                calculos.n2 = valida.n2;
                calculos.op = this.op;
                calculos.Calcular();
                this.resposta = calculos.resposta;
            }
            else
            {
                this.mensagem = valida.mensagem;
            }
        }
    }
}
