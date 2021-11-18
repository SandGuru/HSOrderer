using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.IO;
using System.Threading;
using HSOrderer.src;
using HSOrderer;
using System.Diagnostics;

namespace HSOrderer
{
    public class genNumbers
    {
        public static void GenerateRandomNumbers()
        {
            string message = "Export .txt file with numbers generated "; //Mensaje a mostrar en el menú
            string bmRepeat = new string('═', 80); //Border Message = Borde del mensaje
            string voidChar = "".PadRight(20); //Método para generar carácteres vacíos

            //Mensaje del menú
            Console.WriteLine('╔' + bmRepeat + '╗');
            Console.WriteLine('║' + voidChar + message + voidChar + '║');
            Console.WriteLine('╚' + bmRepeat + '╝');
            Console.WriteLine("- Enter 0 to go to main menu\n");
            Console.WriteLine("Enter the range of numbers that you want generate");

            int range;
            range = Convert.ToInt32(Console.ReadLine());

            while (range == 0) //Si insierta 0, se devuelve al menú
            {
                System.Console.Clear();
                main.Main();
                break;
            }

            Random rdn = new Random(); //Se inicializa la función random.

            Console.WriteLine("\nEnter a name to the file:");
            string fileName = Console.ReadLine(); //Asignar un nombre al archivo a exportar
            string path = "../../../files/";

            System.Diagnostics.Stopwatch watch = new System.Diagnostics.Stopwatch(); //Se inicializa la función temporizador
            watch.Start();
            using (StreamWriter outputFile = new StreamWriter(path + fileName + ".txt")) //Se establece la ruta de guardado
            {
                for (int i = 0; i < range; i++)
                {
                    outputFile.WriteLine(rdn.Next(-1000, 999)); //Siempre se generará un número en ese rango y se guardará
                }
                outputFile.Close();
                watch.Stop();
                Console.WriteLine("\nTime taken {0} generating {1} numbers", watch.Elapsed, range);
            }
            Thread.Sleep(10000);
            System.Console.Clear();
            main.Main();
        }

    }
}
