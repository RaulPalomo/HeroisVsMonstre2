namespace LlibreriaHeroisVsMonstre
{
    public class Metodes
    {
       public static bool MainMenu()
       {
            const string MsgEntry = "1. Iniciar una nova batalla\t0. Sortir";
            const int play = 1, exit = 0;
            int option, tries = 0, maxTries = 3;

            Console.WriteLine(MsgEntry);
            do
            {
                option=Convert.ToInt32(Console.ReadLine());
                tries++;
            }while (option != play && option !=exit && tries<maxTries);
            if (tries >= maxTries)
            {
                return false;
            }
            else if (option == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
       }

        public static bool InRange(int num,int min, int max)
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
    }
}