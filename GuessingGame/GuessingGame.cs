using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame {
  public class GuessingGame {
    public void Play() {
      var correctAnswer = PickANumber();
      Console.WriteLine("I have picked a number between 1 and 1000, try to guess it.");
      var victory = DoGuesses(correctAnswer);

      ShowResults(victory, correctAnswer);
    }

    public bool DoGuesses(int correctAnswer) {
      var victory = false;

      var guessesRemaining = 10;

      while (guessesRemaining > 0) {
        var guess = GetNextGuess();

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

      return victory;
    }

    public int PickANumber() {
      var randomNumberGenerator = new Random();
      return randomNumberGenerator.Next(1, 1000);
    }

    public int GetNextGuess() {
      Console.Write("Enter your guess:");
      return Convert.ToInt32(Console.ReadLine());
    }

    public static void ShowResults(bool victory, int correctAnswer) {
      if (victory) {
        Console.WriteLine("Congrats, you guessed it!");
      }
      else {
        Console.WriteLine("Sorry, my number was " + correctAnswer + ". Better luck next time.");
      }
    }
  }
}
