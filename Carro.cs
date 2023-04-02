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

        public Carro()
        {
            this.numeroPortas = 0;
            this.caixa = "NN";
            this.combustivel = "NN";
        }

        public Carro(int numeroPortas, string caixa, string combustivel)
        {
            this.NumeroPortas = numeroPortas;
            this.Caixa = caixa;
            this.Combustivel = combustivel;
        }

        public Carro(Carro c)
        {
            this.NumeroPortas = c.NumeroPortas;
            this.Caixa = c.Caixa;
            this.Combustivel = c.Combustivel;
        }
    }
}
