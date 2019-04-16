using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace massivy3
{
  class Program
  {
    static void Main(string[] args)
    {
      int spaceValue = 0;
      ConsoleKeyInfo symbol;
      do
      {
        Console.WriteLine("Введите символ для конвертации регистра");
        Console.WriteLine("Для окончания ввода нажмите ESC ");
        symbol = Console.ReadKey();
        Console.WriteLine();
        Console.Clear();
        Console.WriteLine("Введенный символ " + symbol.KeyChar);
        if (char.IsLetter(Convert.ToChar(symbol.KeyChar)))
        {
          if (char.IsUpper(Convert.ToChar(symbol.KeyChar)))
          {
            Console.WriteLine("Конвертируемый символ " + char.ToLower(Convert.ToChar(symbol.KeyChar)));
          }
          else
          {
            Console.WriteLine("Конвертируемый символ " + char.ToUpper(Convert.ToChar(symbol.KeyChar)));
          }
        }

        if (Convert.ToInt32(symbol.KeyChar) == 27)
        {
          break;
        }
      } while (true);
    }
  }
}
