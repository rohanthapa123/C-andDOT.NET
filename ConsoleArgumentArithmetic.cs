using System;
public class Arithmetic
{
	public static void Main(string[] args){
		Console.WriteLine("Enter any two numbers");
		int num1 = int.Parse(args[0]);
		int num2 = int.Parse(args[1]);
		int sum = num1 + num2;
		int diff = num1 - num2;
		int mul = num1 * num2;
		int div = num1 / num2;
		Console.WriteLine("Sum = " + sum); 
		Console.WriteLine("Div = " + div);
		Console.WriteLine("Difference = " + diff);
		Console.WriteLine("Product = " + mul);
	}
}
