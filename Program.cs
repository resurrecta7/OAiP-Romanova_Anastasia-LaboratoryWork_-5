using System;

class ArithmeticProgression
{
    private double first;  
    private double second; 
    public ArithmeticProgression()
    {
        first = 0.0;
        second = 0.0;
    }
    public void Read()
    {
        Console.Write("введите первый элемент (a0): ");
        first = Convert.ToDouble(Console.ReadLine());

        Console.Write("введите разность (d): ");
        second = Convert.ToDouble(Console.ReadLine());
    }
    public void Display()
    {
        Console.WriteLine($"a0 = {first}, d = {second}");
    }
    public double element_i(int i)
    {
        return first + i * second;
    }
}
class Program
{
    static void Main()
    {
        ArithmeticProgression prog = new ArithmeticProgression();

        prog.Read();

        Console.WriteLine("\nвведенная прогрессия:");
        prog.Display();

        Console.WriteLine("\nпервые 5 элементов прогрессии:");
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"a[{i}] = {prog.element_i(i)}");
        }
        Console.Write("\nвведите номер элемента для вычисления: ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"a[{n}] = {prog.element_i(n)}");
    }
}