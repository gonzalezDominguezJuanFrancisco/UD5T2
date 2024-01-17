using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UD5T2.MVVM.Views
{
    // Esta clase representa un calculador de índice de masa corporal (IMC) siguiendo el patrón MVVM.
    public class BMI : INotifyPropertyChanged
    {
        // Campo para almacenar el valor de la altura en centímetros.
        public float altura;

        // Propiedad que representa la altura en centímetros.
        public float Altura
        {
            get { return altura; }
            set
            {
                // Verifica si el valor ha cambiado antes de actualizar y notificar.
                if (altura != value)
                {
                    altura = value;

                    // Notifica que la propiedad 'Altura' ha cambiado.
                    OnPropertyChanged(nameof(Altura));

                    // Recalcula y notifica los cambios para propiedades dependientes.
                    OnPropertyChanged(nameof(Resultado));
                    OnPropertyChanged(nameof(ResultadoBMI));
                }
            }
        }

        // Campo para almacenar el valor del peso en kilogramos.
        public float peso;

        // Propiedad que representa el peso en kilogramos.
        public float Peso
        {
            get { return peso; }
            set
            {
                // Verifica si el valor ha cambiado antes de actualizar y notificar.
                if (peso != value)
                {
                    peso = value;

                    // Notifica que la propiedad 'Peso' ha cambiado.
                    OnPropertyChanged(nameof(Peso));

                    // Recalcula y notifica los cambios para propiedades dependientes.
                    OnPropertyChanged(nameof(Resultado));
                    OnPropertyChanged(nameof(ResultadoBMI));
                }
            }
        }

        // Propiedad que representa el resultado calculado del IMC.
        public float Resultado
        {
            get
            {
                // Calcula el IMC utilizando la fórmula proporcionada.
                if (Altura != 0)
                {
                    return Peso / (Altura * Altura) * 10000;
                }
                else
                {
                    return 0;
                }
            }
        }

        // Propiedad que representa una descripción textual basada en el resultado del IMC.
        public string ResultadoBMI
        {
            get
            {
                // Clasifica el resultado del IMC en categorías y devuelve una cadena correspondiente.
                if (Resultado <= 16)
                {
                    return "IMC: Delgado Severo";
                }
                else if (Resultado <= 17)
                {
                    return "IMC: Delgado Moderado";
                }
                else if (Resultado <= 18.5)
                {
                    return "IMC: Delgado Medio";
                }
                else if (Resultado <= 25)
                {
                    return "IMC: Normal";
                }
                else if (Resultado <= 30)
                {
                    return "IMC: Sobrepeso";
                }
                else if (Resultado <= 35)
                {
                    return "IMC: Obesidad Clase I";
                }
                else if (Resultado <= 40)
                {
                    return "IMC: Obesidad Clase II";
                }
                else
                {
                    return "IMC: Obesidad Clase III";
                }
            }
        }

        // Evento que se dispara cuando una propiedad cambia.
        public event PropertyChangedEventHandler? PropertyChanged;

        // Método protegido virtual para invocar el evento PropertyChanged.
        protected virtual void OnPropertyChanged(string propertyName)
        {
            // Invoca el evento indicando que la propiedad con el nombre proporcionado ha cambiado.
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}