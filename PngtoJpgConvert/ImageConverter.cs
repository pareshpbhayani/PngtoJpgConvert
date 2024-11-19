using PngtoJpgConvert;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

public class ImageConverter
{
    // Main method to process the entire directory and its subdirectories
    public static void ConvertPngToJpgInNestedFolders(string sourceFolder)
    {
        // Process all PNG files in the current folder
        ConvertPngFilesInFolder(sourceFolder);

        // Recursively process all subfolders
        foreach (var directory in Directory.GetDirectories(sourceFolder))
        {
            ConvertPngToJpgInNestedFolders(directory);
        }
    }

    // Method to convert PNG files to JPG within a specific folder
    private static void ConvertPngFilesInFolder(string folderPath)
    {
        // Get all PNG files in the folder
        string[] pngFiles = Directory.GetFiles(folderPath, "*.png");

        if (pngFiles.Length == 0)
        {
            return; // No PNG files, skip this folder
        }

        // Create a 'JPG' subfolder within the current folder
        string jpgFolderPath = Path.Combine(folderPath, "JPG");
        if (!Directory.Exists(jpgFolderPath))
        {
            Directory.CreateDirectory(jpgFolderPath);
        }

        foreach (var pngFile in pngFiles)
        {
            try
            {
                // Load the PNG image
                using (Image image = Image.FromFile(pngFile))
                {
                    // Create the filename for the JPG image inside the 'JPG' folder
                    string jpgFileName = Path.Combine(jpgFolderPath, Path.GetFileNameWithoutExtension(pngFile) + ".jpg");

                    // Save the image as JPG
                    image.Save(jpgFileName, ImageFormat.Jpeg);
                }
                FileService.WriteToLog($"Converted {Path.GetFileName(pngFile)} to JPG in {FileService.ExtractPathAfterTwoDirectories(jpgFolderPath)}.");
            }
            catch (Exception ex)
            {
                FileService.WriteToLog(ex.ToString());
            }
        }
    }
}