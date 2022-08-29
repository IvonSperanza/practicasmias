using System;
class HelloWorld {
  static void Main() {
      Random numero = new Random();
      int aleatorio = numero.Next(0,100);
      int minro=101;
      int intentos=0;
      
      
    Console.WriteLine("Ingrese un valor de 0 a 100:  ");
    while(aleatorio!= minro){
        
        intentos++;
        minro = int.Parse(Console.ReadLine());
        if(minro> aleatorio){
            Console.WriteLine("Nro aún más bajo");
            
        }
        else{
            Console.WriteLine("El nro es más alto");
        }
    }
        Console.WriteLine($"Acertaste, Te ha tomado {intentos}");
    }
}