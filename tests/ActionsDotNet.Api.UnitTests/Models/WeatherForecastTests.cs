using ActionsDotNet.Api.Models;

namespace ActionsDotNet.Api.UnitTests.Models;

public class WeatherForecastTests
{
    [Fact]
    public void TemperatureFShouldReturnCorrectValueBasedOnTemperatureC()
    {
        var weatherForecast = new WeatherForecast
        {
            TemperatureC = 0
        };

        Assert.Equal(32, weatherForecast.TemperatureF);
    }
}