using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace TaskManager
{
    public class FileManager
    {
        public static void WriteToFile(string[] data, string path)
        {
            File.WriteAllText(path, string.Join("\n", data));
        }
        
        public static void AppendToFile(string data, string path)
        {
            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine(data);
            }
        }

        public static void ReplaceRowInFile(string path, string oldRow, string newRow)
        {
            string text = File.ReadAllText(path);
            text = text.Replace(oldRow, newRow);
            File.WriteAllText(path, text);
        }

        public static List<string[]> ReadFile(string path)
        {
            string[] readLines = File.ReadAllLines(path);
            List<string[]> result = new List<string[]>();
            foreach (string line in readLines)
                result.Add(line.Split(','));
            return result;
        }

        public static void RemoveLine(string path, string lineToRemove)
        {
            var tempFile = Path.GetTempFileName();
            var linesToKeep = File.ReadLines(path).Where(l => l != lineToRemove);

            File.WriteAllLines(tempFile, linesToKeep);

            File.Delete(path);
            File.Move(tempFile, path);
        }
    }
}
