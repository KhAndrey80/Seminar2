//палиндром, пятизначное
using System;

public class Answer
{
    static bool IsPalindrome(int number){
      // Введите свое решение ниже
      
      int N1 = (number - number %10000) / 10000;
      int N2 = ((number-number %1000) %10000) / 1000;
      int N4 = (number %100 - number %10) / 10;
      int N5 = number %10;
      
      if (number < 10000 || number > 100000)
      {
        Console.WriteLine("Число не пятизначное");
        return false;
      }
      else if (N1 == N5 && N2 == N4)
      {
        return true;
      }
      else 
        return false;
    }
  // Не удаляйте и не меняйте метод Main! 
      static public void Main(string[] args) {
        int number;

        if (args.Length >= 1) {
            number = int.Parse(args[0]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            number = 563650;
        }

        // Не удаляйте строки ниже
        bool result = IsPalindrome(number);
        System.Console.WriteLine($"{result}");
    }
}
