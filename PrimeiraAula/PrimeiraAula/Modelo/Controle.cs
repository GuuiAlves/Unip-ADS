using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrimeiraAula.Modelo
{
    public class Controle : absPropriedades
    {
        public Controle(String num1, String num2, String op) : base(num1, num2, op)
        {
            this.Executar();
        }

        public void Executar()
        {
            this.mensagem = "";
            Validacao validacao = new Validacao(this.num1, this.num2, this.op);

            if (validacao.mensagem.Equals(""))
            {
                Calculos calculos = new Calculos(validacao.n1, validacao.n2, validacao.op);
                this.resposta = calculos.resposta;
            }
            else
            {
                this.mensagem = validacao.mensagem;
            }
        }
    }
}
