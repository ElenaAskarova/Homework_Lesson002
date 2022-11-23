Console.WriteLine("Введите любое число: ");
int num = Convert.ToInt32(Console.ReadLine());
string numS = Convert.ToString(num);
int numDigit = numS.Length;
if(numDigit > 2) Console.WriteLine($"Третья цифра введенного числа: {numS[2]}");
else Console.WriteLine("Третьей цифры нет");
