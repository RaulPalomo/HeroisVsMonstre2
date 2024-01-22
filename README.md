# HeroisVsMonstre2
### Metode InRange 
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
* Vàlida: enters majors al mínim
* Vàlida: enters dins del rang
* Invàlida: strings o caràcters

Valors límit
* Límit inferior: el mínim que es marqui(qualsevol enter)
* Límit superior: el màxim que es vulgui(qualsevol enter)

Resultats
* Si num=500, min=200 i max=400 --> retorna true
* Si num=1000, min=800, max=1200 --> retorna false

### Metode CheckStat
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

### Metode RandomStat
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

