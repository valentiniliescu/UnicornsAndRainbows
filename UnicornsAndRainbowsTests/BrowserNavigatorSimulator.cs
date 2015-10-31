using System;

namespace UnicornsAndRainbowsTests
{
    class BrowserNavigatorSimulator: IBrowserNavigator
    {
        public Uri Uri { get; set; }

        public void NavigateToUrl(Uri uri)
        {
            Uri = uri;
        }
    }
}
