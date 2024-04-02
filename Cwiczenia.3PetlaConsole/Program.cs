using System;

class Program
{
    static void Main(string[] args)
    {
        int n = 10; // liczba elementów ciągu do wygenerowania
        Console.WriteLine("Ciąg Fibonacciego:");

        // Wyświetlenie pierwszych n elementów ciągu Fibonacciego
        for (int i = 0; i < n; i++)
        {
            Console.Write(Fibonacci(i) + " ");
        }
    }

    // Metoda do obliczania n-tego elementu ciągu Fibonacciego
    static int Fibonacci(int n)
    {
        if (n <= 1)
        {
            return n;
        }
        else
        {
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
}