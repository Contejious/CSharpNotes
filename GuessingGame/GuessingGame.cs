using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame {
  public class GuessingGame {
    
    public void Play(){
      var correctAnswer = InitializeCorrectValue();
      Console.WriteLine("I have picked a number between 1 and 1000, try to guess it.");

      var victory = false;
      var guessesRemaining = 10;

      while (guessesRemaining > 0 && !victory)
      {
        var guess = ReadNextGuess();
        guessesRemaining--;
        victory = CheckGuess(guess, correctAnswer);
      }

      ShowResults(victory, correctAnswer);
    }

    public int InitializeCorrectValue() {
      var randomNumberGenerator = new Random();
      return randomNumberGenerator.Next(1, 1000);
    }
    public int ReadNextGuess() {
      Console.Write("Enter your guess:");
      return Convert.ToInt32(Console.ReadLine());
    }
    public bool CheckGuess(int guess, int correctAnswer) {
      if (guess == correctAnswer) {
        return true;
      }
      else {
        if (guess < correctAnswer) {
          Console.WriteLine("Higher.");
        }
        else if (guess > correctAnswer) {
          Console.WriteLine("Lower.");
        }

        return false;
      }
    }
    public void ShowResults(bool victory, int correctAnswer)
    {
      if (victory) {
        Console.WriteLine("Congrats, you guessed it!");
      }
      else {
        Console.WriteLine("Sorry, my number was " + correctAnswer + ". Better luck next time.");
      }
    }
  }
}
