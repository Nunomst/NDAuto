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
    }
}
