using System;

namespace UnicornsAndRainbows
{
    public class Manager
    {
        public Manager(IUserInterface userInterface, Configuration configuration, IBrowserNavigator browserNavigator)
        {
            userInterface.OnButtonClick += (sender, searchTerm) => browserNavigator.NavigateToUrl(new Uri(configuration.SearchRoot + searchTerm));
        }
    }
}
