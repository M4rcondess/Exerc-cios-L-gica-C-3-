using System;

class Program {
  public static void Main (string[] args) {
    

    Double valor;
    Int16 num;

    Console.WriteLine("Digite o número de maças compradas");

    num = Int16.Parse(Console.ReadLine());

    if(num<12);
    {
    valor = num*1.30;

    Console.WriteLine("O valor total de maças compradas foi : " + valor + " reais ");
      
    }
    
    {
      valor = num*1.00;

    Console.WriteLine("O valor de maças compradas foi: " + valor + "reais");
      }
    
  }
}