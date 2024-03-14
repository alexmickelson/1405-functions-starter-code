
public static class UnitConversions
{

  public static decimal InchesToCentimeters(decimal inches)
  {
    return 0m;
  }

  public static double YardsToMeters(double yards)
  {
    return 0;
  }

  public static double MilesToKilometers(decimal miles)
  {
    return 0;
  }

  public static bool IsApproximate(double firstNumber, decimal secondNumber, int precisionAfterDecimalPoint)
  {
    // checks for approximate equality between a double and a decimal
    // this adjusts for midor differences between floating point precision errors
    // 0.00001 and 0.001 are approximately equal with 2 points of precision after the decimal point

    return false;
  }
}