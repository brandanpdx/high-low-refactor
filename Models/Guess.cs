using System;
namespace HighLow.Guess
{
  public class Numbers
{
  private static int _maxNumber = 100;
  private static int _minNumber = 1;
  private static int _computerGuess = 50;

    public static void GuessNumber(string response)
    {
      if (response == "lower")
      {
        Numbers._maxNumber = _computerGuess - 1;
        Numbers._computerGuess = (Numbers._maxNumber + Numbers._minNumber)/2;
        Program.Question();
      }
      else if (response == "higher")
      {
        Numbers._minNumber = _computerGuess + 1;
        Numbers._computerGuess = (Numbers._maxNumber + Numbers._minNumber)/2;
        Program.Question();
      }
      else
      {
        Console.WriteLine("Sorry, that is not an expected response.");
        Program.Question();
      }
    }
    public static int GetNumber()
    {
      return _computerGuess;
    }

  }
}