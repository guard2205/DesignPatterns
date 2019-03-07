using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using static System.Console;

namespace DesignPatterns.Solid
{
    public class Journal
    {
        /// <summary>
        /// A class should have only a single responsibility, 
        /// only one reason to change ( High-cohesion, but low coupling)
        /// </summary>
        private readonly List<string> entries = new List<string>();
        private static int count = 0;
        public int AddEntry(string text)
        {
            entries.Add($"{++count}: {text}");
            return count; // memento
        }

        public void RemoveEntry(int Index)
        {
            entries.RemoveAt(Index);
        }
    }
    // instead of having all the load and save methods in the journal class, you put it in another class
    // in order to have only One var used by your journal class => One reason to change 
    // you will keep a good cohesion
    public class Persistence
    {
        public void SaveToFile ( Journal j, string filename, bool overwrite = false)
        {
            if (overwrite || !File.Exists(filename))
                File.WriteAllText(filename, j.ToString());
        }
    }
}
