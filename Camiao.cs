using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ND_Auto
{
    public class Camiao : Veiculo
    {
        private int pesoMaximo;
        public int PesoMaximo
        {
            get { return pesoMaximo; }
            set { pesoMaximo = value; }
        }

        public Camiao()
        {
            this.pesoMaximo = 0;
        }

        public Camiao(int pesoMaximo)
        {
            this.PesoMaximo = pesoMaximo;
        }

        public Camiao(Camiao c)
        {
            this.PesoMaximo = c.PesoMaximo;
        }
    }
}
