using System;

namespace UnicornsAndRainbows
{
    public class ClickCountManager
    {
        public ClickCountManager(IUserInterface userInterface, IClickCounter clickCounter)
        {
            userInterface.OnButtonClick += (sender, searchTerm) => clickCounter.IncrementCount();
            clickCounter.CountIncremented += (sender, count) => userInterface.SetCount(count);
        }
    }
}
