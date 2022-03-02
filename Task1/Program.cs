// Задача № 1
/*
Console.WriteLine("Введите первое число: ");
int value1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int value2 = Convert.ToInt32(Console.ReadLine());

if(value1 > value2)
{
    Console.Write("max: ");
    Console.WriteLine(value1);
}
else
{
     Console.Write("max: ");
Console.WriteLine(value2);
}
*/

// Задача №2
/*
Console.WriteLine("Введите первое число: ");
int value1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int value2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число: ");
int value3 = Convert.ToInt32(Console.ReadLine());

int max = 0;
if(value1 > max) max = value1;
if(value2 > max) max = value2;
if(value3 > max) max = value3;
Console.Write("max: ");
Console.WriteLine(max);
*/

// Задача №3
/*
Console.WriteLine("Введите число: ");
int value = Convert.ToInt32(Console.ReadLine());

if(value % 2 == 0)
{
Console.Write(" Четное: ");
Console.WriteLine(value);
}
else
{
Console.Write("Нечетное: ");
Console.WriteLine(value);
}
*/

//Задача №4

Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int a = 1;
while (a <= N)
{
    if(a % 2 == 0)
   {
    Console.WriteLine(a);
    a++; 
   }  
}
       
    


