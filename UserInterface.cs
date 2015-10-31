using System;
using System.Windows.Forms;

namespace UnicornsAndRainbows
{
    public interface IUserInterface
    {
        event EventHandler<string> OnButtonClick;

        void SetCount(int count);
    }

    public class UserInterface : IUserInterface
    {
        private Label m_countLabel;

        public UserInterface(Button unicornsButton, Button rainbowsButton, Label countLabel)
        {
            unicornsButton.Click += ButtonClick;
            rainbowsButton.Click += ButtonClick;

            m_countLabel = countLabel;
        }

        public event EventHandler<string> OnButtonClick;

        void ButtonClick(object sender, EventArgs e)
        {
            if (OnButtonClick != null)
            {
                OnButtonClick(sender, ((Button)sender).Text);
            }
        }

        public void SetCount(int count)
        {
            m_countLabel.Text = count.ToString();
        }
    }
}
