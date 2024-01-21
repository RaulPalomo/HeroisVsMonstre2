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
            //vars i constants de l'arquera
            bool archerShield=false;
            double archerDmg = 0, archerProtect = 0, archerHPlimit = 0;
            int archerAction, archerCD = 0;
            double archerHealth = 0;
            const int ArcherMaxHealth = 2000, ArcherMinHealth = 1500, ArcherMaxDmg = 300, ArcherMinDmg = 180, ArcherMaxProtect = 40, ArcherMinProtect = 25;

            /*Missatges arquera*/
            const string MsgHealthArcher = "Vida[1500-2000]", MsgDmgArcher = "Atac[180-300]", MsgProtectArcher = "Protecció[25-40]%", MsgArcher = "Introdueix els valors requerits per a l'Arquera: ", MsgHabArcher = ": fa que el monstre no pugui atacar durant 2 torns";
            const string MsgTurnArcher = "-----Torn de l'arquera-----";
            const string MsgActivaArcher = "* L'arquera noqueja al monstre *";

            /*Variables i constants del bàrbar*/
            bool barbarianShield=false;
            double barbarianDmg = 0, barbarianProtect = 0, barbarianHPlimit = 0;
            int barbarianAction, barbarianCD = 0;
            double barbarianHealth = 0;
            const int BarbarianMaxHealth = 3750, BarbarianMinHealth = 3000, BarbarianMaxDmg = 250, BarbarianMinDmg = 150, BarbarianMaxProtect = 45, BarbarianMinProtect = 35;
            /*Missatges bàrbar*/
            const string MsgHealthBarbarian = "Vida[3000-3750]", MsgDmgBarbarian = "Atac[150-250]", MsgProtectBarbarian = "Protecció[35-45]%", MsgBarbarian = "Introdueix els valors requerits per al bàrbar: ", MsgHabBarbarian = ": augmenta la seva defensa al 100% durant 3 torns";
            const string MsgTurnBarbarian = "-----Torn del bàrbar-----";
            const string MsgActivaBarbarian = "* El bàrbar millora al màxim la seva armadura *";

            /*Variables i constants de la maga*/
            bool wizardShield = false;
            double wizardDmg = 0, wizardProtect = 0, wizardHPlimit = 0;
            int wizardAction, wizardCD = 0;
            double wizardHealth = 0;
            const int WizardMaxHealth = 1500, WizardMinHealth = 1000, WizardMaxDmg = 350, WizardMinDmg = 300, WizardMaxProtect = 35, WizardMinProtect = 20;
            /*Missatges de la maga*/
            const string MsgHealthWizard = "Vida[1000-1500]", MsgDmgWizard = "Atac[300-350]", MsgProtectWizard = "Protecció[20-35]%", MsgWizard = "Introdueix els valors requerits per la maga: ", MsgHabWizard = ": dispara una bola de foc que fa 3 cops el seu atac.";
            const string MsgTurnWizard = "-----Torn de la maga-----";

            /*Variables i constants del druida*/
            bool druidShield = false;
            double druidDmg = 0, druidProtect = 0, druidHPlimit = 0;
            int druidAction, druidCD = 0;
            double druidHealth = 0;
            const int DruidMaxHealth = 2500, DruidMinHealth = 2000, DruidMaxDmg = 120, DruidMinDmg = 70, DruidMaxProtect = 40, DruidMinProtect = 25;
            /*Missatges druida*/
            const string MsgHealthDruid = "Vida[2000-2500]", MsgDmgDruid = "Atac[70-120]", MsgProtectDruid = "Protecció[25-40]%", MsgDruid = "Introdueix els valors requerits per al druida: ", MsgHabDruid = ": cura 500 de vida a tots els herois";
            const string MsgTurnDruid = "-----Torn del druida-----";
            const string MsgHeal = "* El druida cura 500 de vida a tots els herois *";

            /*Variables i constants del monstre*/

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

            // msg batalla
            const string MsgAction1 = "1- Atacar", MsgAction2 = "2- Protegir-se", MsgAction3 = "3- Habilitat Especial";
            const string MsgMonsterAttack = "-----El monstre ataca-----";
            const string MsgMonsterNoAttack = "-----El monstre no pot atacar-----";


            const string MsgWon = "Els herois han derrotat al monstre, has guanyat!!!", MsgLose = "Tots els herois han mort, has perdut :(";



            const string MsgArcherProtect = "L'arquera duplica la seva protecció";
            const string MsgBarbarianProtect = "El bàrbar duplica la seva protecció";
            const string MsgWizardProtect = "La maga duplica la seva protecció";
            const string MsgDruidProtect = "El druida duplica la seva protecció";

            bool enter = false;
            const string MsgEntry = "1. Iniciar una nova batalla\t0. Sortir", MsgBye = "T'has equivocat masses cops, adéu";
            const int play = 1, exit = 0, maxAction=3, minAction=1;
            
            int option=0;
            string archerName, barbarianName, wizardName, druidName, names;
            
            const string MsgNames = "Escriu el nom de cada heroi: [Arquera, Bàrbar, Maga, Druida]";

            Random rand = new Random();
            
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
                    else if (option == 1)
                    {
                        enter = true;
                    }
                    else if( option==0)
                    {
                        enter = false;
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
                            archerHealth = Metodes.CheeckStat(archerHealth, ArcherMinHealth, ArcherMaxHealth);
                            tries = 0;
                            archerHPlimit = archerHealth;
                            Console.WriteLine(MsgDmgArcher);
                            do
                            {
                                archerDmg = Convert.ToInt32(Console.ReadLine());  
                                tries++;
                            } while (Metodes.InRange(archerDmg, ArcherMinDmg, ArcherMaxDmg) && tries < maxtries);

                            archerDmg = Metodes.CheeckStat(archerDmg, ArcherMinDmg, ArcherMaxDmg);
                            tries = 0;
                            Console.WriteLine(MsgProtectArcher);
                            do
                            {
                                archerProtect = Convert.ToInt32(Console.ReadLine()); 
                                tries++;
                            } while (Metodes.InRange(archerProtect, ArcherMinProtect, ArcherMaxProtect) && tries < maxtries);

                            archerProtect = Metodes.CheeckStat(archerProtect, ArcherMinProtect, ArcherMaxProtect);
                            tries = 0;
                            Console.WriteLine(MsgBarbarian); //creació bàrbar
                            Console.WriteLine(MsgHealthBarbarian);
                            do
                            {
                                barbarianHealth = Convert.ToInt32(Console.ReadLine());
                                tries++;
                            } while (Metodes.InRange(barbarianHealth, BarbarianMinHealth, BarbarianMaxHealth) && tries < maxtries);
                            barbarianHealth = Metodes.CheeckStat(barbarianHealth, BarbarianMinHealth, BarbarianMaxHealth);
                            tries = 0;
                            barbarianHPlimit = barbarianHealth;
                            Console.WriteLine(MsgDmgBarbarian);
                            do
                            {
                                barbarianDmg = Convert.ToInt32(Console.ReadLine());
                                tries++;
                            } while (Metodes.InRange(barbarianDmg, BarbarianMinDmg, BarbarianMaxDmg) && tries < maxtries);

                            barbarianDmg = Metodes.CheeckStat(barbarianDmg, BarbarianMinDmg, BarbarianMaxDmg);
                            tries = 0;
                            Console.WriteLine(MsgProtectBarbarian);
                            do
                            {
                                barbarianProtect = Convert.ToInt32(Console.ReadLine());
                                tries++;
                            } while (Metodes.InRange(barbarianProtect, BarbarianMinProtect, BarbarianMaxProtect) && tries < maxtries);

                            barbarianProtect = Metodes.CheeckStat(barbarianProtect, BarbarianMinProtect, BarbarianMaxProtect);
                            tries = 0;
                            Console.WriteLine(MsgWizard); //creació maga
                            Console.WriteLine(MsgHealthWizard);
                            do
                            {
                                wizardHealth = Convert.ToInt32(Console.ReadLine());
                                tries++;
                            } while (Metodes.InRange(wizardHealth, WizardMinHealth, WizardMaxHealth) && tries < maxtries);
                            wizardHealth = Metodes.CheeckStat(wizardHealth, WizardMinHealth, WizardMaxHealth);
                            tries = 0;
                            wizardHPlimit = wizardHealth;
                            Console.WriteLine(MsgDmgWizard);
                            do
                            {
                                wizardDmg = Convert.ToInt32(Console.ReadLine());
                                tries++;
                            } while (Metodes.InRange(wizardDmg, WizardMinDmg, WizardMaxDmg) && tries < maxtries);

                            wizardDmg = Metodes.CheeckStat(wizardDmg, WizardMinDmg, WizardMaxDmg);
                            tries = 0;
                            Console.WriteLine(MsgProtectWizard);
                            do
                            {
                                wizardProtect = Convert.ToInt32(Console.ReadLine());
                                tries++;
                            } while (Metodes.InRange(wizardProtect, WizardMinProtect, WizardMaxProtect) && tries < maxtries);

                            wizardProtect = Metodes.CheeckStat(wizardProtect, WizardMinProtect, WizardMaxProtect);
                            tries = 0;
                            Console.WriteLine(MsgDruid); //creació druida
                            Console.WriteLine(MsgHealthDruid);
                            do
                            {
                                druidHealth = Convert.ToInt32(Console.ReadLine());
                                tries++;
                            } while (Metodes.InRange(druidHealth, DruidMinHealth, DruidMaxHealth) && tries < maxtries);
                            druidHealth = Metodes.CheeckStat(druidHealth, DruidMinHealth, DruidMaxHealth);
                            tries = 0;
                            druidHPlimit = druidHealth;
                            Console.WriteLine(MsgDmgDruid);
                            do
                            {
                                druidDmg = Convert.ToInt32(Console.ReadLine());
                                tries++;
                            } while (Metodes.InRange(druidDmg, DruidMinDmg, DruidMaxDmg) && tries < maxtries);

                            druidDmg = Metodes.CheeckStat(druidDmg, DruidMinDmg, DruidMaxDmg);
                            tries = 0;
                            Console.WriteLine(MsgProtectDruid);
                            do
                            {
                                druidProtect = Convert.ToInt32(Console.ReadLine());
                                tries++;
                            } while (Metodes.InRange(druidProtect, DruidMinProtect, DruidMaxProtect) && tries < maxtries);

                            druidProtect = Metodes.CheeckStat(druidProtect, DruidMinProtect, DruidMaxProtect);
                            tries = 0;


                            Console.WriteLine(MsgMonster); // Creación monstre
                            Console.WriteLine(MsgHealthMonster);
                            do
                            {
                                monsterHealth = Convert.ToInt32(Console.ReadLine());
                                tries++;
                            } while (Metodes.InRange(monsterHealth, MonsterMinHealth, MonsterMaxHealth) && tries < maxtries);
                            monsterHealth = Metodes.CheeckStat(monsterHealth, MonsterMinHealth, MonsterMaxHealth);
                            tries = 0;
                            
                            Console.WriteLine(MsgDmgMonster);
                            do
                            {
                                monsterDmg = Convert.ToInt32(Console.ReadLine());
                                tries++;
                            } while (Metodes.InRange(monsterDmg, MonsterMinDmg, MonsterMaxDmg) && tries < maxtries);

                            monsterDmg=Metodes.CheeckStat(monsterDmg, MonsterMinDmg, MonsterMaxDmg);
                            tries = 0;
                            Console.WriteLine(MsgProtectMonster);
                            do
                            {
                                monsterProtect = Convert.ToInt32(Console.ReadLine());
                                tries++;
                            } while (Metodes.InRange(monsterProtect, MonsterMinProtect, MonsterMaxProtect) && tries < maxtries);

                            monsterProtect=Metodes.CheeckStat(monsterProtect, MonsterMinProtect, MonsterMaxProtect);
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

                            monsterHealth = Metodes.RandomStats(MonsterMinHealth, MonsterMaxHealth);
                            monsterDmg = Metodes.RandomStats(MonsterMinDmg, MonsterMaxDmg);
                            monsterProtect = Metodes.RandomStats(MonsterMinProtect, MonsterMaxProtect);
                            break;

                    }
                    Console.Clear();
                    Console.WriteLine(MsgNames);
                    names=Console.ReadLine();
                    string[] namesArray = names.Split(", ");
                    archerName= namesArray[0];
                    barbarianName= namesArray[1];
                    wizardName= namesArray[2];
                    druidName= namesArray[3];   
                    while ((archerHealth > 0 || barbarianHealth > 0 || wizardHealth > 0 || druidHealth > 0) && monsterHealth > 0)
                    {
                        
                        int[] turns = new int[4];
                        for (int i = 0; i < turns.Length; i++)
                        {
                            int value;
                            do
                            {
                                value = rand.Next(MinDiff, MaxDiff + 1);
                            } while (turns.Contains(value));
                            turns[i] = value;
                        }
                        for (int i = 0; i < turns.Length; i++)
                        {
                            tries = 0;
                            switch (turns[i])
                            {
                                case 1:
                                    if (archerHealth > 0)
                                    {
                                        Console.WriteLine(MsgTurnArcher);
                                        Console.WriteLine(MsgAction1);
                                        Console.WriteLine(MsgAction2);
                                        Console.WriteLine(MsgAction3 + MsgHabArcher);
                                        archerShield = false;
                                        archerCD = Metodes.CoolDown(archerCD);
                                        do
                                        {
                                            tries++;
                                            option = Convert.ToInt32(Console.ReadLine());
                                            if (option == 3 && !(archerCD == 0))
                                            {
                                                option = 0;
                                                Console.WriteLine($"Queden {archerCD} torns per poder utilitzar la habilitat");
                                            }
                                        } while (Metodes.InRange(option, minAction, maxAction) && tries < maxtries);
                                        if (tries == maxtries)
                                        {
                                            option = 0;
                                        }
                                        switch (option)
                                        {
                                            case 0:
                                                Console.WriteLine($"L'arquera {archerName} perd el seu torn");
                                                break;
                                            case 1:
                                                if (Metodes.Dodge())
                                                {
                                                    Console.WriteLine($"L'arquera {archerName} ha fallat l'atac");
                                                }
                                                else
                                                {
                                                    if (Metodes.CriticDmg())
                                                    {
                                                        monsterHealth -= Metodes.Damage(archerDmg * 2, monsterProtect);
                                                        Console.WriteLine($"L'arquera {archerName} fa un atac crític de {Metodes.Damage(archerDmg * 2, monsterProtect)} de dany");

                                                    }
                                                    else
                                                    {
                                                        monsterHealth -= Metodes.Damage(archerDmg, monsterProtect);
                                                        Console.WriteLine($"L'arquera {archerName} fa un atac de {Metodes.Damage(archerDmg, monsterProtect)} de dany");
                                                    }
                                                }
                                                break;
                                            case 2:
                                                archerShield = true;
                                                Console.WriteLine($"L'arquera {archerName} es protegeix");
                                                break;
                                            case 3:
                                                archerCD = 5;
                                                break;

                                        }
                                    }
                                    
                                    break;
                                case 2:
                                    if (barbarianHealth > 0)
                                    {
                                        Console.WriteLine(MsgTurnBarbarian);
                                        Console.WriteLine(MsgAction1);
                                        Console.WriteLine(MsgAction2);
                                        Console.WriteLine(MsgAction3 + MsgHabBarbarian);
                                        barbarianShield = false;
                                        barbarianCD = Metodes.CoolDown(barbarianCD);
                                        do
                                        {
                                            tries++;
                                            option = Convert.ToInt32(Console.ReadLine());
                                            if (option == 3 && !(barbarianCD == 0))
                                            {
                                                option = 0;
                                                Console.WriteLine($"Queden {barbarianCD} torns per poder utilitzar la habilitat");
                                            }
                                        } while (Metodes.InRange(option, minAction, maxAction) && tries < maxtries);
                                        if (tries == maxtries)
                                        {
                                            option = 0;
                                        }
                                        switch (option)
                                        {
                                            case 0:
                                                Console.WriteLine($"El bàrbar {barbarianName} perd el seu torn");
                                                break;
                                            case 1:
                                                if (Metodes.Dodge())
                                                {
                                                    Console.WriteLine($"El bàrbar {barbarianName} ha fallat l'atac");
                                                }
                                                else
                                                {
                                                    if (Metodes.CriticDmg())
                                                    {
                                                        monsterHealth -= Metodes.Damage(barbarianDmg * 2, monsterProtect);
                                                        Console.WriteLine($"El bàrbar {barbarianName} fa un atac crític de {Metodes.Damage(barbarianDmg*2, monsterProtect)} de dany");
                                                    }
                                                    else
                                                    {
                                                        monsterHealth -= Metodes.Damage(barbarianDmg, monsterProtect);
                                                        Console.WriteLine($"El bàrbar {barbarianName} fa un atac de {Metodes.Damage(barbarianDmg, monsterProtect)} de dany");
                                                    }
                                                }
                                                break;
                                            case 2:
                                                Console.WriteLine($"El bàrbar {barbarianName} es protegeix");
                                                barbarianShield = true;
                                                break;
                                            case 3:
                                                barbarianCD = 5;
                                                break;
                                        }
                                    }
                                    break;
                                case 3:
                                    if (wizardHealth > 0)
                                    {
                                        Console.WriteLine(MsgTurnWizard);
                                        Console.WriteLine(MsgAction1);
                                        Console.WriteLine(MsgAction2);
                                        Console.WriteLine(MsgAction3 + MsgHabWizard);
                                        wizardShield = false;
                                        wizardCD = Metodes.CoolDown(wizardCD);
                                        do
                                        {
                                            tries++;
                                            option = Convert.ToInt32(Console.ReadLine());
                                            if (option == 3 && !(wizardCD == 0))
                                            {
                                                option = 0;
                                                Console.WriteLine($"Queden {wizardCD} torns per poder utilitzar la habilitat");
                                            }
                                        } while (Metodes.InRange(option, minAction, maxAction) && tries < maxtries);
                                        if (tries == maxtries)
                                        {
                                            option = 0;
                                        }
                                        switch (option)
                                        {
                                            case 0:
                                                Console.WriteLine($"La maga {wizardName} perd el seu torn");
                                                break;
                                            case 1:
                                                if (Metodes.Dodge())
                                                {
                                                    Console.WriteLine($"La maga {wizardName} ha fallat l'atac");
                                                }
                                                else
                                                {
                                                    if (Metodes.CriticDmg())
                                                    {
                                                        monsterHealth -= Metodes.Damage(wizardDmg * 2, monsterProtect);
                                                        Console.WriteLine($"La maga {wizardName} fa un atac crític de {Metodes.Damage(wizardDmg * 2, monsterProtect)} de dany");
                                                    }
                                                    else
                                                    {
                                                        monsterHealth -= Metodes.Damage(wizardDmg, monsterProtect);
                                                        Console.WriteLine($"La maga {wizardName} fa un atac de {Metodes.Damage(wizardDmg, monsterProtect)} de dany");
                                                    }
                                                }
                                                break;
                                            case 2:
                                                wizardShield = true;
                                                Console.WriteLine($"La maga {wizardName} es protegeix");
                                                break;
                                            case 3:
                                                monsterHealth -= Metodes.Damage(wizardDmg * 3, monsterProtect);
                                                Console.WriteLine($"La maga {wizardName} ataca amb la bola de foc i fa {Metodes.Damage(wizardDmg * 3, monsterProtect)} de dany");
                                                wizardCD = 5;
                                                break;
                                        }
                                    }
                                    break;
                                case 4:
                                    if (druidHealth > 0)
                                    {
                                        Console.WriteLine(MsgTurnDruid);
                                        Console.WriteLine(MsgAction1);
                                        Console.WriteLine(MsgAction2);
                                        Console.WriteLine(MsgAction3 + MsgHabDruid);
                                        druidShield = false;
                                        druidCD = Metodes.CoolDown(druidCD);
                                        do
                                        {
                                            tries++;
                                            option = Convert.ToInt32(Console.ReadLine());
                                            if (option == 3 && !(druidCD == 0))
                                            {
                                                option = 0;
                                                Console.WriteLine($"Queden {druidCD} torns per poder utilitzar la habilitat");
                                            }
                                        } while (Metodes.InRange(option, minAction, maxAction) && tries < maxtries);
                                        if (tries == maxtries)
                                        {
                                            option = 0;
                                        }
                                        switch (option)
                                        {
                                            case 0:
                                                Console.WriteLine($"El druida {druidName} perd el seu torn");
                                                break;
                                            case 1:
                                                if (Metodes.Dodge())
                                                {
                                                    Console.WriteLine($"El druida {druidName} ha fallat l'atac");
                                                }
                                                else
                                                {
                                                    if (Metodes.CriticDmg())
                                                    {
                                                        monsterHealth -= Metodes.Damage(druidDmg * 2, monsterProtect);
                                                        Console.WriteLine($"El druida {druidName} fa un atac crític de {Metodes.Damage(druidDmg * 2, monsterProtect)} de dany");
                                                    }
                                                    else
                                                    {
                                                        monsterHealth -= Metodes.Damage(druidDmg, monsterProtect);
                                                        Console.WriteLine($"El druida {druidName} fa un atac de {Metodes.Damage(druidDmg, monsterProtect)} de dany");
                                                    }
                                                }
                                                break;
                                            case 2:
                                                Console.WriteLine($"El druida {druidName} es protegeix");
                                                druidShield = true;
                                                break;
                                            case 3:
                                                Console.WriteLine($"El druida {druidName} cura 500 de vida a tothom");
                                                archerHealth = Metodes.Heal(archerHealth, archerHPlimit);
                                                barbarianHealth = Metodes.Heal(barbarianHealth, barbarianHPlimit);
                                                wizardHealth = Metodes.Heal(wizardHealth, wizardHPlimit);
                                                druidHealth = Metodes.Heal(druidHealth, druidHPlimit);
                                                druidCD = 5;
                                                break;
                                        }
                                    }

                                    break;
                            }
                            
                            
                        }
                        
                        if (archerCD > 3)
                        {
                            Console.WriteLine(MsgMonsterNoAttack);
                        }
                        else
                        {
                            Console.WriteLine(MsgMonsterAttack);
                            Console.ReadKey();
                            if (archerHealth > 0)
                            {
                                archerHealth -= Metodes.MonsterAttack(monsterDmg, archerProtect, archerShield);
                                Console.WriteLine(archerHealth <= 0 ? $"L'arquera ha mort" : $"L'arquera reb {Metodes.MonsterAttack(monsterDmg, archerProtect, archerShield)} de dany");
                            }
                            if (barbarianHealth > 0)
                            {
                                if (barbarianCD > 3)
                                {
                                    Console.WriteLine($"El bàrbar bloqueja l'atac del monstre");
                                }
                                else
                                {
                                    barbarianHealth -= Metodes.MonsterAttack(monsterDmg, barbarianProtect, barbarianShield);
                                    Console.WriteLine(barbarianHealth <= 0 ? $"El bàrbar ha mort" : $"El bàrbar reb {Metodes.MonsterAttack(monsterDmg, barbarianProtect, barbarianShield)} de dany");
                                }
                            }

                            if (wizardHealth > 0)
                            {
                                wizardHealth -= Metodes.MonsterAttack(monsterDmg, wizardProtect, wizardShield);
                                Console.WriteLine(wizardHealth <= 0 ? $"La maga ha mort" : $"La maga reb {Metodes.MonsterAttack(monsterDmg, wizardProtect, wizardShield)} de dany");
                            }
                            if (druidHealth > 0)
                            {
                                druidHealth -= Metodes.MonsterAttack(monsterDmg, druidProtect, druidShield);
                                Console.WriteLine(druidHealth <= 0 ? $"El druida ha mort" : $"El druida reb {Metodes.MonsterAttack(monsterDmg, druidProtect, druidShield)} de dany");
                            }
                        }
                        Console.ReadKey();
                        double[] orderHp = Metodes.OrderHp(archerHealth, barbarianHealth, wizardHealth, druidHealth);
                        for(int i = 0; i < orderHp.Length; i++)
                        {
                            if (orderHp[i] == archerHealth && archerHealth>0)
                            {
                                Console.WriteLine($"La vida restant de l'arquera és {archerHealth}");
                            }
                            else if (orderHp[i] == barbarianHealth && wizardHealth > 0)
                            {
                                Console.WriteLine($"La vida restant del bàrbar és {barbarianHealth}");
                            }
                            else if (orderHp[i] == wizardHealth && wizardHealth > 0)
                            {
                                Console.WriteLine($"La vida restant de la maga és {wizardHealth}");
                            }
                            else if (orderHp[i] == druidHealth && druidHealth > 0)
                            {
                                Console.WriteLine($"La vida restant del druida és {druidHealth}");
                            }
                        }
                        Console.WriteLine($"La vida restant del monstre és {monsterHealth}");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    enter = false;

                }
            } while (tries < maxtries && option!=0);
            if (tries == maxtries)
            {
                Console.WriteLine(MsgBye);
            }
            if(monsterHealth<=0)
            {
                Console.WriteLine(MsgWon);
            }
            else
            {
                Console.WriteLine(MsgLose);
            }
            Console.ReadKey();
        }
        
    }
}