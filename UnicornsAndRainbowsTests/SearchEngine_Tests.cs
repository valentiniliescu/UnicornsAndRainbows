using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnicornsAndRainbows;

namespace UnicornsAndRainbowsTests
{
    [TestClass]
    public class SearchEngine_Tests
    {
        [TestMethod]
        public void when_I_search_for_a_term__the_proper_page_is_launched_in_the_browser()
        {
            var configuration = new Configuration { SearchRoot = "http://www.example.com/search/term=" };

            var browserNavigator = new BrowserNavigatorSimulator();

            var searchEngine = new SearchEngine(configuration, browserNavigator);

            searchEngine.Search("Puppies");
            Assert.AreEqual(configuration.SearchRoot + "Puppies", browserNavigator.Uri.OriginalString);
        }

        [TestMethod]
        public void when_I_change_the_searchRoot_and_search_for_a_term__the_proper_page_is_launched_in_the_browser()
        {
            var configuration = new Configuration { SearchRoot = "http://www.example.com/search/term=" };

            var browserNavigator = new BrowserNavigatorSimulator();

            var searchEngine = new SearchEngine(configuration, browserNavigator);

            configuration.SearchRoot = "http://www.example.com/makethesearch/term=";
            searchEngine.Search("Puppies");
            Assert.AreEqual(configuration.SearchRoot + "Puppies", browserNavigator.Uri.OriginalString);
        }
    }
}
