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

        public Camiao() : base()
        {
            this.pesoMaximo = 0;
        }

        public Camiao(string matricula, string marca, string modelo, DateTime ano, int kms, bool higiene, string estado, int pesoMaximo) : base(matricula, marca, modelo, ano, kms, higiene, estado)
        {
            this.PesoMaximo = pesoMaximo;
        }

        public Camiao(Camiao c) : base(c.Matricula, c.Marca, c.Modelo, c.Ano, c.Kms, c.Higiene, c.Estado)
        {
            this.PesoMaximo = c.PesoMaximo;
        }
    }
}
