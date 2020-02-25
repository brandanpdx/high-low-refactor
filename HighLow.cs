using System;
using System.Collections.Generic;

public class Numbers
{
  public static int MaxNumber = 100;
  public static int MinNumber = 1;
  public static int ComputerGuess = 50;

  public static void Main()
  {
    Console.WriteLine("Would you like to play the higher/lower game? ['Y' for yes, 'N' for no]");
    string answer = Console.ReadLine();
    if (answer == "Y" || answer == "y");
    {
      Console.WriteLine("Think of a number between 1 and 100...");
      Question();
    }
  }
  public static void Question()
    {
      Console.WriteLine("Is your number higher or lower than " + Numbers.ComputerGuess + "? [Please respond 'higher', 'lower' or 'correct']");
      string response = Console.ReadLine();
      if (response == "correct")
      {
        Console.WriteLine("We guessed your number!");
      }
      else{
        GuessNumber(response);
      }
    }
  static void GuessNumber(string response)
  {
    if (response == "lower")
    {
      Numbers.MaxNumber = ComputerGuess - 1;
      Numbers.ComputerGuess = (Numbers.MaxNumber + Numbers.MinNumber)/2;
      Question();
    }
    else if (response == "higher")
    {
      Numbers.MinNumber = ComputerGuess + 1;
      Numbers.ComputerGuess = (Numbers.MaxNumber + Numbers.MinNumber)/2;
      Question();
    }
    else
    {
      Console.WriteLine("Sorry, that is not an expected response.");
      Question();
    }
  }
}