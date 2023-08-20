namespace DesignPatterns.Builder
{
    public class ChapterBuilder
    {
        private readonly Book _book;
        public readonly Chapter _chapter = new Chapter();

        public ChapterBuilder(Book book)
        {
            _book = book;
        }

        public ChapterBuilder WithTitle(string title)
        {
            _chapter.Title = title;
            return this;
        }

        public ChapterBuilder WithContent(string content)
        {
            _chapter.Content = content;
            return this;
        }

        public ChapterBuilder WithOpeningQuote(string openingQuote)
        {
            _chapter.OpeningQuote = openingQuote;
            return this;
        }

        public ChapterBuilder AddChapter()
        {
            _book.Chapters.Add(_chapter);
            // return this; does this create problems?
            return new ChapterBuilder(_book);
        }

        public Book Build()
        {
            _book.Chapters.Add(_chapter);
            return _book;
        }
    }
}