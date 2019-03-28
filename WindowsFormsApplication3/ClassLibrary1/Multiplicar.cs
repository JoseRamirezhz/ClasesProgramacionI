using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operaciones
{
  public   class Multiplicar
    {
        private double n1, n2, resultado;
        public double Multiplica()
        {
            resultado = n1 * n2;
            return resultado;
        }

        public double Resultado
        {
            get { return resultado; }
            set { resultado = value; }
        }

        public double N2
        {
            get { return n2; }
            set { n2 = value; }
        }

        public double N1
        {
            get { return n1; }
            set { n1 = value; }
        }
        public Multiplicar()
        {
            this.n1 = 0;
            this.n2 = 0;
        }
    }
}
