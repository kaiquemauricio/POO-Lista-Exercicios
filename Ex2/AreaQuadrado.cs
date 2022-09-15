using System;
using System.Collections.Generic;
using System.Text;

namespace POO2Ex2
{
    class AreaQuadrado
    {
        private double aresta;
        private double resultado;

        #region constutores

        public AreaQuadrado()
        {
            this.aresta = 0;
        }

        public AreaQuadrado(double aresta, double resultado)
        {
            this.aresta = aresta;
        }

        #endregion

        #region getset

        public void setAresta(double x)
        {
            this.aresta = x;
        }

        public double getAresta()
        {
            return this.aresta;
        }

        public double getResultado()
        {
            return this.resultado;
        }

        #endregion

        public void calcular()
        {
            this.resultado = Math.Pow(this.aresta, 2);
        }
        
    }
}
