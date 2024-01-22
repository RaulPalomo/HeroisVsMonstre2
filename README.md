# HeroisVsMonstre2
### Mètode InRange 
~~~
 public static bool InRange(double num,int min, int max)//comproba que no estigui dins del rang
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

~~~
Comprova si el valor es troba fora del rang


Classes d'equivalència
* Vàlida: enters menors al mínim
* Vàlida: enters majors al màxim
* Vàlida: enters dins del rang
* Invàlida: strings o caràcters

Valors límit
* Límit inferior: el mínim que es marqui(qualsevol enter)
* Límit superior: el màxim que es vulgui(qualsevol enter)

Resultats
* Si num=500, min=200 i max=400 --> retorna true
* Si num=1000, min=800, max=1200 --> retorna false

### Mètode CheckStat
~~~
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

~~~
Comprova si el valor es troba fora del rang, si ho està, fa que el número sigui el mínim possible


Classes d'equivalència
* Vàlida: enters menors al mínim
* Vàlida: enters majors al mínim
* Vàlida: enters dins del rang
* Invàlida: strings o caràcters
  
Valors límit
* Límit inferior: el mínim que es marqui(qualsevol enter)
* Límit superior: el màxim que es vulgui(qualsevol enter)

Resultats
* Si num=500, min=200 i max=400 --> retorna min
* Si num=1000, min=800, max=1200 --> retorna num

### Mètode RandomStat
~~~
public static double RandomStats(int min,int max)
{
    Random rand= new Random();
    return rand.Next(min, max + 1);
}

~~~
Retorna un número aleatori entre un mínim i un màxim


Classes d'equivalència
* Vàlida: el mínim i el màxim són enters i el màxim no es més petit que el mínim
* Vàlida: el mínim i el màxim són iguals
* Invàlida: el màxim és més petit que el mínim
  
Valors límit
* Límit inferior: el mínim que es marqui(qualsevol enter)
* Límit superior: el màxim que es vulgui(qualsevol enter)

Resultats
* Si min=20 i max=300 --> retorna número més petit o igual a 300 i més gran o igual a 20

### Mètode CoolDown
~~~
public static int CoolDown(int num)
{
   if ( num > 0)
   {
       return num-1;
   }
   else { return 0; }
}

~~~
Comprova si el temps d'espera de les habilitats es major a 0, si ho és, els hi resta 1


Classes d'equivalència
* Vàlida: qualsevol enter
* Vàlida: 0 o negatius
  
Valors límit
* Límit inferior: - infinit
* Límit superior: el temps d'espera només arriba a 5 pero podría entrar qualsevol enter més gran

Resultats
* Si num=20 --> retorna 19
* Si num=0 --> retorna 0

### Mètode Damage
~~~
public static double Damage(double dmg, double prot)
{
    const int hundred= 100;
    return dmg-dmg * prot/hundred;
}

~~~
Retorna el dany tenint en compte la protecció de l'objectiu


Classes d'equivalència
* Vàlida: dany i protecció positius
* Vàlida: dany o protecció iguals a 0 
  
Valors límit
* Límit inferior: 1
* Límit superior: qualsevol número positiu

Resultats
* Si protecció=20 i dany=100 --> retorna 80
* Si protecció=0 i dany=200 --> retorna 200

### Mètode Monster Attack
~~~
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

~~~
Depenent de si el heroi es protegeix o no invoca al mètode Damage amb la protecció duplicada o no


Classes d'equivalència
* Vàlida: dany i protecció positius, escud cert o fals
* Vàlida: dany o protecció iguals a 0 
  
Valors límit
* Límit inferior: 1
* Límit superior: qualsevol número positiu

Resultats
* Si escud=fals, protecció=25 i dany=100 --> retorna 75
* Si escud=true, protecció=40 i dany=0 --> retorna 0

### Mètode Heal
~~~
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

~~~
Aquest mètode suma 500 de vida al heroi (ha d'estar viu), però, si aquesta sobrepassa el límit de vida(la del inici) es quedarrà amb la vida límit


Classes d'equivalència
* Vàlida: vida i vida límit igual a número major a 0
* Vàlida: vida igual a número menor a 0
* Invàlida: vida superior al límit de vida
  
Valors límit
* Límit inferior: 1
* Límit superior: qualsevol número positiu

Resultats
* Si vida=100 i límitVida=700 --> retorna 600
* Si vida=0 i límitVida=200 --> retorna 0

