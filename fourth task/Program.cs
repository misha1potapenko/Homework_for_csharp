// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

//5 -> 2, 4
//8 -> 2, 4, 6, 8
Console.Write("Введите число = ");
int numberUser = Convert.ToInt32(Console.ReadLine());
int userCount = 0;
int stop = numberUser - 2;
while ( userCount <= stop)
{   
    userCount = userCount + 2;
    Console.Write(userCount);
    Console.Write(", ");
}       
  
