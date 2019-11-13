using System;

namespace LibreriaArray
{
    public class GestioneArray
    {
        public static void LeggiArray(int[] array)
        {
            for (int x = 0; x < array.Length; x++)
            {
                Console.WriteLine("Inserisci il valore in posizione "+x);
                int n = int.Parse(Console.ReadLine());
                array[x] = n;
            }
        }

    }
}
