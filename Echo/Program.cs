using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Echo {
  class Program {
    static void Main(string[] args)
    {
      var message = args[0];
      var count = Convert.ToInt32(args[1]);

      while (count > 0)
      {
        Console.WriteLine(message);
        count--;
      }
    }
  }
}
