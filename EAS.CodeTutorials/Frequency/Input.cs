using System.IO;

namespace EAS.CodeTutorials.Frequency
{
    ////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>   An input. </summary>
    ///
    /// <remarks>   A Beging, 15.12.2020. </remarks>
    ////////////////////////////////////////////////////////////////////////////////////////////////////
    public static class Input
    {
        public static string[] Data
        {
            get
            {
                string executingDirectory = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
                string inputPath = Path.Combine(executingDirectory ?? string.Empty, "input.txt");
                return File.ReadAllLines(inputPath);
            }
        }
    }
}
