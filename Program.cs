using System;

internal class Program
{
    private static void Main(string[] args)
    {
        double sayi1, sayi2;
        string ıslem;

        Console.WriteLine("sayi1 giriniz");
        sayi1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("sayi2 giriniz");
        sayi2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("işlem seçiniz");
        ıslem = Console.ReadLine();

        switch (ıslem)
        {
            case "+":
                Console.WriteLine("seçilen işlem toplama:" + (sayi1 + sayi2));
                break;

            case "-":
                Console.WriteLine("seçilen işlem çıkarma:" + (sayi1 - sayi2));
                break;

            case "*":
                Console.WriteLine("seçilen işlem çarpma:" + (sayi1 * sayi2));
                break;
            case "/":
                Console.WriteLine("seçilen işlem bölme:" + (sayi1 / sayi2));
                break;

            default:
                Console.WriteLine("böyle bir işlem yoktur");
                break;
        }
    }
}