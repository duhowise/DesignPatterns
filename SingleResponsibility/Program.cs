using System;
using System.Collections.Generic;
using System.IO;

namespace SingleResponsibility
{
    public class Journal
    {
        private readonly List<string> entries = new List<string>();
        private static int count = 0;

        public int AddEntry(string text)
        {
            entries.Add($"{++count}: {text}");
            return count;
        }

        public void RemoveEntry(int index)
        {
            entries.RemoveAt(index);
        }

        public override string ToString()
        {
            return string.Join(Environment.NewLine, entries);
        }

        public void Save(string filename)
        {
            File.WriteAllText(filename, ToString());
        }

        public static Journal Load(string fileName)
        {
            throw new NotImplementedException();
        }

        public static Journal Load(Uri uri)
        {
            throw new NotImplementedException();
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            var journal = new Journal();
            journal.AddEntry("I cried today");
            journal.AddEntry("I ate a bug");
            Console.WriteLine(journal);
            Console.ReadLine();
        }
    }
}