using System;
using Xunit;
using SimpleAPI.Controllers;
using Moq;
using Microsoft.Extensions.Logging;
using System.Linq;

namespace SimpleAPI.Test
{
    public class WeatherForecastTest
    {
        Mock<ILogger<WeatherForecastController>> _objMockLogger;
        WeatherForecastController _controller;

        public WeatherForecastTest(){
            _objMockLogger = new Mock<ILogger<WeatherForecastController>>();
            _controller = new WeatherForecastController(_objMockLogger.Object);
        }

        [Fact]
        public void Test1()
        {
            var result = _controller.GetWeatherForecast().ToList();
            Assert.Equal(0, result.Count);
        }
    }
}
