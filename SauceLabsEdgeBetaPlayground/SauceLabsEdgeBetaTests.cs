using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Remote;

namespace SauceLabsEdgeBetaPlayground
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            // Arrange
            string userName = "";
            string password = "";

            Uri uri = new Uri($"https://{userName}:{password}@ondemand.us-west-1.saucelabs.com:443/wd/hub");
            DriverOptions driverOptions = new EdgeOptions { BrowserVersion = "beta" };

            // Act
            IWebDriver driver = new RemoteWebDriver(uri, driverOptions);

            // Assert
            Assert.IsNotNull(driver);
        }
    }
}