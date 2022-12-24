using System;
namespace ConsoleApp;
class Program
{
    static void Main(string[] args)
    {
        menu();
    }

    static void menu()
    {
        int[] vector = new int[10];
        int opc;
        do
        {
            Console.Write("\nDEBER 02 - ORDENAMIENTO \n" +
                "--Menu-- \n" +
                "1. Generar vector \n" +
                "2. Desordenar vector \n" +
                "3. Ordenacion burbuja \n" +
                "4. Ordenacio burbuja paso a paso con tiempo \n" +
                "5. Ordenacion por seleccion \n" +
                "6. Ordenacion por seleccion paso a paso con tiempo \n" +
                "7. Ordenacion por insercion \n" +
                "8. Ordenacion por insercion paso a paso con tiempo \n" +
                "9. Ordenacion por Quicksort \n" +
                "10. Ordenacion por Quicksort paso a paso con tiempo \n" +
                "0. Salir \n" +
                "Seleccione: ");
            opc = Convert.ToInt32(Console.ReadLine());
            switch (opc)
            {
                case 0: //salir
                    Environment.Exit(0);
                    break;
                case 1: //generar vector
                    llenarVector(vector);
                    Console.Write("\nEl vector desordenado es: \n");
                    imprimirVector(vector);
                    break;
                case 2: //desordenar vector
                    desordenarVector(vector);
                    Console.Write("\nEl nuevo orden del vector es: \n");
                    imprimirVector(vector);
                    break;
                case 3: //Ordenacion burbuja
                    Console.Write("\nEl vector desordenado es: \n");
                    imprimirVector(vector);
                    ordenacionBurbuja(vector);
                    Console.Write("\nEl vector ordenado con burbuja es: \n");
                    imprimirVector(vector);
                    break;
                case 4: //Ordenacio burbuja paso a paso con tiempo
                    Console.Write("\nEl vector desordenado es: \n");
                    imprimirVector(vector);
                    Console.Write("\nProceso de ordenado con burbuja paso a paso\n");
                    Console.Write("Comienza burbuja: \t\t\t\tCambio \t\tPasada \n");
                    ordenacionBurbujaTiempo(vector);
                    Console.Write("\nEl vector ordenado con burbuja es: \n");
                    imprimirVector(vector);
                    break;
                case 5: //Ordenacion por seleccion
                    Console.Write("\nEl vector desordenado es: \n");
                    imprimirVector(vector);
                    ordenacionSeleccion(vector);
                    Console.Write("\nEl vector ordenado con seleccion es: \n");
                    imprimirVector(vector);
                    break;
                case 6: //Ordenacion por seleccion paso a paso con tiempo
                    Console.Write("\nEl vector desordenado es: \n");
                    imprimirVector(vector);
                    Console.Write("\nProceso de ordenado con seleccion paso a paso\n");
                    Console.Write("Comienza seleccion: \t\t\t\tCambio \t\tPasada \n");
                    ordenacionSeleccionTiempo(vector);
                    Console.Write("\nEl vector ordenado con seleccion es: \n");
                    imprimirVector(vector);
                    break;
                case 7: //Ordenacion por insercion
                    Console.Write("\nEl vector desordenado es: \n");
                    imprimirVector(vector);
                    ordenacionInsercion(vector);
                    Console.Write("\nEl vector ordenado con insercion es: \n");
                    imprimirVector(vector);
                    break;
                case 8: //Ordenacion por insercion paso a paso con tiempo
                    Console.Write("\nEl vector desordenado es: \n");
                    imprimirVector(vector);
                    Console.Write("\nProceso de ordenado con insercion paso a paso\n");
                    Console.Write("Comienza insercion: \n");
                    ordenacionInsercionTiempo(vector);
                    Console.Write("\nEl vector ordenado con insercion es: \n");
                    imprimirVector(vector);
                    break;
                case 9: //Ordenacion por Quicksort
                    Console.Write("\nEl vector desordenado es: \n");
                    imprimirVector(vector);
                    ordenacionIQuicksort(vector, 0, (vector.Length - 1));
                    Console.Write("\nEl vector ordenado con QuickSort es: \n");
                    imprimirVector(vector);
                    break;
                case 10: //Ordenacion por Quicksort paso a paso con tiempo
                    Console.Write("\nEl vector desordenado es: \n");
                    imprimirVector(vector);
                    Console.Write("\nProceso de ordenado con QuickSort paso a paso\n");
                    Console.Write("Comienza QuickSort: \t\t\t\tCambio \t\tPasada \n");
                    ordenacionIQuicksortTiempo(vector, 0, (vector.Length - 1));
                    Console.Write("\nEl vector ordenado con QuickSort es: \n");
                    imprimirVector(vector);
                    break;
                default:
                    Console.Write("---ERROR---\n" +
                                "Opcion no valida, reintentelo");
                    break;
            }
        } while (opc > -1 && opc < 11);
    }

