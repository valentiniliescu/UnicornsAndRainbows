using System;

namespace UnicornsAndRainbows
{
    public interface IClickCounter
    {
        event EventHandler<int> CountIncremented;

        void IncrementCount();
    }

    public class ClickCounter: IClickCounter
    {
        public event EventHandler<int> CountIncremented;

        public int Count { get; private set; } = 0;

        public void IncrementCount()
        {
            Count++;

            OnCountIncremented(Count);
        }

        void OnCountIncremented(int count)
        {
            //TODO: thread safety
            if (CountIncremented != null)
            {
                CountIncremented(this, count);
            }
        }
    }
}
