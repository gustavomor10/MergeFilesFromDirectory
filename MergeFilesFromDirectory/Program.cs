using System.IO;

namespace MergeFilesFromDirectory
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] txtFiles;
            string txtFileDestination = @"C:\PSWA\Stop Loss\QP\Files\";
            txtFiles = Directory.GetFiles( txtFileDestination, "*.txt");
            using (StreamWriter writer = new StreamWriter(txtFileDestination + @"\allfiles.txt"))
            {
                for (int i = 0; i < txtFiles.Length; i++)
                {
                    using (StreamReader reader = File.OpenText(txtFiles[i]))
                    {
                        writer.Write(reader.ReadToEnd());
                    }
                }
            }
        }
    }
}
