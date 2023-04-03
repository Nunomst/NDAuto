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
                else
                {
                    throw new ArgumentException("Numero de eixos inválido!");
                }
            }
        }

        private int numeroPassageiros;
        public int NumeroPassageiros
        {
            get { return numeroPassageiros; }
            set { numeroPassageiros = value; }
        }

        public Camioneta()
        {
            this.numeroEixos = 0;
            this.numeroPassageiros = 0;
        }

        public Camioneta(int numeroEixos, int numeroPassageiros)
        {
            NumeroEixos = numeroEixos;
            NumeroPassageiros = numeroPassageiros;
        }

        public Camioneta(Camioneta c)
        {
            this.NumeroEixos = c.NumeroEixos;
            this.NumeroPassageiros = c.NumeroPassageiros;
        }
    }
}
