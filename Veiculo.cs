using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ND_Auto
{
    public class Veiculo
    {
        private string matricula;
        public string Matricula
        {
            get { return matricula; }
            set
            {
                if (ValidarMatricula(value))
                {
                    matricula = value;
                }
                else
                {
                    throw new ArgumentException("Matricula inválida!");
                }
            }
        }

        private string marca;
        public string Marca
        {
            get { return marca; }
            set { marca = value; } 
        }

        private string modelo;
        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }

        private DateTime ano;
        public DateTime Ano
        {
            get { return ano; }
            set
            {
                if (value.Year >= 2018 && value <= DateTime.Now)
                {
                    ano = value;
                }
            }
        }

        private int kms;
        public int Kms
        {
            get { return kms; }
            set { kms = value; }
        }

        private bool higiene;
        public bool Higiene
        {
            get { return higiene; }
            set { higiene = value; }
        }

        private string estado;
        public string Estado
        {
            get { return estado; }
            set {
                  try{
                        ValidarEstado(value);
                        estado = value;
                  }
                  catch(ArgumentException ex)
                  {
                        MessageBox.Show(ex.Message);
                  }
            }
        }

        public Veiculo()
        {
            this.matricula = "XX-XX-XX";
            this.marca = "NN";
            this.modelo = "NN";
            this.ano = default(DateTime);
            this.kms = 0;
            this.higiene = false;
            this.estado = "NN";
        }

        public Veiculo(string matricula, string marca, string modelo, DateTime ano, int kms, bool higiene, string estado)
        {
            this.Matricula = matricula;
            this.Marca = marca;
            this.Modelo = modelo;
            this.Ano = ano;
            this.Kms = kms;
            this.Higiene = higiene;
            this.Estado = estado;
        }

        public Veiculo(Veiculo v)
        {
            this.Matricula = v.Matricula;
            this.Marca = v.Marca;
            this.Modelo = v.Modelo;
            this.Ano = v.Ano;
            this.Kms = v.Kms;
            this.Higiene = v.Higiene;
            this.Estado = v.Estado;
        }
        private bool ValidarMatricula(string matricula)
        {
            if (matricula.Length != 8 || matricula[2] != '-' || matricula[5] != '-')
            {
                return false;
            }

            //(99-AA-99)
            //if (char.IsDigit(matricula[0]) && char.IsDigit(matricula[1]))
            //{
            //    return char.IsLetter(matricula[3]) && char.IsLetter(matricula[4]) && char.IsLetter(matricula[6]) && char.IsLetter(matricula[7]);
            //}

            if (char.IsDigit(matricula[0]) && char.IsDigit(matricula[1]) && char.IsLetter(matricula[3]) && char.IsLetter(matricula[4]) && char.IsDigit(matricula[6]) && char.IsDigit(matricula[7]))
            {
                return true;
            }

            //(AA-99-AA)
            if (char.IsLetter(matricula[0]) && char.IsLetter(matricula[1]) && char.IsDigit(matricula[3]) && char.IsDigit(matricula[4]) && char.IsLetter(matricula[6]) && char.IsLetter(matricula[7]))
            {
                return true;
            }
            return false;
        }

        public string ValidarEstado(string estado)
        {
            string estadoDisponivel = "Disponível";
            string estadoAlugado = "Alugado";
            string estadoResevado = "Reservado";
            string estadoManutencao = "Em Manutenção";

            if(estado == estadoDisponivel){return estadoDisponivel;}
            if(estado == estadoAlugado) { return estadoAlugado; }
            if(estado == estadoResevado) { return estadoResevado; } 
            if(estado == estadoManutencao) { return estadoManutencao; }
            else { throw new ArgumentException("Estado Inválido!"); }
        }
    }
}
