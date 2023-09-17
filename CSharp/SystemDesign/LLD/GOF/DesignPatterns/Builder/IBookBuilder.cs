namespace DesignPatterns.Builder;

public interface IBookBuilder
{
    CoverBuilder AddCover();
    ChapterBuilder AddChapter();
    Book Builder();
}