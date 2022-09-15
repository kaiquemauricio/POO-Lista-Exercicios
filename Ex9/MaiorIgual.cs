using System;
using System.Collections.Generic;
using System.Text;

namespace POO2Ex9
{
    class MaiorIgual
    {
        private int n1;
        private int n2;

        #region construtores

        public MaiorIgual()
        {
            this.n1 = 0;
            this.n2 = 0;
        }

        public MaiorIgual(int n1, int n2)
        {
            this.n1 = n1;
            this.n2 = n2;

        }

        #endregion

        #region getset
        public void setn1(int x)
        {
            this.n1 = x;
        }

        public void setn2(int x)
        {
            this.n2 = x;
        }

        public int getn1()
        {
            return this.n1;
        }

        public int getn2()
        {
            return this.n2;
        }
        #endregion

        public int indicarMaior()
        {
            if (this.n1 == this.n2)
            {
                return 0;
            }
            else
            {
                if (this.n1 > this.n2)
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
