using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_Radu_Sebastian
{
    [Serializable]
    class Sondaje : IEconomii, ICloneable
    {
        private int salariu2023 { get; set; }
        private int mancare { get; set; }
        private int chirie { get; set; }
        private int transport { get; set; }
        private int rate { get; set; }
        private int salariu_ramas { get; set; }

        private int[] array;
        public Sondaje() { }
        public Sondaje(int salariu2023, int mancare, int chirie, int transport, int rate)
        {
            this.salariu2023 = salariu2023;
            this.mancare = mancare;
            this.chirie = chirie;
            this.transport = transport;
            this.rate = rate;
            //this.salariu_ramas = salariu_ramas;
        }

        public int Economii()
        {
            this.salariu_ramas = this.salariu2023 - this.mancare - this.chirie - this.transport - this.rate;
            this.salariu_ramas /= 10;
            return this.salariu_ramas;
        }
        public override string ToString()
        {
            string mesajAfisare = "Din totalul salariului de: " + this.salariu2023 + " ramai cu: " + Economii();
            return mesajAfisare;
        }

        public object Clone()
        {
            throw new NotImplementedException();
        }

        public int this[int index] // Suprascriere index
        {
            get { return array[index]; }
            set { array[index] = value; }
        }

        public IEnumerator GetEnumerator() // Suprascriere foreach
        {
            return array.GetEnumerator();
        }

        //supraincarcare +
        public static Sondaje operator +(Sondaje sondaj1, Sondaje sondaj2)
        {
            int salariu2023 = sondaj1.salariu2023 + sondaj2.salariu2023;
            int mancare = sondaj1.mancare + sondaj2.mancare;
            int chirie = sondaj1.chirie + sondaj2.chirie;
            int transport = sondaj1.transport + sondaj2.transport;
            int rate = sondaj1.rate + sondaj2.rate;

            return new Sondaje(salariu2023, mancare, chirie, transport, rate);
        }
        //supraincarcare -
        public static Sondaje operator -(Sondaje sondaj1, Sondaje sondaj2)
        {
            int salariu2023 = sondaj1.salariu2023 - sondaj2.salariu2023;
            int mancare = sondaj1.mancare - sondaj2.mancare;
            int chirie = sondaj1.chirie - sondaj2.chirie;
            int transport = sondaj1.transport - sondaj2.transport;
            int rate = sondaj1.rate - sondaj2.rate;

            return new Sondaje(salariu2023, mancare, chirie, transport, rate);
        }

        //obligatoriu una dintre clase contine un masiv uni sau
        //bidimensional pentru care se supraincarca index si optional foreach;

    }


}
