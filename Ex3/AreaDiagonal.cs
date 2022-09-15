using System;
using System.Collections.Generic;
using System.Text;

namespace POO2Ex3
{
    class AreaDiagonal
    {
        private double diagonal;
        private double resultado;

        #region construtores

        public AreaDiagonal()
        {
            this.diagonal = 0;
        }

        public AreaDiagonal(double diagonal)
        {
            this.diagonal = diagonal;
        }

        #endregion 

        #region getset

        public void setDiagonal(double x)
        {
            this.diagonal = x;
        }

        public double getDiagonal()
        {
            return this.diagonal;
        }

        public double getResultado()
        {
            return this.resultado;
        }

        #endregion
        public void calcular()
        {
            this.resultado = (Math.Pow(this.diagonal, 2)) / 2;
        }
    }
}
