using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ND_Auto
{
    public class Mota : Veiculo 
    {
        private string cilindrada;
        public string Cilindrada
        {
            get { return cilindrada; }
            set { cilindrada = value; }
        }

        public Mota()
        {
            this.cilindrada = "NN";
        }

        public Mota(string cilindrada)
        {
            this.Cilindrada = cilindrada;
        }

        public Mota(Mota m)
        {
            this.Cilindrada = m.Cilindrada;
        }
    }
}
