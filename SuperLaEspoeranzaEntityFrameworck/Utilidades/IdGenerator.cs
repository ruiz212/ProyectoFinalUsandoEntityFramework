using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperFacturacion.CONTROLADOR
{
    public class IdGenerator
    {
        private static Random random = new Random();
        public static string IdGenerates()
        {
            // Generar 4 dígitos aleatorios
            string digitos = random.Next(10000, 99999).ToString();

            // Generar 2 letras aleatorias
            char letra1 = (char)random.Next('A', 'Z' + 1);
            char letra2 = (char)random.Next('A', 'Z' + 1);
            char letra3 = (char)random.Next('A', 'Z' + 1);
            char letra4 = (char)random.Next('A', 'Z' + 1);
            char letra5 = (char)random.Next('A', 'Z' + 1);
            string letras = $"{letra1}{letra2}{letra3}{letra4}{letra5}";

            return $"{digitos}{letras}";
        }

    }
}

