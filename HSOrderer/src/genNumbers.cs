using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HSOrderer;

namespace HSOrderer
{
    public class genNumbers
    {
        public static void GenerateRandomNumbers()
        {
            string message = "Export .txt file with numbers generated!"; //Mensaje a mostrar en el menú
            string bmRepeat = new string('═', 80); //Border Message = Borde del mensaje
            string voidChar = "".PadRight(20); //Método para generar carácteres vacíos

            Console.WriteLine('╔' + bmRepeat + '╗');
            Console.WriteLine('║' + voidChar + message + voidChar + '║');
            Console.WriteLine('╚' + bmRepeat + '╝');

            int count;
            count = Convert.ToInt32(Console.ReadLine());

            Random rdn = new Random(); //Se inicializa la función random.

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(rdn.Next(-1000, 999)); //Siempre se generará un número en ese rango y se imprimirá
            }
        }
    }
}
