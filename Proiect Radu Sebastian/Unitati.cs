using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_Radu_Sebastian
{
     public class Unitati
     {
         private Boolean RON { set; get; }
         private Boolean EUR { set; get; }
         private Boolean USD
        {
            set; get;
        }

         public Unitati() { }
         public Unitati(Boolean RON,Boolean EUR, Boolean USD)
         {
             this.RON = RON;
             this.EUR = EUR;
             this.USD = USD;
         }



     }
 
/*
    public enum UnitateMasura
    {
        RON,
        EUR,
        USD
    }

    public class SelectareUnitateMasura
    {
        private UnitateMasura unitateSelectata;

        public UnitateMasura UnitateSelectata
        {
            get { return unitateSelectata; }
            set { unitateSelectata = value; }
        }
    }   */
}
