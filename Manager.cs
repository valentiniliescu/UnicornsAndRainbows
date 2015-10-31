using System;

namespace UnicornsAndRainbows
{
    public class Manager
    {
        public Manager(IUserInterface userInterface, Configuration configuration, IBrowserNavigator browserNavigator, IClickCounter clickCounter)
        {
            userInterface.OnButtonClick += (sender, searchTerm) => clickCounter.IncrementCount();
            userInterface.OnButtonClick += (sender, searchTerm) => browserNavigator.NavigateToUrl(new Uri(configuration.SearchRoot + searchTerm));

            clickCounter.CountIncremented += (sender, count) => userInterface.SetCount(count);
        }
    }
}
