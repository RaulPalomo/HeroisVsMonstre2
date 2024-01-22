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
Comprova si el valor es troba fora del rang
Classes d'equivalència
~~~
Comprova si el valor es troba fora del rang


Classes d'equivalència
* Vàlida: enters menors al mínim
* Vàlida: enters majors al mínim
* Vàlida: enters dins del rang
* Invàlida: strings o caràcters
  
