namespace BestPractices.SOLID.I.Implementation
{
    internal class HpPrinterBw : IBwPrinter
    {
        public void Print()
        {
            Console.WriteLine("Black and White print");
        }
    }
}
