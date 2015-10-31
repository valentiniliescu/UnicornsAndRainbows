using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnicornsAndRainbows;

namespace UnicornsAndRainbowsTests
{
    [TestClass]
    public class ClickCounterManager_Tests
    {
        [TestMethod]
        public void when_I_click_on_a_button__the_number_of_clicks_is_displayed()
        {
            var userInterface = new UserInterfaceSimulator();

            var clickCounter = new ClickCounter();

            ClickCountManager.Setup(userInterface, clickCounter);

            userInterface.SimulateButtonClick("Puppies");
            Assert.AreEqual(1, userInterface.Count);
        }
    }
}
