using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HSOrderer.src;

namespace HSOrderer
{
    class main
    {
        public static void Main(string[] args) {
            //Se define el menú principal
            string message = "Welcome to HeadSort vector orderer"; //Mensaje a mostrar en el menú
            string bmRepeat = new string('═', 80); //Border Message = Borde del mensaje
            string voidChar = "".PadRight(23); //Método para generar carácteres vacíos

            Console.WriteLine('╔' + bmRepeat + '╗');
            Console.WriteLine('║' + voidChar + message + voidChar + '║');
            Console.WriteLine('╚' + bmRepeat + '╝');
            Console.WriteLine("This is a random generator of numbers from -999 to 1000 \nand then those numbers will be order\n");
            Console.WriteLine("1. Generate numbers\n" +
                "2. Read .txt file and order it\n\n" +
                "Please, enter a option: ");

            enter_Option:
            int option;
            option = Convert.ToInt32(Console.ReadLine()); //Recibe opción

            do
            {
                if (option == 1)
                {
                    System.Console.Clear();
                    genNumbers.GenerateRandomNumbers();
                    break;
                }
                if (option == 2)
                {
                    System.Console.Clear();
                    readFile.ReadTxtFile();
                    break;
                }
                else
                {
                    Console.WriteLine("\nInvalid option. Please, enter a correct option");
                    goto enter_Option;
                }
            }
            while (option == 1 | option == 2);
            
        }
    }
}





//╔      =     ╗
//║            ║
//╚      =     ╝