// See https://aka.ms/new-console-template for more information
using System.Reflection.Metadata;
using DesignPatterns.Builder;

// builder
CarBuilder builder = new CarBuilder();
builder.SetColor("blue");
builder.SetMake("Jan");
builder.SetModel("WV");
builder.SetYear(2023);
builder.Build();

// builder
CarBuilder builder1 = new CarBuilder();
builder.SetColor("blue") //if this return builder
    .SetMake("feb")
    .SetModel("WV")
    .SetYear(2023);

builder.Build();

//problem of chapter
IBookBuilder builder2 = new BookBuilder();
Book b = builder2.AddChapter().WithContent("content 1").WithOpeningQuote("quote 1")
    .AddChapter().WithContent("content 2").WithOpeningQuote("quote 2")
    .Build(); // if I return this the same is returned. Should return a new Book Chapter ??? to check

foreach (Chapter ch in b.Chapters)
{
    Console.WriteLine($"Content: {ch.Content} OpenQuote {ch.OpeningQuote}");
}
