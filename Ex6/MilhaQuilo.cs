using System;
using System.Collections.Generic;
using System.Text;

namespace POO2Ex6
{
    class MilhaQuilo
    {
        private double milhas;
        private double resultado;

        #region construtores
        
        public MilhaQuilo()
        {
            this.milhas = 0;
        }

        public MilhaQuilo(double milhas)
        {
            this.milhas = milhas;
        }

        #endregion

        #region getset
        public void setMilhas(double x)
        {
            this.milhas = x;
        }

        public double getMilhas()
        {
            return this.milhas;
        }

        public double getResultado()
        {
            return this.resultado;
        }
        #endregion

        public void calcular()
        {
            this.resultado = this.milhas * 1.852;
        }
    }
}
