using System;
using System.Collections.Generic;
using System.Text;

namespace POO2Ex7
{
    class CotaDolar
    {
        private double cotacao;
        private double quantia;
        private double resultado;

        #region construtores

        public CotaDolar()
        {
            this.cotacao = 0;
            this.quantia = 0;
        }

        public CotaDolar(double cotacao, double quantia)
        {
            this.cotacao = cotacao;
            this.quantia = quantia;
        }

        #endregion

        #region getset

        public void setCotacao(double x)
        {
            this.cotacao = x;
        }

        public void setQuantia(double x)
        {
            this.quantia = x;
        }

        public double getCotacao()
        {
            return this.cotacao;
        }

        public double getQuantia()
        {
            return this.quantia;
        }

        public double getResultado()
        {
            return this.resultado;
        }
        #endregion

        public void calcular()
        {
            this.resultado = this.quantia * this.cotacao;
        }
    }
}
