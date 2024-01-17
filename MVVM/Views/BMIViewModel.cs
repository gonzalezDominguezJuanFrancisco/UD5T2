using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UD5T2.MVVM.Views
{
    public class BMIViewModel
    {
        public BMI bmi;

        public BMI BMI
        {
            get;set;
           
        }

        public BMIViewModel()
        {
            // Inicializa el objeto BMI con un peso inicial de 50 y una altura inicial de 25
            BMI = new BMI { Peso = 50, Altura = 25 };
        }

        
    }
}
