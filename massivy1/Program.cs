﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace massivy1
{
  class Program
  {
    static void Main(string[] args)
    {
      int spaceValue = 0;
      ConsoleKeyInfo Symbol;
      Console.WriteLine("Программа подсчета веденных пробелов");
      do
      {
        Console.WriteLine("Введите символ");
        Console.WriteLine("Для окончания ввода нажмите точку ");
        Symbol = Console.ReadKey();
        Console.WriteLine();
        Console.Clear();

        Console.WriteLine(Symbol.Key);
        if (Symbol.KeyChar == ' ')
        {
          Console.WriteLine("Пробел");
          spaceValue++;
        }
        if (Symbol.KeyChar == '.')
        {
          break;
        }
      } while (true);
      Console.WriteLine("Количество введенных пробелов = " + spaceValue);
    }
  }
}
