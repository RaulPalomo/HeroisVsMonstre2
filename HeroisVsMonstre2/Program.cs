using LlibreriaHeroisVsMonstre;
using System;
namespace RaulProjecteHeroisV2
{
    public class SolucioProjecte
    {
        
        public static void Main()
        {

            //global
            const string MsgWelcome = "Benvingut a HEROIS VS MONSTRE!!!";
            int tries = 0, maxtries = 3;
            bool archerCreated = false, archerShield;
            double archerDmg = 0, archerProtect = 0, archerHPlimit = 0;
            int archerAction, archerCD = 0;
            double archerHealth = 0;
            const int ArcherMaxHealth = 2000, ArcherMinHealth = 1500, ArcherMaxDmg = 300, ArcherMinDmg = 180, ArcherMaxProtect = 40, ArcherMinProtect = 25;

            /*Missatges arquera*/
            const string MsgHealthArcher = "Vida[1500-2000]", MsgDmgArcher = "Atac[180-300]", MsgProtectArcher = "Protecció[25-40]%", MsgArcher = "Introdueix els valors requerits per a l'Arquera: ", MsgHabArcher = ": fa que el monstre no pugui atacar durant 2 torns(CD=5torns)";
            const string MsgTurnArcher = "-----Torn de l'arquera-----";
            const string MsgActivaArcher = "* L'arquera noqueja al monstre *";

            /*Variables i constants del bàrbar*/
            bool barbarianCreated = false, barbarianShield;
            double barbarianDmg = 0, barbarianProtect = 0, barbarianHPlimit = 0;
            int barbarianAction, barbarianCD = 0;
            double barbarianHealth = 0;
            const int BarbarianMaxHealth = 3750, BarbarianMinHealth = 3000, BarbarianMaxDmg = 250, BarbarianMinDmg = 150, BarbarianMaxProtect = 45, BarbarianMinProtect = 35;
            /*Missatges bàrbar*/
            const string MsgHealthBarbarian = "Vida[3000-3750]", MsgDmgBarbarian = "Atac[150-250]", MsgProtectBarbarian = "Protecció[35-45]%", MsgBarbarian = "Introdueix els valors requerits per al bàrbar: ", MsgHabBarbarian = ": augmenta la seva defensa al 100% durant 3 torns(CD=5torns)";
            const string MsgTurnBarbarian = "-----Torn del bàrbar-----";
            const string MsgActivaBarbarian = "* El bàrbar millora al màxim la seva armadura *";

            /*Variables i constants de la maga*/
            bool wizardCreated = false, wizardShield;
            double wizardDmg = 0, wizardProtect = 0, wizardHPlimit = 0;
            int wizardAction, wizardCD = 0;
            double wizardHealth = 0;
            const int WizardMaxHealth = 1500, WizardMinHealth = 1000, WizardMaxDmg = 350, WizardMinDmg = 300, WizardMaxProtect = 35, WizardMinProtect = 20;
            /*Missatges de la maga*/
            const string MsgHealthWizard = "Vida[1000-1500]", MsgDmgWizard = "Atac[300-350]", MsgProtectWizard = "Protecció[20-35]%", MsgWizard = "Introdueix els valors requerits per la maga: ", MsgHabWizard = ": dispara una bola de foc que fa 3 cops el seu atac.\r\n";
            const string MsgTurnWizard = "-----Torn de la maga-----";

            /*Variables i constants del druida*/
            bool druidCreated = false, druidShield;
            double druidDmg = 0, druidProtect = 0, druidHPlimit = 0;
            int druidAction, druidCD = 0;
            double druidHealth = 0;
            const int DruidMaxHealth = 2500, DruidMinHealth = 2000, DruidMaxDmg = 120, DruidMinDmg = 70, DruidMaxProtect = 40, DruidMinProtect = 25, Heal = 500;
            /*Missatges druida*/
            const string MsgHealthDruid = "Vida[2000-2500]", MsgDmgDruid = "Atac[70-120]", MsgProtectDruid = "Protecció[25-40]%", MsgDruid = "Introdueix els valors requerits per al druida: ", MsgHabDruid = ": cura 500 de vida a tots els herois(CD=5torns)";
            const string MsgTurnDruid = "-----Torn del druida-----";
            const string MsgHeal = "* El druida cura 500 de vida a tots els herois *";

            /*Variables i constants del monstre*/
            bool monsterCreated = false;
            double monsterDmg = 0, monsterProtect = 0;
            double monsterHealth = 0;
            const int MonsterMaxHealth = 12000, MonsterMinHealth = 9000, MonsterMaxDmg = 400, MonsterMinDmg = 250, MonsterMaxProtect = 30, MonsterMinProtect = 20;
            /*Missatges monstre*/
            const string MsgHealthMonster = "Vida[9000-12000]", MsgDmgMonster = "Atac[250-400]", MsgProtectMonster = "Protecció[20-30]%", MsgMonster = "Introdueix els valors requerits per al monstre: ";
            //missatges de la dificultad i vars
            const string MsgDifficulty = "Escull quina dificultad vols:";
            string[] dif = { "1. Fàcil", "2. Difícil", "3. Personalitzada", "4. Random" };
            int difficulty=0;
            const int MaxDiff = 4, MinDiff = 1;


            bool enter = false;
            const string MsgEntry = "1. Iniciar una nova batalla\t0. Sortir";
            const string MsgBye = "T'has equivocat masses cops, adéu";
            const int play = 1, exit = 0;
            int option;

            Console.WriteLine(MsgWelcome);
            do
            {
                if (tries < maxtries)
                {
                    tries = 0;
                    Console.WriteLine(MsgEntry);
                    do
                    {
                        option = Convert.ToInt32(Console.ReadLine());
                        tries++;
                    } while (option != play && option != exit && tries < maxtries);
                    if (tries >= maxtries)
                    {
                        enter = false;
                    }
                    else if (option == 0)
                    {
                        enter = false;
                    }
                    else
                    {
                        enter = true;
                    }
                }
                while (enter)
                {
                    tries = 0;
                    Console.WriteLine(MsgDifficulty);
                    for (int i = 0; i < 4; i++)
                    {
                        Console.WriteLine(dif[i]);
                    }
                    do
                    {
                        difficulty = Convert.ToInt32(Console.ReadLine());
                        tries++;

                    } while (Metodes.InRange(difficulty, MinDiff, MaxDiff) && tries < maxtries);

                    switch (difficulty)
                    {
                        case 1:
                            archerHealth = ArcherMaxHealth;
                            archerHPlimit = ArcherMaxHealth;
                            archerDmg = ArcherMaxDmg;
                            archerProtect = ArcherMaxProtect;

                            barbarianHealth = BarbarianMaxHealth;
                            barbarianHPlimit = BarbarianMaxHealth;
                            barbarianDmg = BarbarianMaxDmg;
                            barbarianProtect = BarbarianMaxProtect;

                            wizardHealth = WizardMaxHealth;
                            wizardHPlimit = WizardMaxHealth;
                            wizardDmg = WizardMaxDmg;
                            wizardProtect = WizardMaxProtect;

                            druidHealth = DruidMaxHealth;
                            druidHPlimit = DruidMaxHealth;
                            druidDmg = DruidMaxDmg;
                            druidProtect = DruidMaxProtect;

                            monsterHealth = MonsterMinHealth;
                            monsterDmg = MonsterMinDmg;
                            monsterProtect = MonsterMinProtect;

                            break;
                        case 2:
                            archerHealth = ArcherMinHealth;
                            archerHPlimit = ArcherMinHealth;
                            archerDmg = ArcherMinDmg;
                            archerProtect = ArcherMinProtect;

                            barbarianHealth = BarbarianMinHealth;
                            barbarianHPlimit = BarbarianMinHealth;
                            barbarianDmg = BarbarianMinDmg;
                            barbarianProtect = BarbarianMinProtect;

                            wizardHealth = WizardMinHealth;
                            wizardHPlimit = WizardMinHealth;
                            wizardDmg = WizardMinDmg;
                            wizardProtect = WizardMinProtect;

                            druidHealth = DruidMinHealth;
                            druidHPlimit = DruidMinHealth;
                            druidDmg = DruidMinDmg;
                            druidProtect = DruidMinProtect;

                            monsterHealth = MonsterMaxHealth;
                            monsterDmg = MonsterMaxDmg;
                            monsterProtect = MonsterMaxProtect;
                            break;
                        case 3:
                            Console.WriteLine(MsgArcher); //creació arquera
                            Console.WriteLine(MsgHealthArcher);
                            do
                            {
                                archerHealth = Convert.ToInt32(Console.ReadLine());
                                tries++;
                            } while (Metodes.InRange(archerHealth, ArcherMinHealth, ArcherMaxHealth) && tries < maxtries);
                            if (tries >= maxtries)
                            {
                                
                                archerHealth = ArcherMinHealth;
                                Console.WriteLine($"Has fallat els 3 intents, el valor per aquest camp serà {archerHealth}");
                            }
                            tries = 0;
                            archerHPlimit = archerHealth;
                            Console.WriteLine(MsgDmgArcher);
                            do
                            {
                                archerDmg = Convert.ToInt32(Console.ReadLine());  
                                tries++;
                            } while (Metodes.InRange(archerDmg, ArcherMinDmg, ArcherMaxDmg) && tries < maxtries);

                            if (tries >= maxtries)
                            {
                                
                                archerDmg = ArcherMinDmg;
                                Console.WriteLine($"Has fallat els 3 intents, el valor per aquest camp serà  {archerDmg}");
                            }
                            tries = 0;
                            Console.WriteLine(MsgProtectArcher);
                            do
                            {
                                archerProtect = Convert.ToInt32(Console.ReadLine()); 
                                tries++;
                            } while (Metodes.InRange(archerProtect, ArcherMinProtect, ArcherMaxProtect) && tries < maxtries);

                            if (tries >= maxtries)
                            {
                               
                                archerProtect = ArcherMinProtect;
                                Console.WriteLine($"Has fallat els 3 intents, el valor per aquest camp serà  {archerProtect}");
                            }
                            tries = 0;

                            Console.WriteLine(MsgBarbarian); //creació bàrbar
                            Console.WriteLine(MsgHealthBarbarian);
                            do
                            {
                                barbarianHealth = Convert.ToInt32(Console.ReadLine());
                                tries++;
                            } while (Metodes.InRange(barbarianHealth, BarbarianMinHealth, BarbarianMaxHealth) && tries < maxtries);
                            if (tries >= maxtries)
                            {
                               
                                barbarianHealth = BarbarianMinHealth;
                                Console.WriteLine($"Has fallat els 3 intents, el valor per aquest camp serà {barbarianHealth}");
                            }
                            tries = 0;
                            barbarianHPlimit = barbarianHealth;
                            Console.WriteLine(MsgDmgBarbarian);
                            do
                            {
                                barbarianDmg = Convert.ToInt32(Console.ReadLine());
                                tries++;
                            } while (Metodes.InRange(barbarianDmg, BarbarianMinDmg, BarbarianMaxDmg) && tries < maxtries);

                            if (tries >= maxtries)
                            {
                                
                                barbarianDmg = BarbarianMinDmg;
                                Console.WriteLine($"Has fallat els 3 intents, el valor per aquest camp serà {barbarianDmg}");
                            }
                            tries = 0;
                            Console.WriteLine(MsgProtectBarbarian);
                            do
                            {
                                barbarianProtect = Convert.ToInt32(Console.ReadLine());
                                tries++;
                            } while (Metodes.InRange(barbarianProtect, BarbarianMinProtect, BarbarianMaxProtect) && tries < maxtries);

                            if (tries >= maxtries)
                            {
                                
                                barbarianProtect = BarbarianMinProtect;
                                Console.WriteLine($"Has fallat els 3 intents, el valor per aquest camp serà {barbarianProtect}");
                            }
                            tries=0;
                            Console.WriteLine(MsgWizard); //creació mag
                            Console.WriteLine(MsgHealthWizard);
                            do
                            {
                                wizardHealth = Convert.ToInt32(Console.ReadLine());
                                tries++;
                            } while (Metodes.InRange(wizardHealth, WizardMinHealth, WizardMaxHealth) && tries < maxtries);
                            if (tries >= maxtries)
                            {
                                
                                wizardHealth = WizardMinHealth;
                                Console.WriteLine($"Has fallat els 3 intents, el valor per aquest camp serà {wizardHealth}");
                            }
                            tries = 0;
                            wizardHPlimit = wizardHealth;
                            Console.WriteLine(MsgDmgWizard);
                            do
                            {
                                wizardDmg = Convert.ToInt32(Console.ReadLine());
                                tries++;
                            } while (Metodes.InRange(wizardDmg, WizardMinDmg, WizardMaxDmg) && tries < maxtries);

                            if (tries >= maxtries)
                            {
                                
                                wizardDmg = WizardMinDmg;
                                Console.WriteLine($"Has fallat els 3 intents, el valor per aquest camp serà {wizardDmg}");
                            }
                            tries = 0;
                            Console.WriteLine(MsgProtectWizard);
                            do
                            {
                                wizardProtect = Convert.ToInt32(Console.ReadLine());
                                tries++;
                            } while (Metodes.InRange(wizardProtect, WizardMinProtect, WizardMaxProtect) && tries < maxtries);

                            if (tries >= maxtries)
                            {
                                
                                wizardProtect = WizardMinProtect;
                                Console.WriteLine($"Has fallat els 3 intents, el valor per aquest camp serà {wizardProtect}");
                            }
                            tries = 0;
                            Console.WriteLine(MsgDruid); //creació druida
                            Console.WriteLine(MsgHealthDruid);
                            do
                            {
                                druidHealth = Convert.ToInt32(Console.ReadLine());
                                tries++;
                            } while (Metodes.InRange(druidHealth, DruidMinHealth, DruidMaxHealth) && tries < maxtries);
                            if (tries >= maxtries)
                            {
                                
                                druidHealth = DruidMinHealth;
                                Console.WriteLine($"Has fallat els 3 intents, el valor per aquest camp serà {druidHealth}");
                            }
                            tries = 0;
                            druidHPlimit = druidHealth;
                            Console.WriteLine(MsgDmgDruid);
                            do
                            {
                                druidDmg = Convert.ToInt32(Console.ReadLine());
                                tries++;
                            } while (Metodes.InRange(druidDmg, DruidMinDmg, DruidMaxDmg) && tries < maxtries);

                            if (tries >= maxtries)
                            {
                                
                                druidDmg = DruidMinDmg;
                                Console.WriteLine($"Has fallat els 3 intents, el valor per aquest camp serà {druidDmg}");
                            }
                            tries = 0;
                            Console.WriteLine(MsgProtectDruid);
                            do
                            {
                                druidProtect = Convert.ToInt32(Console.ReadLine());
                                tries++;
                            } while (Metodes.InRange(druidProtect, DruidMinProtect, DruidMaxProtect) && tries < maxtries);

                            if (tries >= maxtries)
                            {
                                
                                druidProtect = DruidMinProtect;
                                Console.WriteLine($"Has fallat els 3 intents, el valor per aquest camp serà {druidProtect}");
                            }
                            tries = 0;

                            Console.WriteLine(MsgMonster); // Creació monstre
                            Console.WriteLine(MsgHealthMonster);
                            do
                            {
                                monsterHealth = Convert.ToInt32(Console.ReadLine());
                                tries++;
                            } while (Metodes.InRange(monsterHealth, MonsterMinHealth, MonsterMaxHealth) && tries < maxtries);
                            if (tries >= maxtries)
                            {

                                monsterHealth = MonsterMaxHealth;
                                Console.WriteLine($"Has fallat els 3 intents, el valor per aquest camp serà {monsterHealth}");
                            }
                            tries = 0;
                            
                            Console.WriteLine(MsgDmgMonster);
                            do
                            {
                                monsterDmg = Convert.ToInt32(Console.ReadLine());
                                tries++;
                            } while (Metodes.InRange(monsterDmg, MonsterMinDmg, MonsterMaxDmg) && tries < maxtries);

                            if (tries >= maxtries)
                            {

                                monsterDmg = MonsterMaxDmg;
                                Console.WriteLine($"Has fallat els 3 intents, el valor per aquest camp serà {monsterDmg}");
                            }
                            tries = 0;
                            Console.WriteLine(MsgProtectMonster);
                            do
                            {
                                monsterProtect = Convert.ToInt32(Console.ReadLine());
                                tries++;
                            } while (Metodes.InRange(monsterProtect, MonsterMinProtect, MonsterMaxProtect) && tries < maxtries);

                            if (tries >= maxtries)
                            {

                                monsterProtect = MonsterMaxProtect;
                                Console.WriteLine($"Has fallat els 3 intents, el valor per aquest camp serà {monsterProtect}");
                            }
                            tries = 0;
                            break;
                        case 4:
                            archerHealth = Metodes.RandomStats(ArcherMinHealth, ArcherMaxHealth);
                            archerHPlimit = archerHealth;
                            archerDmg = Metodes.RandomStats(ArcherMinDmg, ArcherMaxDmg);
                            archerProtect = Metodes.RandomStats(ArcherMinProtect, ArcherMaxProtect);

                            barbarianHealth = Metodes.RandomStats(BarbarianMinHealth, BarbarianMaxHealth);
                            barbarianHPlimit = barbarianHealth;
                            barbarianDmg = Metodes.RandomStats(BarbarianMinDmg, BarbarianMaxDmg);
                            barbarianProtect = Metodes.RandomStats(BarbarianMinProtect, BarbarianMaxProtect);

                            wizardHealth = Metodes.RandomStats(WizardMinHealth, WizardMaxHealth);
                            wizardHPlimit = wizardHealth;
                            wizardDmg = Metodes.RandomStats(WizardMinDmg, WizardMaxDmg);
                            wizardProtect = Metodes.RandomStats(WizardMinProtect, WizardMaxProtect);

                            druidHealth = Metodes.RandomStats(DruidMinHealth, DruidMaxHealth);
                            druidHPlimit = druidHealth;
                            druidDmg = Metodes.RandomStats(DruidMinDmg, DruidMaxDmg);
                            druidProtect = Metodes.RandomStats(DruidMinProtect, DruidMaxProtect);

                            monsterHealth = Metodes.RandomStats(MonsterMaxHealth, MonsterMaxHealth);
                            monsterDmg = Metodes.RandomStats(MonsterMaxDmg, MonsterMaxDmg);
                            monsterProtect = Metodes.RandomStats(MonsterMaxProtect, MonsterMaxProtect);
                            break;
                    }
                    enter = false;

                }
            } while (tries < maxtries);
            if (tries < maxtries)
            {
                Console.WriteLine(MsgBye);
            }
        }
        
    }
}