using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSOrderer
{
    class Program
    {

        static void Main(string[] args) {
            //Se define el menú principal
            string message = "Welcome to HeadSort vector orderer"; //Mensaje a mostrar en el menú
            string bmRepeat = new string('═', 80); //Border Message = Borde del mensaje
            string voidChar = "".PadRight(23); //Método para generar carácteres vacíos

            Console.WriteLine('╔' + bmRepeat + '╗');
            Console.WriteLine('║' + voidChar + message + voidChar + '║');
            Console.WriteLine('╚' + bmRepeat + '╝');
            Console.WriteLine("This is a random generator of numbers from -999 to 1000 \nand then those numbers will be order");
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

//╔      =     ╗
//║            ║
//╚      =     ╝