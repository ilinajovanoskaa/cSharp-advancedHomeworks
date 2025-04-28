using Homework02.App.Interfaces;

namespace Homework02.App.Class
{
    public class Document : ISearchable
    {
        public string Text { get; set; }

        public Document(string text)
        {
            Text=text;
        }

        public bool Search(string word)
        {
            bool result = Text.Contains(word);
            return result;
        }
    }
}
