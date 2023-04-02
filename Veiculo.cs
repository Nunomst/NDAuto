using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            set { estado = value; }
        }

        private bool ValidarMatricula(string matricula)
        {
            if (matricula.Length != 8 || matricula[2] != '-' || matricula[5] != '-')
            {
                return false;
            }

            //(99-AA-AA)
            if (char.IsDigit(matricula[0]) && char.IsDigit(matricula[1]))
            {
                return char.IsLetter(matricula[3]) && char.IsLetter(matricula[4]) && char.IsLetter(matricula[6]) && char.IsLetter(matricula[7]);
            }

            //(AA-AA-99)
            if (char.IsLetter(matricula[0]) && char.IsLetter(matricula[1]))
            {
                return char.IsLetter(matricula[3]) && char.IsLetter(matricula[4]) && char.IsDigit(matricula[6]) && char.IsDigit(matricula[7]);
            }

            //(AA-99-AA)
            if (char.IsLetter(matricula[0]) && char.IsDigit(matricula[1]))
            {
                return char.IsDigit(matricula[3]) && char.IsDigit(matricula[4]) && char.IsLetter(matricula[6]) && char.IsLetter(matricula[7]);
            }
            return false;
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
    }


}
