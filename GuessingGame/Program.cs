using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame {
  class Program {
    static void Main(string[] args) {
      var randomNumberGenerator = new Random();
      var correctAnswer = randomNumberGenerator.Next(1, 1000);

      Console.WriteLine("I have picked a number between 1 and 1000, try to guess it.");

      var victory = false;

      var guessesRemaining = 10;

      while (guessesRemaining > 0) {
        Console.Write("Enter your guess:");
        var guess = Convert.ToInt32(Console.ReadLine());

        if (guess == correctAnswer) {
          victory = true;
          break;
        }
        else if (guess < correctAnswer) {
          Console.WriteLine("Higher.");
        }
        else if (guess > correctAnswer) {
          Console.WriteLine("Lower.");
        }

        guessesRemaining--;
      }

      if (victory) {
        Console.WriteLine("Congrats, you guessed it!");
      }
      else {
        Console.WriteLine("Sorry, my number was " + correctAnswer + ". Better luck next time.");
      }

    }
  }
}
