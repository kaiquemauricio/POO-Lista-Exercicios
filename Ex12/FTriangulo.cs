using System;
using System.Collections.Generic;
using System.Text;

namespace POO2Ex12
{
    class FTriangulo
    {
        private int a;
        private int b;
        private int c;

        #region construtores

        public FTriangulo()
        {
            this.a = 0;
            this.b = 0;
            this.c = 0;
        }

        public FTriangulo(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        #endregion

        #region getset
        public void setA(int x)
        {
            this.a = x;
        }

        public void setB(int x)
        {
            this.b = x;
        }

        public void setC(int x)
        {
            this.c = x;
        }

        public int getA()
        {
            return this.a;
        }

        public int getB()
        {
            return this.b;
        }

        public int getC()
        {
            return this.c;
        }

        #endregion

        #region ifelse
        public void triangular()
        {
            if (this.a + this.b < this.c)
            {
                Console.Write("Não formam triângulo");
                return;
            }
            if (this.a + this.c < this.b)
            {
                Console.Write("Não formam triângulo");
                return;
            }
            if (this.b + this.c < this.a)
            {
                Console.Write("Não formam triângulo");
                return;
            }

            //tipo de triangulo
            if (this.a == this.b && this.a == this.c)
            {
                Console.Write("Triângulo equilátero");
                return;
            }
            if (this.a == this.b || this.b == this.c || this.a == this.c)
            {
                Console.Write("Triângulo isosceles");
            }
            else
            {
                Console.Write("Triângulo escaleno");
            }


        }
        #endregion
    }
}
