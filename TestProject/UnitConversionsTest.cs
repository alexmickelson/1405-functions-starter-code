namespace TestProject;

public class UnitConversionsTest
{
    [Fact]
    public void InchesToCentimeters_WorksWithOne()
    {
        // Arrange
        decimal inches = 1m;

        // Act
        decimal actual = UnitConversions.InchesToCentimeters(inches);
        decimal expected = 2.54m;

        // Assert
        Assert.Equal(expected, actual);
    }

    // [Fact]
    // public void InchesToCentimeters_WorksWithPositiveNumbers()
    // {
    //     // Arrange
    //     decimal inches = 3.5m;

    //     // Act
    //     decimal actual = UnitConversions.InchesToCentimeters(inches);
    //     decimal expected = 8.890m;

    //     // Assert
    //     Assert.Equal(expected, actual);
    // }

    // [Fact]
    // public void InchesToCentimeters_WorksWithNegativeNumbers()
    // {
    //     // Arrange
    //     decimal inches = -8.2m;

    //     // Act
    //     decimal actual = UnitConversions.InchesToCentimeters(inches);
    //     decimal expected = -20.828m;

    //     // Assert
    //     Assert.Equal(expected, actual);
    // }

    // [Fact]
    // public void InchesToCentimeters_WorksWithZero()
    // {
    //     // Arrange
    //     decimal inches = 0m;

    //     // Act
    //     decimal actual = UnitConversions.InchesToCentimeters(inches);
    //     decimal expected = 0.0m;

    //     // Assert
    //     Assert.Equal(expected, actual);
    // }

    // [Fact]
    // public void YardsToMeters_WorksWithOne()
    // {
    //     // Arrange
    //     double yards = 1;

    //     // Act
    //     double actual = UnitConversions.YardsToMeters(yards);
    //     double expected = 0.9144;

    //     // Assert
    //     Assert.Equal(expected, actual);
    // }

    // [Fact]
    // public void YardsToMeters_WorksWithImpreciseOne()
    // {
    //     // Arrange
    //     double yards = 1;

    //     // Act
    //     double actual = UnitConversions.YardsToMeters(yards);
    //     double expected = 0.91439999999999999;

    //     // Assert
    //     Assert.Equal(expected, actual);
    // }

    // [Fact]
    // public void YardsToMeters_WorksWithNegative()
    // {
    //     // Arrange
    //     double yards = -5.453893;

    //     // Act
    //     double actual = UnitConversions.YardsToMeters(yards);
    //     double expected = -4.9870397592;

    //     // Assert
    //     Assert.Equal(expected, actual);
    // }

    // [Fact]
    // public void YardsToMeters_WorksWithZero()
    // {
    //     // Arrange
    //     double yards = 0;

    //     // Act
    //     double actual = UnitConversions.YardsToMeters(yards);
    //     double expected = 0.0;

    //     // Assert
    //     Assert.Equal(expected, actual);
    // }

    // [Fact]
    // public void MilesToKilometers_WorksWithPositive()
    // {
    //     // Arrange
    //     decimal miles = 4235.53423m;

    //     // Act
    //     double actual = UnitConversions.MilesToKilometers(miles);
    //     double expected = 6816.4315998451202;

    //     // Assert
    //     Assert.Equal(expected, actual);
    // }

    // [Fact]
    // public void MilesToKilometers_WorksWithNegative()
    // {
    //     // Arrange
    //     decimal miles = 4235.53423m;

    //     // Act
    //     double actual = UnitConversions.MilesToKilometers(miles);
    //     double expected = 6816.4315998451202;

    //     // Assert
    //     Assert.Equal(expected, actual);
    // }

    // [Fact]
    // public void MilesToKilometers_WorksWithZero()
    // {
    //     // Arrange
    //     decimal miles = 0m;

    //     // Act
    //     double actual = UnitConversions.MilesToKilometers(miles);
    //     double expected = 0.0;

    //     // Assert
    //     Assert.Equal(expected, actual);
    // }
    
    // [Fact]
    // public void IsApproximate_CanCheckNearEquality()
    // {
    //     // Arrange
    //     double first = 0.001;
    //     decimal second = 0.002m;

    //     // Act
    //     bool actual = UnitConversions.IsApproximate(first, second, 2);

    //     // Assert
    //     Assert.True(actual);
    // }

    // [Fact]
    // public void IsApproximate_CanDetectWhenNotApproximate()
    // {
    //     // Arrange
    //     double first = 0.001;
    //     decimal second = 0.06m;

    //     // Act
    //     bool actual = UnitConversions.IsApproximate(first, second, 2);

    //     // Assert
    //     Assert.False(actual);
    // }

    // [Fact]
    // public void IsApproximate_WorksWithNumbersLargerThanOne_1()
    // {
    //     // Arrange
    //     double first = 1.001;
    //     decimal second = 1.007m;

    //     // Act
    //     bool actual = UnitConversions.IsApproximate(first, second, 2);

    //     // Assert
    //     Assert.True(actual);
    // }

    // [Fact]
    // public void IsApproximate_WorksWithNumbersLargerThanOne_2()
    // {
    //     // Arrange
    //     double first = 1.009;
    //     decimal second = 1.01m;

    //     // Act
    //     bool actual = UnitConversions.IsApproximate(first, second, 2);

    //     // Assert
    //     Assert.False(actual);
    // }
}