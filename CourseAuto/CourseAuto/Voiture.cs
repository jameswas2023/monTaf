using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseAuto
{
    public class Voiture
    {

        public string Marque { get; set; }
        public decimal VitMin { get; set; }
        public decimal VitMax { get; set; }
        
        public Voiture(string marque, int vitMin, int vitMax) 
        {

            Marque = marque;
            VitMin = vitMin;
            VitMax = vitMax;

        }

        
    }
}
