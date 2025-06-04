using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperFacturacion.CONTROLADOR
{
    public class UserNameGenerator
    {
        private static Random random = new Random();
        public  string UserGenerato(string nombreCompleto)
        {
            string digitos = random.Next(1000, 9999).ToString();

            // Generar 2 letras aleatorias
            char letra1 = (char)random.Next('A', 'Z' + 1);
            char letra2 = (char)random.Next('A', 'Z' + 1);
            string letras = $"{letra1}{letra2}";
            string nombreSinEspacios = nombreCompleto.Replace(" ", "");


            return $"{nombreSinEspacios}{letras}{digitos}";

        }
    }
}
