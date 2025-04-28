using Homework02.App.Interfaces;

namespace Homework02.App.Class
{
    public class WebPage : ISearchable
    {
        public string Content { get; set; }

        public WebPage(string content)
        {
            Content=content;
        }

        public bool Search(string word)
        {
            bool result = Content.Contains(word);
            return result;
        }
    }
}
