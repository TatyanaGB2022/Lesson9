﻿// Задача 6: Проверка на простое число: 
// N = 13 -> "Это простое число"
// N = 12 -> “Это не простое число”

//один вариант

// bool Validate(int number, int devider)
// {
//   if (devider == 1)
//   {
//     return true;
//   }
//   if (number % devider == 0)
//   {
//     return false;
//   }
//   devider--;
//   return Validate(number, devider);
// }

// System.Console.WriteLine(Validate(6,5));

// второй вариант

bool Validate(int number, int devider)
{
  if (devider == 1)
  {
    return true;
  }
  return (number % devider != 0) && Validate(number, devider-1);
}

bool Starter(int number1)
{
  return Validate(number1, number1-1);
}
System.Console.WriteLine(Starter(31));