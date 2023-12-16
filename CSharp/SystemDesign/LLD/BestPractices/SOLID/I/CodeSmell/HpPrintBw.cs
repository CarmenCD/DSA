namespace BestPractices.SOLID.I.CodeSmell
{
    internal class HpPrintBw : IPrinter
    {
        public void Print()
        {
            Console.WriteLine("General print");
        }

        public void PrintBlackAndWhite()
        {
            Console.WriteLine("Black and White print");
        }

        /// <summary>
        /// broke L principle -  no need to be implemented
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        public void PrintColor()
        {
            // code smell for I - return or NotImplementedException
            // return;
            throw new NotImplementedException();
        }
    }
}
