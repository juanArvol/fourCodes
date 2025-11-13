using System;

public class CalculatorApp
{
    protected static double number;

    public static void Suma(double n)
    {
        double count = 0;
        number = n;
        if (n != 0)
            Console.WriteLine(number + count);
    }

    public static void Resta(double n)
    {
        double count = 0;
        number = n;
        if (n != 0)
            Console.WriteLine(count - number);
    }

    public static void Multiplicacion(double n)
    {
        double count = 0;
        number = n;
        if (count == 0) count = n;
        if (n != 0)
            Console.WriteLine(number * count);
    }

    public static void Division(double n)
    {
        double count = 0;
        number = n;
        if (count == 0) count = n;
        if (n != 0)
            Console.WriteLine(number / count);
    }

    public static void ShowResults(double n)
    {
        Suma(n);
        Resta(n);
        Division(n);
        Multiplicacion(n);
    }
}

public class Calculator : CalculatorApp
{
    public static void ShowResults()
    {
        ShowResults(4);
        CalculatorApp.ShowResults(36);
    }
}

public class PC : CalculatorApp
{
    public static void ShowResults()
    {
        ShowResults(34);
        CalculatorApp.ShowResults(39);
    }
}

public class Cellphone : CalculatorApp
{
    public static void ShowResults()
    {
        ShowResults(3);
        CalculatorApp.ShowResults(47);
    }
}

public class MainClass
{
    public static void Loader()
    {
        Console.WriteLine("Los resultados dados por la calculadora:");
        Calculator.ShowResults();

        Console.WriteLine("Los resultados dados por la PC:");
        PC.ShowResults();

        Console.WriteLine("Los resultados dados por el teléfono:");
        Cellphone.ShowResults();
    }

    public static void Main(string[] args)
    {
        Loader();
    }
}
