﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnicornsAndRainbows;

namespace UnicornsAndRainbowsTests
{
    [TestClass]
    public class SearchEngineManager_Tests
    {
        [TestMethod]
        public void when_I_click_on_a_button__the_proper_page_is_launched_in_the_browser()
        {
            var userInterface = new UserInterfaceSimulator();

            var configuration = new Configuration { SearchRoot = "http://www.example.com/search/term=" };

            var browserNavigator = new BrowserNavigatorSimulator();

            var searchEngine = new SearchEngine(configuration, browserNavigator);

            SearchEngineManager.Setup(userInterface, searchEngine);

            userInterface.SimulateButtonClick("Puppies");
            Assert.AreEqual(configuration.SearchRoot + "Puppies", browserNavigator.Uri.OriginalString);
        }

        [TestMethod]
        public void when_I_change_the_searchRoot_and_click_on_a_button__the_proper_page_is_launched_in_the_browser()
        {
            var userInterface = new UserInterfaceSimulator();

            var configuration = new Configuration { SearchRoot = "http://www.example.com/search/term=" };

            var browserNavigator = new BrowserNavigatorSimulator();

            var searchEngine = new SearchEngine(configuration, browserNavigator);

            SearchEngineManager.Setup(userInterface, searchEngine);

            configuration.SearchRoot = "http://www.example.com/makethesearch/term=";
            userInterface.SimulateButtonClick("Puppies");
            Assert.AreEqual(configuration.SearchRoot + "Puppies", browserNavigator.Uri.OriginalString);
        }
    }
}