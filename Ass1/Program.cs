// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
Console.WriteLine("Enter numbers divided by a comma: ");

char[] delimiterChars = { ' ', ',', '.', ':', '\t' };

string text = Console.ReadLine();

string[] words = text.Split(delimiterChars);
int[] numbers = Array.ConvertAll(words, int.Parse);
int count = 0;
for(int i = 0; i < numbers.Length; i++)
{
    if(numbers[i] > 0)
    {
        count++;
    }
}
System.Console.WriteLine($"You entered {count} number(s) larger than zero");





