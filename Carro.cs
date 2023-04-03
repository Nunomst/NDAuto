using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ND_Auto
{
    public class Carro : Veiculo 
    {
        private int numeroPortas;
        public int NumeroPortas
        {
            get { return numeroPortas; }
            set
            {
                if (value == 3 || value == 5)
                {
                    numeroPortas = value;
                }
                else
                {
                    throw new ArgumentException("Numero de portas inválido!");
                }
            }
        }

        private string caixa;
        public string Caixa
        {
            get { return caixa; }
            set { caixa = value; }
        }

        private string combustivel;
        public string Combustivel
        {
            get { return combustivel; }
            set { combustivel = value; }
        }

        public Carro() : base()
        {
            this.numeroPortas = 0;
            this.caixa = "NN";
            this.combustivel = "NN";
        }

        public Carro(string matricula, string marca, string modelo, DateTime ano, int kms, bool higiene, string estado, int numeroPortas, string caixa, string combustivel) : base(matricula, marca, modelo, ano, kms, higiene, estado)
        {
            this.NumeroPortas = numeroPortas;
            this.Caixa = caixa;
            this.Combustivel = combustivel;
        }

        public Carro(Carro c) : base(c.Matricula, c.Marca, c.Modelo, c.Ano, c.Kms, c.Higiene, c.Estado)
        {
            this.NumeroPortas = c.NumeroPortas;
            this.Caixa = c.Caixa;
            this.Combustivel = c.Combustivel;
        }
    }
}
