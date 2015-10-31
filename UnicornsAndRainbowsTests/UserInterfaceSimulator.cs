using System;
using UnicornsAndRainbows;

namespace UnicornsAndRainbowsTests
{
    class UserInterfaceSimulator: IUserInterface
    {
        public event EventHandler<string> OnButtonClick;

        public void SimulateButtonClick(string searchTerm)
        {
            if (OnButtonClick != null)
            {
                OnButtonClick(this, searchTerm);
            }
        }

        public int Count { get; private set; }

        public void SetCount(int count)
        {
            Count = count;
        }
    }
}
