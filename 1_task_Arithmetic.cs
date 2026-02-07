using System;

class Payment
{
    private string fullName;
    private double salary;
    private int hireYear;
    private double bonusPercent;
    private double incomeTax;
    private int workedDays;
    private int workingDays;
    private double accruedAmount;
    private double withheldAmount;
    public Payment()
    {
        fullName = "";
        salary = 0;
        hireYear = 2024;
        bonusPercent = 0;
        incomeTax = 13;
        workedDays = 0;
        workingDays = 22;
        accruedAmount = 0;
        withheldAmount = 0;
    }

    public void Read()
    {
        Console.Write("ФИО: ");
        fullName = Console.ReadLine();

        Console.Write("оклад: ");
        salary = double.Parse(Console.ReadLine());

        Console.Write("год приёма: ");
        hireYear = int.Parse(Console.ReadLine());

        Console.Write("надбавка %: ");
        bonusPercent = double.Parse(Console.ReadLine());

        Console.Write("отработано дней: ");
        workedDays = int.Parse(Console.ReadLine());

        Console.Write("рабочих дней: "); 
        workingDays = int.Parse(Console.ReadLine());
    }
    public void Display()
    {
        Console.WriteLine($"ФИО: {fullName}");
        Console.WriteLine($"Оклад: {salary}");
        Console.WriteLine($"Год приёма: {hireYear}");
        Console.WriteLine($"Надбавка: {bonusPercent}%");
        Console.WriteLine($"Отработано: {workedDays}/{workingDays}");
    }
    public int CalculateExperience()
    {
        int currentYear = DateTime.Now.Year;
        return currentYear - hireYear;
    }

    public double CalculateAccruedAmount()
    {
        double salaryForDays = (salary / workingDays) * workedDays;
        double bonus = salaryForDays * (bonusPercent / 100);
        accruedAmount = salaryForDays + bonus;
        return accruedAmount;
    }

    public double CalculateWithheldAmount()
    {
        double pension = accruedAmount * 0.01;
        double tax = accruedAmount * (incomeTax / 100);
        withheldAmount = pension + tax;
        return withheldAmount;
    }
    public double CalculateNetSalary()
    {
        double accrued = CalculateAccruedAmount();
        double withheld = CalculateWithheldAmount();
        return accrued - withheld;
    }
}
class Program
{
    static void Main()
    {
        Payment emp = new Payment();

        emp.Read();

        Console.WriteLine("\nДанные сотрудника:");
        emp.Display();

        Console.WriteLine($"\nСтаж: {emp.CalculateExperience()} лет");

        Console.WriteLine($"\nНачислено: {emp.CalculateAccruedAmount():F2}");
        Console.WriteLine($"Удержано: {emp.CalculateWithheldAmount():F2}");
        Console.WriteLine($"На руки: {emp.CalculateNetSalary():F2}");
    }
}