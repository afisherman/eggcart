using System;

public class Eggcarton
{
  public static void Main()
  {
    //an array fixed in size of 12
    int [] eggcart = new int[] {1,2,3,4,5,6,7,8,9,10,11,12};

    foreach (int egg in eggcart)
    {
      Console.WriteLine("Egg number: " + egg);
    }
  }
}
