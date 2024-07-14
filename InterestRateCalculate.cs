using System;
public class SimpleInterest{
	public static void Main(string[] args){
		Console.WriteLine("Enter Amount , time and interest rate");
		float p= int.Parse(Console.ReadLine());	
		float t= int.Parse(Console.ReadLine());
		float r= int.Parse(Console.ReadLine());

		float i = (p * t * r ) / 100;
		Console.WriteLine("Interest = " + i); 

	}
}
