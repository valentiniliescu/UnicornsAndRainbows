namespace UnicornsAndRainbows
{
    public static class ClickCountManager
    {
        public static void Setup(IUserInterface userInterface, IClickCounter clickCounter)
        {
            userInterface.OnButtonClick += (sender, searchTerm) => clickCounter.IncrementCount();
            clickCounter.CountIncremented += (sender, count) => userInterface.SetCount(count);
        }
    }
}
