using System;

namespace Inkapsling
{
  class Program
  {
    static void Main(string[] args)
    {
      Cake princess = new Cake();
      
      princess.Xp = 600;

      // princess.Xp += 60;

      Console.WriteLine(princess.Level);

      // princess.Weight = -900;

      // while (true)
      // {
      //   Console.WriteLine(princess.Weight);
      //   Console.ReadLine();
      // }

      // princess.CheckAllStats();
      

      Console.ReadLine();
    }
  }
}
