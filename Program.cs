using System;
using System.Collections.Generic;
using HighLow.Guess;

namespace HighLow {

  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Would you like to play the higher/lower game? ['Y' for yes, 'N' for no]");
      string answer = Console.ReadLine();
      if (answer == "Y" || answer == "y")
      {
        Console.WriteLine("Think of a number between 1 and 100...");
        Question();
      }
    }
    public static void Question()
    {
      Console.WriteLine("Is your number higher or lower than " + Numbers.GetNumber() + "? [Please respond 'higher', 'lower' or 'correct']");
      string response = Console.ReadLine();
      if (response == "correct")
      {
        Console.WriteLine("We guessed your number!");
      }
      else{
        Numbers.GuessNumber(response);
      }
    }
  }
}
  
  

