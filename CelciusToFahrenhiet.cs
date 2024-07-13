using System;
public class Arithmetic
{
	public static void Main(string[] args){
		Console.WriteLine("Enter temperature in celcius");
		float temp= int.Parse(Console.ReadLine());

		float fa = (temp * 9/5) + 32 ;
		
		
		Console.WriteLine("fahreniet = " + fa); 

	}
}
