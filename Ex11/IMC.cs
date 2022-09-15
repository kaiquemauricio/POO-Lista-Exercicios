using System;
using System.Collections.Generic;
using System.Text;

namespace POO2Ex11
{
    class IMC
    {
        private double altura;
        private double peso;
        private double Imc;

        #region construtores

        public IMC()
        {
            this.altura = 0;
            this.peso = 0;
        }

        public IMC(double altura, double peso)
        {
            this.altura = altura;
            this.peso = peso;
        }

        #endregion

        #region getset
        public void setAltura(double x)
        {
            this.altura = x;
        }

        public void setPeso(double x)
        {
            this.peso = x;
        }

        public double getAltura()
        {
            return this.altura;
        }

        public double getPeso()
        {
            return this.peso;
        }

        public double getImc()
        {
            return this.Imc;
        }
        #endregion

        public void calcular()
        {
            this.Imc = this.peso / Math.Pow(this.altura, 2);
        }
    }
}
