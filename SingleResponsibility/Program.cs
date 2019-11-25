using System;
using System.Diagnostics;

namespace SingleResponsibility
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var journal = new Journal();
            journal.AddEntry("I cried today");
            journal.AddEntry("I ate a bug");
            Console.WriteLine(journal);
            var persist = new Persistence();
            var fileName = "journal.txt";
            persist.SaveToFile(journal, fileName, true);
            Process.Start(fileName);
            Console.ReadLine();
        }
    }
}