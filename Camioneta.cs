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

        public Camioneta() : base()
        {
            this.numeroEixos = 0;
            this.numeroPassageiros = 0;
        }

        public Camioneta(string matricula, string marca, string modelo, DateTime ano, int kms, bool higiene, string estado, int numeroEixos, int numeroPassageiros) : base(matricula, marca, modelo, ano, kms, higiene, estado)
        {
            NumeroEixos = numeroEixos;
            NumeroPassageiros = numeroPassageiros;
        }

        public Camioneta(Camioneta c) : base(c.Matricula, c.Marca, c.Modelo, c.Ano, c.Kms, c.Higiene, c.Estado)
        {
            this.NumeroEixos = c.NumeroEixos;
            this.NumeroPassageiros = c.NumeroPassageiros;
        }
    }
}
