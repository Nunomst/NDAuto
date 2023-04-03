using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
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

        public Mota() : base()
        {
            this.cilindrada = "NN";
        }

        public Mota(string matricula, string marca, string modelo, DateTime ano, int kms, bool higiene, string estado, string cilindrada) : base(matricula, marca, modelo, ano, kms, higiene, estado)
        {
            this.Cilindrada = cilindrada;
        }

        public Mota(Mota m) : base(m.Matricula, m.Marca, m.Modelo, m.Ano, m.Kms, m.Higiene, m.Estado)
        {
            this.Cilindrada = m.Cilindrada;
        }
    }
}
