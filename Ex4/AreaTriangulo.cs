using System;
using System.Collections.Generic;
using System.Text;

namespace POO2Ex4
{
    class AreaTriangulo
    {
        private double basin;
        private double altura;
        private double resultado;

        #region construtores

        public AreaTriangulo()
        {
            this.basin = 0;
            this.altura = 0;
        }

        public AreaTriangulo(double basin, double altura)
        {
            this.basin = basin;
            this.altura = altura;
        }
        #endregion

        #region setget
        public void setBasin(double x)
        {
            this.basin = x;
        }

        public void setAltura(double x)
        {
            this.altura = x;
        }

        public double getBasin()
        {
            return this.basin;
        }

        public double getAltura()
        {
            return this.altura;
        }

        public double getResultado()
        {
            return this.resultado;
        }
        #endregion

        public void calcular()
        {
            this.resultado = (this.basin * this.altura) / 2;
        }
    }
}
