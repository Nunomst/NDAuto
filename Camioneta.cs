using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ND_Auto
{
    public class Camioneta : Veiculo
    {
        private int numeroEixos;
        public int NumeroEixos
        {
            get { return numeroEixos; }
            set 
            {
                if (value == 2 || value == 3)
                {
                    numeroEixos = value; 
                }
            }
        }

        private int numeroPassageiros;
        public int NumeroPassageiros
        {
            get { return numeroPassageiros; }
            set { numeroPassageiros = value; }
        }
    }
}
