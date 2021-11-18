using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HSOrderer.services;

namespace HSOrderer.src
{
    public class readFile
    {
        public static void ReadTxtFile()
        {
            string message = "Read .txt files to sort them by vector"; //Mensaje a mostrar en el menú
            string bmRepeat = new string('═', 80); //Border Message = Borde del mensaje
            string voidChar = "".PadRight(21); //Método para generar carácteres vacíos
            string path = "../../../files/";

            //Mensaje del menú
            Console.WriteLine('╔' + bmRepeat + '╗');
            Console.WriteLine('║' + voidChar + message + voidChar + '║');
            Console.WriteLine('╚' + bmRepeat + '╝');
            Console.WriteLine("- Enter 0 to go to main menu\n");
            Console.WriteLine("Enter the file name to read: ");
            string fileName = Console.ReadLine();

            do
            {
                if (fileName == "0")
                {
                    Console.Clear();
                    main.Main();
                    break;
                }
                else
                {
                    continue;
                }
            }
            while (fileName == "0");
            HeapSort.Execute(path, fileName);
        }
    }
}
