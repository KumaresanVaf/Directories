namespace Directories
{
    public class FileInfoClass
    {
        public void FileInfoAttributes()
        {
            Console.WriteLine("Create file:");
            string filePath = @"E:\kk\System_IO\FileInfoClass\sample.docx";
            FileInfo file = new FileInfo(filePath);
            try
            {
                using (FileStream fs = file.Create())
                {
                    Console.WriteLine("File is created successfully.");
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Something went wrong: " + e.Message);
            }

            Console.WriteLine("\nWrite the text in file:");
            string filePath1 = @"E:\kk\System_IO\FileInfoClass\Samples.txt";
            FileInfo file1 = new FileInfo(filePath1);
            try
            {
                using (StreamWriter sw = file1.CreateText())
                {
                    sw.WriteLine("The FileInfo class is used to deal with files and perform file operations in C#.");
                    Console.WriteLine("Text written successfully.");
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Something went wrong: " + e.Message);
            }

            Console.WriteLine("\nAdd the text in file:");
            try
            {
                using (StreamWriter sw = file1.AppendText())
                {
                    sw.WriteLine("This is Extra \n Text");
                    Console.WriteLine("File has been appended");
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Something went wrong: " + e.Message);
            }

            Console.WriteLine("\nReadTheFile: ");
            try
            {
                using (StreamReader sr = file1.OpenText())
                {
                    string data = "";
                    while ((data = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(data);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Something went wrong: " + e.Message);
            }

            Console.WriteLine("\nCopyfile:");
            string sourcePath = @"E:\kk\System_IO\FileInfoClass\sample.docx";
            string CopyPath = @"E:\kk\System_IO\FileInfoClass\MoveFile\sample.docs";

            FileInfo sourceFile = new FileInfo(sourcePath);
            FileInfo copyfile = new FileInfo(CopyPath);

            if (!copyfile.Exists)
            {
                sourceFile.CopyTo(CopyPath);
                Console.WriteLine("File copied successfully.");
            }
            else
            {
                Console.WriteLine("The file already exists.");
            }
            Console.WriteLine("\nMoveFile:");
            if (!copyfile.Exists)
            {
                sourceFile.MoveTo(CopyPath);
                Console.WriteLine("File Move Successfully");
            }
            else
            {
                Console.WriteLine("Already This File Exists");
            }

            Console.WriteLine($"\nFile name is {file1.Name}");

            Console.WriteLine($"File creation time is {file1.CreationTime}");

            Console.WriteLine($"File last access time is {file1.LastAccessTime}");

            Console.WriteLine($"File length is {file1.Length} Bytes");

            Console.WriteLine($"File extension is {file1.Extension}");

            Console.WriteLine($"File exists: {file1.Exists}");

            Console.WriteLine($"File last write time is {file1.LastWriteTime}");

        }
    }
}