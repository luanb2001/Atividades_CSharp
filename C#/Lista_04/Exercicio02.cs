using System;
					
public class Program
{
	public static void Main()
	{
       double media;
       double acumula=0;
       double temp=0;
 
       Console.WriteLine("\n\t Média de Temperatura \n");
		
       for(int i=1; i<13; i++)
	   {
            Console.WriteLine("- Informe a temperatura em graus C° do "+ i +"° mês do ano:");
            temp = double.Parse(Console.ReadLine());
            acumula = acumula + temp;
        }
        
        media = acumula/12;
        Console.WriteLine("\n- A média de temperatura no ano é de "+media+" C°");
	}
}