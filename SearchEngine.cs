using System;

namespace UnicornsAndRainbows
{
    public interface ISearchEngine
    {
        void Search(string searchTerm);
    }

    public class SearchEngine : ISearchEngine
    {
        Configuration m_configuration;
        IBrowserNavigator m_browserNavigator;

        public SearchEngine(Configuration configuration, IBrowserNavigator browserNavigator)
        {
            m_configuration = configuration;
            m_browserNavigator = browserNavigator;
        }

        public void Search(string searchTerm)
        {
            m_browserNavigator.NavigateToUrl(new Uri(m_configuration.SearchRoot + searchTerm));
        }
    }
}