    static void imprimirVector(int[] vector)
    {
        Console.Write(" | ");
        foreach (int num in vector)
        {
            Console.Write(num + " | ");
        }
        Console.Write("\n");
    }

    static void llenarVector(int[] vector)
    {
        Random random = new Random();
        for (int i = 0; i < vector.Length; i++)
        {
            vector[i] = random.Next(1, 100);
        }
    }

    static void desordenarVector(int[] vector)
    {
        Random rnd = new Random();
        for (int i = vector.Length - 1; i > 0; i--)
        {
            int j = rnd.Next(i + 1);
            int temp = vector[i];
            vector[i] = vector[j];
            vector[j] = temp;
        }
    }

    static void ordenacionBurbuja(int[] vector)
    {
        int temp;
        for (int i = 0; i < vector.Length - 1; i++)
        {
            for (int j = 0; j < vector.Length - 1; j++)
            {
                if (vector[j] > vector[j + 1])
                {
                    temp = vector[j];
                    vector[j] = vector[j + 1];
                    vector[j + 1] = temp;
                }
            }
        }
    }

    static void ordenacionBurbujaTiempo(int[] vector)
    {
        int temp, tiempo1, tiempo2, aux;
        tiempo1 = int.Parse($"{DateTime.Now:fffff}");
        for (int i = 0; i < vector.Length - 1; i++)
        {
            for (int j = 0; j < vector.Length - 1; j++)
            {
                if (vector[j] > vector[j + 1])
                {
                    temp = vector[j];
                    vector[j] = vector[j + 1];
                    vector[j + 1] = temp;
                }
                for (int k = 0; k < vector.Length; k++)
                {
                    Console.Write(vector[k] + " ");
                }
                Console.Write("\t\t\t" + vector[j] + " " + vector[j + 1] + " " + "\t\t" + i + "\n");
            }
        }
        tiempo2 = int.Parse($"{DateTime.Now:fffff}");
        aux = tiempo2 - tiempo1;
        Console.Write("Hora de inicio: " + $"{DateTime.Now:HH:mm:ss}" + ":" + tiempo1 + "\n");
        Console.Write("Hora de finalizacion: " + $"{DateTime.Now:HH:mm:ss}" + ":" + tiempo2 + "\n");
        Console.Write("El tiempo de ejecucion para ordenamiento burbuaja fue de " + aux + " milisegundos");
    }

    static void ordenacionSeleccion(int[] vector)
    {
        int temp, menor;
        for (int i = 0; i < vector.Length - 1; i++)
        {
            menor = i;
            for (int j = i + 1; j < vector.Length; j++)
            {
                if (vector[j] < vector[menor])
                {
                    menor = j;
                }
            }
            temp = vector[menor];
            vector[menor] = vector[i];
            vector[i] = temp;
        }
    }

    static void ordenacionSeleccionTiempo(int[] vector)
    {
        int temp, menor, tiempo1, tiempo2, aux;
        tiempo1 = int.Parse($"{DateTime.Now:fffff}");
        for (int i = 0; i < vector.Length - 1; i++)
        {
            menor = i;
            for (int j = i + 1; j < vector.Length; j++)
            {
                if (vector[j] < vector[menor])
                {
                    menor = j;
                }
            }
            temp = vector[menor];
            vector[menor] = vector[i];
            vector[i] = temp;
            for (int k = 0; k < vector.Length; k++)
            {
                Console.Write(vector[k] + " ");
            }
            Console.Write("\t\t\t" + vector[menor] + " " + vector[i] + " " + "\t\t" + i + "\n");
        }
        tiempo2 = int.Parse($"{DateTime.Now:fffff}");
        aux = tiempo2 - tiempo1;
        Console.Write("Hora de inicio: " + $"{DateTime.Now:HH:mm:ss}" + ":" + tiempo1 + "\n");
        Console.Write("Hora de finalizacion: " + $"{DateTime.Now:HH:mm:ss}" + ":" + tiempo2 + "\n");
        Console.Write("El tiempo de ejecucion para ordenamiento seleccion fue de " + aux + " milisegundos");
    }

