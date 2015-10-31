using System;
using UnicornsAndRainbows;

namespace UnicornsAndRainbowsTests
{
    class SearchEngineSimulator: ISearchEngine
    {
        public string SearchTerm { get; set; }

        public void Search(string searchTerm)
        {
            SearchTerm = searchTerm;
        }
    }
}
