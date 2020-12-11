using System.IO;

namespace EAS.CodeTutorials.RocketFuel
{
    public static class Input
    {
        public static string[] Data
        {
            get
            {
                var executingDirectory = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
                var inputPath = Path.Combine(executingDirectory ?? string.Empty, "input.txt");
                return File.ReadAllLines(inputPath);
            }
        }
    }
}
