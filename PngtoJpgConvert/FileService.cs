namespace PngtoJpgConvert
{
    public class FileService
    {

        public static string ExtractPathAfterTwoDirectories(string filePath)
        {
            // Split the path into its individual parts
            string[] pathParts = filePath.Split(Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar);

            // Ensure there are at least three parts to the path
            if (pathParts.Length > 3)
            {
                // Join the path parts starting from the third one
                return string.Join(Path.DirectorySeparatorChar.ToString(), pathParts, 2, pathParts.Length - 2);
            }

            // If the path has less than three parts, return the original path or handle as needed
            return filePath;
        }

        public static void WriteToLog(string log)
        {
            string fileName = "log.txt";
            if (!File.Exists(fileName))
            {
                File.Create(fileName).Close();
            }

            using (StreamWriter stramWriter = File.AppendText(fileName))
            {
                stramWriter.WriteLine($"** {DateTime.Now} **");
                stramWriter.WriteLine(log);
                stramWriter.WriteLine();
            }
        }
    }
}
