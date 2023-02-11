 //Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
int SumDigitNumber (int N)
{
    int result = 0;
    while (N > 0)
    {
        result += N % 10;
        N /= 10;
    }
    return result;
}
System.Console.WriteLine("Введите число:");
int N = Convert.ToInt32(Console.ReadLine());
int result = SumDigitNumber(N);
System.Console.WriteLine($"Cумма введеных чисел = {result}");
