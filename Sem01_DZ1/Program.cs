void Zadacha2() //Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
{
Console.WriteLine("Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.");
    Console.WriteLine("Введите первое число");
    int number1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе число");
    int number2 = Convert.ToInt32(Console.ReadLine());      

    if (number1 > number2)
            {
                Console.WriteLine("Первое число больше второго"); 
            }        
            else if (number1 < number2) 
            {
                Console.WriteLine("Второе число больше первого");
            }
            
            else Console.WriteLine("Числа равны");
}

void Zadacha4() //Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
{
    Console.WriteLine("Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.");
    Console.WriteLine("Введите первое число ");
    int number1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе число ");
    int number2 = Convert.ToInt32(Console.ReadLine());  
    Console.WriteLine("Введите третье число ");
    int number3 = Convert.ToInt32(Console.ReadLine()); 
    Console.WriteLine("Самое большое число  ");
    if (number1 > number2)
        {
            if (number1 > number3)
            Console.WriteLine(number1);
            else Console.WriteLine(number3);
        }
    else if (number2 > number3)
            {
            Console.WriteLine(number2);
            }
    else Console.WriteLine(number3);
}


void Zadacha6() //Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
{
    Console.WriteLine("Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).");
    Console.WriteLine("Введите число ");
    int number1 = Convert.ToInt32(Console.ReadLine());
    int output = number1 % 2 ;
    if (output == 0)
        {
            Console.WriteLine("Число четное");
        }
     else Console.WriteLine("Число нечетное");
}   


void Zadacha8() //Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
{
      Console.WriteLine("Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.");
      Console.WriteLine("Введите число N");
        int number = Convert.ToInt32(Console.ReadLine());
        int start = 2;
        Console.WriteLine("Все чётные числа от 1 до N");
        while (start <= number)
        {
            Console.Write(start + "  ");
            start = start + 2;
        }
        Console.WriteLine();
}   


Zadacha2();
Zadacha4();
Zadacha6();
Zadacha8();