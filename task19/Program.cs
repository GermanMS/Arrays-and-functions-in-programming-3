// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 23432 -> да
// 12821 -> да
Console.WriteLine ("Введите число пятизначное");
// int [] через массив решить
int number  =  Convert.ToInt32(Console.ReadLine());
int numberA = number/10000;
int numberE = number%10;


// Console.WriteLine ($"{numberA} + {numberE}");
if( numberA == numberE);

// else{
//     Console.WriteLine("нет");
//     }
int numberB = number/1000 % 10;
int numberD = number/10%10;
if( numberB == numberD )
{Console.WriteLine("да");
}
// then {Console.WriteLine("да")};
else{
    Console.WriteLine("нет");
    }

//  Console.WriteLine ($"{numberD}");