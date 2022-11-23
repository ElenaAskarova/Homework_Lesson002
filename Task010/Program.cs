Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int amount = number.ToString().Length;
if(amount < 3 || amount > 3)
{
    Console.WriteLine("Вы ввели не трехзначное число");
}
else
{
    number = number / 10 % 10;
    Console.WriteLine($"Вторая цифра введенного числа: {number}");
}