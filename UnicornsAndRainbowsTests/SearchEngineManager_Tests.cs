using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnicornsAndRainbows;

namespace UnicornsAndRainbowsTests
{
    [TestClass]
    public class SearchEngineManager_Tests
    {
        [TestMethod]
        public void when_I_click_on_a_button__the_proper_term_is_searched()
        {
            var userInterface = new UserInterfaceSimulator();

            var searchEngine = new SearchEngineSimulator();

            SearchEngineManager.Setup(userInterface, searchEngine);

            userInterface.SimulateButtonClick("Puppies");
            Assert.AreEqual( "Puppies", searchEngine.SearchTerm);
        }
    }
}
