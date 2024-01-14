using System;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;
using LlibreriaHeroisVsMonstre;
namespace RaulProjecteHeroisV2
{
    public class SolucioProjecte
    {
        
        public static void Main()
        {
            //global
            const string MsgWelcome = "Benvingut a HEROIS VS MONSTRE!!!";
            int tries = 0, maxtries = 3;
            
            //missatges de la dificultad i vars
            const string MsgDifficulty = "Escull quina dificultad vols:";
            string[] dif = { "1. Fàcil", "2. Difícil", "3. Personalitzada", "4. Random" };
            int difficulty;
            const int MaxDiff = 4, MinDiff = 1;
            Console.WriteLine(MsgWelcome);
            while (Metodes.MainMenu())
            {
                Console.WriteLine(MsgDifficulty);
                for(int i = 0; i < 4; i++)
                {
                    Console.WriteLine(dif[i]);
                }
                do
                {
                    difficulty = Convert.ToInt32(Console.ReadLine());
                    tries++;
                } while (Metodes.InRange(difficulty, MaxDiff, MinDiff)&& tries<maxtries);
            }
        }
        
    }
}