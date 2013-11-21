using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame {
  class Program {
    static void Main(string[] args) {
      var game = new GuessingGame();
      game.Play();

      Console.WriteLine("Press any key to continue...");
      Console.ReadKey();
    }
  }
}
