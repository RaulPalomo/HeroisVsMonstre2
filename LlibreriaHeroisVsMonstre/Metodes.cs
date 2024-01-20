using System.Reflection.Metadata.Ecma335;
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

        public static double CheeckStat(double num, int min, int max)
        {
            if (num>max || num < min)
            {
                Console.WriteLine($"Has fallat els 3 intents, el valor per aquest camp serà {min}");
                return min;

            }
            else
            {
                return num;
            }
        }
        public static double RandomStats(int min,int max)
        {
            Random rand= new Random();
            return rand.Next(min, max + 1);
        }
         public static int CoolDown(int num)
        {
            if ( num > 0)
            {
                return num-1;
            }
            else { return 0; }
        }

        public static double[] OrderHp(double archerHealth,double barbarianHealth, double wizardHealth, double druidHealth)
        {
            double[] hpOrder = { archerHealth, barbarianHealth, wizardHealth, druidHealth };
            for (int i = 0; i < hpOrder.Length - 1; i++)
            {
                for (int j = i + 1; j < hpOrder.Length; j++)
                {
                    if (hpOrder[j] < hpOrder[i])
                    {
                        double aux = hpOrder[j];
                        hpOrder[j] = hpOrder[i];
                        hpOrder[i] = aux;
                    }
                }
            }
            return hpOrder;
        }
        public static double Damage(double dmg, double prot)
        {
            const int hundred= 100;
            return dmg-dmg * prot/hundred;
        }

        public static bool CriticDmg()
        {
            Random rand=new Random();
            const int luckyNum = 2;
            const int RandLimit= 11;
            int newRand= rand.Next(RandLimit);
            if (newRand == luckyNum)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public static bool Dodge()
        {
            Random rand = new Random();
            const int luckyNum = 7;
            const int RandLimit = 21;
            int newRand = rand.Next(RandLimit);
            if (newRand == luckyNum)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public static double MonsterAttack(double monsterDmg, double protect, bool shield )
        {

            if (shield)
            {          
                return Metodes.Damage(monsterDmg, protect * 2);
            }
            else
            {
                return Metodes.Damage(monsterDmg, protect);
            }
        }
        public static double Heal(double hp, double limitHp)
        {
            if(hp>0)
            {
                hp += 500;
            }
            if(limitHp<hp)
            {
                hp=limitHp;
            }
            return hp;
        }

    }
}