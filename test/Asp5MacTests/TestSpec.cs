using System;
using Xunit;

public class TestSpec {
    sfagsadf
    [Theory]
    [InlineData(-1)]
    [InlineData(0)]
    [InlineData(1)]
    public void ReturnFalseGivenValuesLessThan2(int value) {
        var result = value >= 2;
        Assert.False(result, String.Format("{0} should less than 2", value));
    }
}