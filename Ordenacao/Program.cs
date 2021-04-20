using System;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;

namespace Ordenacao
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] vetor = GerarVetor(200000, 1, 1000000);
            //GravarVetor(vetor);

            int[] vetor = LerNumeros(30);

            int[] vetorOriginal = new int[vetor.Length];

            for (int i = 0; i < vetor.Length; i++)
            {
                vetorOriginal[i] = vetor[i];
            }

            InsertionSort insertionSort = new InsertionSort();
            BubbleSort bubbleSort = new BubbleSort();
            MergeSort mergeSort = new MergeSort();
            HeapSort heapSort = new HeapSort();

            int opcao;
            do
            {
                //PrintaVetor(vetorOriginal);

                if (insertionSort.Tempo.ToString() != "00:00:00")
                    Console.WriteLine($"1 - Insertion Sort - Tempo: {insertionSort.Tempo.TotalSeconds}");
                else
                    Console.WriteLine($"1 - Insertion Sort");

                if (bubbleSort.Tempo.ToString() != "00:00:00")
                    Console.WriteLine($"2 - Bubble Sort - Tempo: {bubbleSort.Tempo.TotalSeconds}");
                else
                    Console.WriteLine($"2 - Bubble Sort");
                
                if (mergeSort.Tempo.ToString() != "00:00:00")
                    Console.WriteLine($"3 - Merge Sort - Tempo: {mergeSort.Tempo.TotalSeconds}");
                else
                   Console.WriteLine($"3 - Merge Sort");

                if (heapSort.Tempo.ToString() != "00:00:00")
                    Console.WriteLine($"4 - Heap Sort - Tempo: {heapSort.Tempo.TotalSeconds}");
                else
                    Console.WriteLine($"4 - Heap Sort");

                Console.WriteLine();
                Console.WriteLine("0 - Sair");
                Console.WriteLine();

                Console.Write("Escolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());

                //PrintaVetor(vetorOriginal);

                Console.Clear();

                switch (opcao)
                {
                    case 1:
                        insertionSort.Ordenar(vetor);
                        Console.WriteLine($"Tempo Insertion Sort: {insertionSort.Tempo.TotalSeconds}");
                        //PrintaVetor(Vetor);
                        break;

                    case 2:
                        bubbleSort.Ordenar(vetor);
                        Console.WriteLine($"Tempo Bubble Sort: {bubbleSort.Tempo.TotalSeconds}");
                        //PrintaVetor(vetor);
                        break;

                    case 3:
                        mergeSort.Ordenar(vetor);
                        Console.WriteLine($"Tempo Merge Sort: {mergeSort.Tempo.TotalSeconds}");
                        //PrintaVetor(vetor);
                        break;

                    case 4:                        
                        heapSort.Ordenar(vetor);
                        Console.WriteLine($"Tempo Heap Sort: {heapSort.Tempo.TotalSeconds}");
                        //PrintaVetor(vetor);
                        break;

                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }

                if (opcao != 0)
                {
                    Console.ReadLine();
                    Console.Clear();
                }

            } while (opcao != 0);
        }

        static void PrintaVetor(int[] vetor)
        {
            Console.WriteLine();
            foreach(int element in vetor)
            {
                Console.Write($"{element}, ");
            }

            Console.WriteLine();
            Console.WriteLine();
        }

        static int[] GerarVetor(int tamanho, int min, int max)
        {
            Random random = new Random();
            int[] vetor = new int[tamanho];

            for (int i = 0; i <= vetor.Length - 1; i++)
            {
                vetor[i] = min + random.Next(max);
            }

            return vetor;
        }

        static void GravarVetor(int[] vetor)
        {
            using (StreamWriter Gravar = new StreamWriter("C:\\Users\\leonardo.miranda\\Desktop\\Analise Algoritmos\\algoritmos-ordenacao\\Ordenacao\\numeros.txt", true))
            {
                for (int i = 0; i < vetor.Length; i++)
                {
                    Gravar.WriteLine(vetor[i]);
                }
            }
        }

        static int[] LerNumeros(int quantidadeLinhas)
        {
            string[] lines = System.IO.File.ReadAllLines(@"C:\\Users\\leonardo.miranda\\Desktop\\Analise Algoritmos\\algoritmos-ordenacao\\Ordenacao\\numeros.txt");
            
            int[] vetor = new int[quantidadeLinhas];
            
            for (int i = 0; i < quantidadeLinhas; i++)
            {
                vetor[i] = int.Parse(lines[i]);
            }

            return vetor;
        }
    }
}
