using System;
using System.IO;

namespace SingleResponsibility
{
    public class Persistence
    {
        public void SaveToFile(Journal journal, string fileName, bool overWrite = false)
        {
            if (overWrite || File.Exists(fileName))
            {
                File.WriteAllText(fileName, journal.ToString());
            }
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
}