using System.Reflection;

namespace DesignPatterns.Builder
{
    public class CoverBuilder
    {
        private Book _book;

        public CoverBuilder(Book book)
        {
            _book = book;
        }
        public CoverBuilder WithTitle(string title)
        {
            _book.Title = title;
            return this;
        }
        public CoverBuilder WithAuthor(string title)
        {
            _book.Author = title;
            return this;
        }
        public CoverBuilder WithPublisher(string title)
        {
            _book.Publisher = title;
            return this;
        }
    }
}