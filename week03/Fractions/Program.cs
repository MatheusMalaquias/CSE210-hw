using System;

class Program {
    static void Main(string [] args) {
        Fraction fraction = new Fraction(1 , 1);
        Fraction fraction1 = new Fraction(5 , 1);
        Console.WriteLine(fraction.GetFractionString());
        Console.WriteLine(fraction.GetDecimalValue());
        Console.WriteLine(fraction1.GetFractionString());
        Console.WriteLine(fraction1.GetDecimalValue());  
    }
}