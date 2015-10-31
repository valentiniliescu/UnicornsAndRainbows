using System;

namespace UnicornsAndRainbows
{
    public static class Manager
    {
        public static void Setup(IUserInterface userInterface, Configuration configuration, IBrowserNavigator browserNavigator)
        {
            userInterface.OnButtonClick += (sender, searchTerm) => browserNavigator.NavigateToUrl(new Uri(configuration.SearchRoot + searchTerm));
        }
    }
}