    static void ordenacionInsercion(int[] vector)
    {
        int temp, j;
        bool encontrado;
        for (int i = 0; i < vector.Length; i++)
        {
            temp = vector[i];
            j = i - 1;
            encontrado = false;
            while ((j >= 0) && !encontrado)
            {
                if (vector[j] > temp)
                {
                    vector[j + 1] = vector[j];
                    j--;
                }
                else
                {
                    encontrado = true;
                }
            }
            vector[j + 1] = temp;
        }
    }

    static void ordenacionInsercionTiempo(int[] vector)
    {
        int temp, tiempo1, tiempo2, aux, j;
        tiempo1 = int.Parse($"{DateTime.Now:fffff}");
        bool encontrado;
        for (int i = 0; i < vector.Length; i++)
        {
            temp = vector[i];
            j = i - 1;
            encontrado = false;
            while ((j >= 0) && !encontrado)
            {
                if (vector[j] > temp)
                {
                    vector[j + 1] = vector[j];
                    j--;
                }
                else
                {
                    encontrado = true;
                }
            }
            vector[j + 1] = temp;
            for (int k = 0; k < vector.Length; k++)
            {
                Console.Write(vector[k] + " ");
            }
            Console.Write("\n");
        }
        tiempo2 = int.Parse($"{DateTime.Now:fffff}");
        aux = tiempo2 - tiempo1;
        Console.Write("Hora de inicio: " + $"{DateTime.Now:HH:mm:ss}" + ":" + tiempo1 + "\n");
        Console.Write("Hora de finalizacion: " + $"{DateTime.Now:HH:mm:ss}" + ":" + tiempo2 + "\n");
        Console.Write("El tiempo de ejecucion para ordenamiento seleccion fue de " + aux + " milisegundos");
    }

    static void ordenacionIQuicksort(int[] vector, int primero, int ultimo)
    {
        int central, pivote;
        central = (primero + ultimo) / 2;
        pivote = vector[central];
        int i = primero;
        int j = ultimo;
        do
        {
            while (vector[i] < pivote) i++;
            while (vector[j] > pivote) j--;
            if (i <= j)
            {
                int temp;
                temp = vector[i];
                vector[i] = vector[j];
                vector[j] = temp;
                i++;
                j--;
            }
        } while (i <= j);
        if (primero < j)
        {
            ordenacionIQuicksort(vector, primero, j);
        }
        if (i < ultimo)
        {
            ordenacionIQuicksort(vector, i, ultimo);
        }
    }

    static void ordenacionIQuicksortTiempo(int[] vector, int primero, int ultimo)
    {
        int tiempo1, tiempo2, aux;
        tiempo1 = int.Parse($"{DateTime.Now:fffff}");
        int central, pivote;
        central = (primero + ultimo) / 2;
        pivote = vector[central];
        int i = primero;
        int j = ultimo;
        do
        {
            while (vector[i] < pivote) i++;
            while (vector[j] > pivote) j--;
            if (i <= j)
            {
                int temp;
                temp = vector[i];
                vector[i] = vector[j];
                vector[j] = temp;
                i++;
                j--;
            }
        } while (i <= j);
        if (primero < j)
        {
            ordenacionIQuicksort(vector, primero, j);
        }
        if (i < ultimo)
        {
            ordenacionIQuicksort(vector, i, ultimo);
        }
        for (int k = 0; k < vector.Length; k++)
        {
            Console.Write(vector[k] + " ");
        }
        //Console.Write("\n");
        Console.Write("\t\t\t" + vector[i+1] + " " + vector[i] + " " + "\t\t" + i + "\n");
        tiempo2 = int.Parse($"{DateTime.Now:fffff}");
        aux = tiempo2 - tiempo1;
        Console.Write("Hora de inicio: " + $"{DateTime.Now:HH:mm:ss}" + ":" + tiempo1 + "\n");
        Console.Write("Hora de finalizacion: " + $"{DateTime.Now:HH:mm:ss}" + ":" + tiempo2 + "\n");
        Console.Write("El tiempo de ejecucion para ordenamiento seleccion fue de " + aux + " milisegundos");
    }
}