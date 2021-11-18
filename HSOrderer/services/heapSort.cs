using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Diagnostics;
using HSOrderer.src;
using System.Threading.Tasks;
using System.Threading;

namespace HSOrderer.services
{
    public class HeapSort
    {
        public void sort(List<int>textFileNumbers)
        {
            int n = textFileNumbers.Count;

            // Construir el montón (reordenar el vector)
            for (int i = n / 2 - 1; i >= 0; i--)
                heapify(textFileNumbers, n, i);

            // Extraer cada elemento del montón
            for (int i = n - 1; i > 0; i--)
            {
                // Mover la raíz actual al final
                int temp = textFileNumbers[0];
                textFileNumbers[0] = textFileNumbers[i];
                textFileNumbers[i] = temp;

                // Llamar el máximo heapify en el montón reducido
                heapify(textFileNumbers, i, 0);
            }
        }

        void heapify(List<int> textFileNumbers, int n, int i)
        {
            int largest = i; // Inicializar el más grande como raíz
            int l = 2 * i + 1; // izquierda = 2*i + 1
            int r = 2 * i + 2; // derecha = 2*i + 2

            // Si el hijo izquierdo es mayor que la raíz
            if (l < n && textFileNumbers[l] > textFileNumbers[largest])
                largest = l;

            // Si el hijo derecho es mayor que el mayor hasta ahora
            if (r < n && textFileNumbers[r] > textFileNumbers[largest])
                largest = r;

            // Si el mayor no es la raíz
            if (largest != i)
            {
                int swap = textFileNumbers[i];
                textFileNumbers[i] = textFileNumbers[largest];
                textFileNumbers[largest] = swap;

                // Recolectar el subárbol afectado
                heapify(textFileNumbers, n, largest);
            }
        }

        /* Una función de utilidad para imprimir un vector de tamaño n */
        static void printArray(List<int> textFileNumbers)
        {
            int n = textFileNumbers.Count;
            for (int i = 0; i < n; ++i)
                Console.Write(textFileNumbers[i] + " ");
            Console.Read();
        }

        // Ejecución del ordenamiento
        public static void Execute(string path, string fileName)
        {
            System.Diagnostics.Stopwatch watch = new System.Diagnostics.Stopwatch(); // Se inicializa la función temporizador

            List<int> textFileNumbers = new List<int>(); // Lista de almacenamiento
            int[] arr = {};
            int n = arr.Length;

            watch.Start();
            StreamReader read = new StreamReader(path + fileName + ".txt"); // Se lee el archivo de la ruta
            {
                while (!read.EndOfStream)
                {
                    int x = Convert.ToInt32(read.ReadLine());
                    textFileNumbers.Add(x);
                }
            }
            // Se envía la lista al método de ordenamiento
            HeapSort ob = new HeapSort();
            ob.sort(textFileNumbers);

            //Imprime el vector ordenado
            if (Convert.ToInt32(textFileNumbers.Count) < 50)
            {
                Console.WriteLine("\nSorted vector is");
                printArray(textFileNumbers);
            }
            else
            {
                using (TextWriter outputFile = new StreamWriter(path + fileName + "Sorted" + ".txt")) // Se establece la ruta de guardado del vector ordenado
                {
                    foreach (int i in textFileNumbers)
                    {
                        outputFile.WriteLine(i);                    }
                }
                Console.WriteLine("File is very long, it was exported.");
                watch.Stop();
            }

            Console.WriteLine("\nTime taken {0} sorting '{1}' file", watch.Elapsed, fileName);
            Thread.Sleep(10000);
            System.Console.Clear();
            main.Main();

        }
    }
}