using System.Windows.Forms;

namespace UnicornsAndRainbows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            var userInterface = new UserInterface(c_buttonUnicorns, c_buttonRainbows, c_labelCount);
            var configuration = new Configuration { SearchRoot = "http://www.bing.com/images/search?q=" };
            var browserNavigator = new BrowserNavigator();
            var clickCounter = new ClickCounter();

            var searchEngine = new SearchEngine(configuration, browserNavigator);

            ClickCountManager.Setup(userInterface, clickCounter);
            SearchEngineManager.Setup(userInterface, searchEngine);
        }
    }
}
