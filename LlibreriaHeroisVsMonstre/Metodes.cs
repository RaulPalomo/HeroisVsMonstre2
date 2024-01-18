using System.Runtime.InteropServices;

namespace LlibreriaHeroisVsMonstre
{
    public class Metodes
    {

        public static bool InRange(double num,int min, int max)
        {
            if (num < min || num > max)
            {
                Console.WriteLine($"El valor ha d'estar entre el {min} i el {max}");
                return true;
            }
            else
            {
                return false;
            }
        }
        public static double RandomStats(int min,int max)
        {
            Random rand= new Random();
            return rand.Next(min, max + 1);
        }

        public static double CustomStats(int num,int min, int max)
        {
            int tries=0;
            const int maxTries = 3;
            do
            {
                num = Convert.ToInt32(Console.ReadLine());
                tries++;
            } while (InRange(num,min,max)&&tries<maxTries);
            if(num>max||num<min)
            {
                num = min;
                Console.WriteLine($"Com has superat els 3 intents el valor serà {num}");
            }
            return num;
        }
    }
}