// See Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
double b1 = ReadInt("Enter b1 value: ");
double k1 = ReadInt("Enter k1 value: ");
double b2 = ReadInt("Enter b2 value: ");
double k2 = ReadInt("Enter k2 value: ");
if(b1 == b2 && k1 == k2)
{
    Console.WriteLine("The lines are parallel");
    return;
}
double x = (b2-b1)/k1-k2;
double y = k2*x+b2;
double tempX = 1;
double tempY = 2;
int count = 0;

    if(tempY == k1*tempX+b1 && tempY == k2*x+b2)
    {
    while(count < 5 && tempY == k1*tempX+b1 && tempY == k2*x+b2)
{
    tempX++;
    tempY++;
    count++;

}
    Console.WriteLine("The lines coincide");
    return;
}

Console.WriteLine($"The coordinates of the intersection point are {x} , {y}");

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}