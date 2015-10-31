using System;

namespace UnicornsAndRainbows
{
    public static class SearchEngineManager
    {
        public static void Setup(IUserInterface userInterface, ISearchEngine searchEngine)
        {
            userInterface.OnButtonClick += (sender, searchTerm) => searchEngine.Search(searchTerm);
        }
    }
}
