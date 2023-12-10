using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder
{
    public class BookBuilder : IBookBuilder
    {
        // Book(Cover, chapter 1, section 1, section 22, section 2, section4,...)
        private readonly Book _book = new Book();

        public BookBuilder()
        {
            _book.Chapters = new List<Chapter>();
        }
        public Book Builder()
        {
            return _book;
        }

        public CoverBuilder AddCover()
        {
            //this is a separated builder
            return new CoverBuilder(_book);
        }

        public ChapterBuilder AddChapter()
        {
            //this is a separated builder
            return new ChapterBuilder(_book);
        }

        public Book Build()
        {
            return _book;
        }
    }
}
