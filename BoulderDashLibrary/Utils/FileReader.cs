using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoulderDashLibrary.Utils
{
    public static class FileReader
    {
        public static string[] ReadFile(int level)
        {
            try
            {
                var projectPath = Path.GetDirectoryName(Path.GetDirectoryName(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase)));
                // Give correct path as parameter
                // var fullPath = new Uri(projectPath + @"\BoulderDash/....").LocalPath;
                var fullPath = new Uri(projectPath + @"\Levels\BD_level" + level + ".txt").LocalPath;

                var textFile = File.ReadAllLines(fullPath);

                return textFile;
            }
            catch (Exception e)
            {
                Console.WriteLine("Er is iets fout gegaan met het inladen van het bestand! \n" + e.InnerException);

                return null;
            }
        }
    }
}
