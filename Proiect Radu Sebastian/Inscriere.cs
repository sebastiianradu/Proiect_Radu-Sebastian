using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_Radu_Sebastian
{
    public class Inscriere: ICloneable
    {
        private string nume { get; set; }
    
        private string prenume { get; set; }
        
        private string email { get; set; }

        public Inscriere() { }
        public Inscriere(string nume, string prenume, string email)
        {
            this.nume = nume;
            this.prenume = prenume;
            this.email = email;
        }

        public string Nume { get => nume; set => nume = value; }
        public string Prenume { get => nume; set => nume = value; }
        public string Email { get => nume; set => nume = value; }
        public object Clone()
        {
            
            Inscriere clonedInscriere = new Inscriere(this.nume, this.prenume, this.email);
            return clonedInscriere;
        }

    }
}
