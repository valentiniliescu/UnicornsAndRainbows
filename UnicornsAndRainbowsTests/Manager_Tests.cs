using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnicornsAndRainbows;

namespace UnicornsAndRainbowsTests
{
    [TestClass]
    public class Manager_Tests
    {
        [TestMethod]
        public void when_I_click_on_a_button__the_proper_page_is_launched_in_the_browser()
        {
            var userInterface = new UserInterfaceSimulator();

            var configuration = new Configuration { SearchRoot = "http://www.example.com/search/term=" };

            var browserNavigator = new BrowserNavigatorSimulator();

            var clickCounter = new ClickCounter();

            ClickCountManager.Setup(userInterface, clickCounter);
            Manager.Setup(userInterface, configuration, browserNavigator);

            userInterface.SimulateButtonClick("Puppies");
            Assert.AreEqual(configuration.SearchRoot + "Puppies", browserNavigator.Uri.OriginalString);
            Assert.AreEqual(1, userInterface.Count);
        }

        [TestMethod]
        public void when_I_change_the_searchRoot_and_click_on_a_button__the_proper_page_is_launched_in_the_browser()
        {
            var userInterface = new UserInterfaceSimulator();

            var configuration = new Configuration { SearchRoot = "http://www.example.com/search/term=" };

            var browserNavigator = new BrowserNavigatorSimulator();

            var clickCounter = new ClickCounter();

            ClickCountManager.Setup(userInterface, clickCounter);
            Manager.Setup(userInterface, configuration, browserNavigator);

            configuration.SearchRoot = "http://www.example.com/makethesearch/term=";
            userInterface.SimulateButtonClick("Puppies");
            Assert.AreEqual(configuration.SearchRoot + "Puppies", browserNavigator.Uri.OriginalString);
            Assert.AreEqual(1, userInterface.Count);
        }
    }
}
