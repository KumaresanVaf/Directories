namespace Directories
{
    public class File_IO
    {
        public void FileAttributes()
        {
            string filePath = "E:\\kk\\System_IO\\FileClass\\Samples.txt";

            // Check if the file exists
            if (File.Exists(filePath))
            {
                Console.WriteLine("File exists.");
                // Read the contents of the file
                string fileContents = File.ReadAllText(filePath);
                Console.WriteLine("File contents:");
                Console.WriteLine("\t" + fileContents);
            }
            else
            {
                Console.WriteLine("File does not exist.");

                // Create a new file
                Console.WriteLine("Creating a new file...");
                File.WriteAllText(filePath, "Hello, World!");
                Console.WriteLine("File created.");
            }

            // File Appended Add text
            Console.WriteLine("Appending text to the file...");
            File.AppendAllText(filePath, "\nAdditional text.");
            Console.WriteLine("Text appended.");

            // File Read
            string updatedContents = File.ReadAllText(filePath);
            Console.WriteLine("\nUpdated file contents:");
            Console.WriteLine(updatedContents);

            // File Copy
            string CopyFilePath = "E:\\kk\\System_IO\\FileClass\\Copyfile.txt";
            Console.WriteLine($"\nCopying file to {CopyFilePath}...");
            try
            {
                File.Copy(filePath, CopyFilePath);
                Console.WriteLine("File copied.");
            }
            catch (IOException ex)
            {
                Console.WriteLine($"Error while copying the file: {ex.Message}");
            }

            //File Move
            string filemovePath = "E:\\kk\\System_IO\\FileClass\\FileMove\\";
            string filename = filemovePath + "MoveFile" + DateTime.Now.Millisecond.ToString() + ".txt";
            if (File.Exists(filePath))
            {
                File.Move(filePath, filename);
                Console.WriteLine("\nFile moved successfully.");
            }
            else
            {
                Console.WriteLine("\nSource file does not exist.");
            }

            // File Delete
            Console.WriteLine("\nDeleting the original file...");
            File.Delete(filePath);
            Console.WriteLine("File deleted.");
        }
    }
}