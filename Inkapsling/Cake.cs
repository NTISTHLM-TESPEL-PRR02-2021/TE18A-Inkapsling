using System;

namespace Inkapsling
{
  public class Cake
  {
    public string Name {get; private set;}
    public bool IsLie {get; private set;}

    private float weight; // 1-100

    private int xp = 0;

    public int Xp {
      get {
        return xp;
      }
      set {
        xp = Math.Max(0, value);
      }
    }

    public int Level {
      get {
        return 1 + xp / 10;
      }
      private set {

      }
    }


    private Random generator = new Random();

    public int Weight
    {
      get
      {
        // return generator.Next(100);
        return (int) weight;
      }
      set
      {
        weight = Math.Max(1, value);
      }
    }

    // public void SetWeight(int value)
    // {
    //   weight = Math.Max(1, value);
    // }

    // public int GetWeight()
    // {
    //   return (int) weight;
    // }

    // public void CheckAllStats()
    // {
    //   weight = Math.Max(0, weight);
    // }
  }
}
