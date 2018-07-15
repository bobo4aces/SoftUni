using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _04.Files
{
    class Program
    {
        static void Main(string[] args)
        {
            int filesCount = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string,decimal>> rootAndFilesAndSize = new Dictionary<string, Dictionary<string, decimal>>();
            List<string> filesList = new List<string>();
            for (int i = 0; i < filesCount; i++)
            {
                string[] filePath = Console.ReadLine().Split('\\').ToArray();
                string root = filePath.First();
                string fileInfo = filePath.Last();
                string fileSizeAsText = fileInfo.Split(';').Last();
                decimal fileSize = decimal.Parse(fileInfo.Split(';').Last());
                string extention = fileInfo.Split('.').Last().Split(';').First();
                string fileName = fileInfo.Substring(0, fileInfo.Length - (extention.Length + fileSizeAsText.Length) - 2);
                if (!rootAndFilesAndSize.ContainsKey(root))
                {
                    rootAndFilesAndSize.Add(root, new Dictionary<string, decimal>());
                }
                if (rootAndFilesAndSize[root].ContainsKey(fileName + "." + extention))
                {
                    rootAndFilesAndSize[root][fileName + "." + extention] = fileSize;
                }
                else
                {
                    rootAndFilesAndSize[root].Add(fileName + "." + extention, fileSize);
                }
            }
            string[] quary = Console.ReadLine().Split(new char[] {' ' },StringSplitOptions.RemoveEmptyEntries).ToArray();
            bool hasMovies = false;
            foreach (var root in rootAndFilesAndSize)
            {
                if (root.Key==quary[2])
                {
                    foreach (var file in root.Value.OrderByDescending(s=>s.Value).ThenBy(s=>s.Key))
                    {
                        if (file.Key.Contains("." + quary[0]))
                        {
                            hasMovies = true;
                            Console.WriteLine($"{file.Key} - {file.Value} KB");
                        }
                    }
                }
            }
            if (!hasMovies)
            {
                Console.WriteLine("No");
            }
        }
    }
}
