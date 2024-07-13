using System;
public class Arithmetic
{
	public static void Main(string[] args){
		Console.WriteLine("Enter any two numbers");
		int num1 = int.Parse(Console.ReadLine());
		int num2 = int.Parse(Console.ReadLine());
		int area = num1 * num2;
		int perimeter = 2 *( num1 + num2);
		
		Console.WriteLine("Area = " + area); 
		Console.WriteLine("perimeter = " + perimeter);

	}
}