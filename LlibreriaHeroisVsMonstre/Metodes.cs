namespace LlibreriaHeroisVsMonstre
{
    public class Metodes
    {
       public static bool MainMenu()
       {
            const string MsgEntry = "1. Iniciar una nova batalla\t0. Sortir";
            const int play = 1, exit = 0;
            int option;

            Console.WriteLine(MsgEntry);
            do
            {
                option=Convert.ToInt32(Console.ReadLine());
            }while (option != play && option !=exit);
            if (option == 0)
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
            if (num < min&& num > max)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}