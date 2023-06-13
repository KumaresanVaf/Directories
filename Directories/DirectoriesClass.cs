namespace Directories
{
    public class DirectoriesClass
    {
        public void dire()
        {
            string directoryPath = @"E:\kk\Director";

            // Creating a directory
            string saveDirectoryPath = Path.Combine(directoryPath, "convert");
            Directory.CreateDirectory(saveDirectoryPath);
            Console.WriteLine("Directory created." + saveDirectoryPath);

            // Checking if a directory exists
            bool directoryExists = Directory.Exists(directoryPath);
            Console.WriteLine("Directory exists: " + directoryExists);

            string destDirName = @"E:\kk\";
            try
            {
                Directory.Move(saveDirectoryPath, destDirName);
            }
            catch (IOException exp)
            {
                Console.WriteLine(exp.Message);
            }

            // Getting the files in a directory
            string[] files = Directory.GetFiles(saveDirectoryPath);
            Console.WriteLine("\nFiles in the directory:");
            foreach (string file in files)
            {
                Console.WriteLine("\t" + file);
            }

            // Get a list of all subdirectories
            string root = @"C:\Program Files";
            string[] directories = Directory.GetDirectories(root, "A*");
            Console.WriteLine("\nSubdirectories in the directory:");
            Console.WriteLine("Subdirectories: {0}", directories.Count());
            foreach (string dir in directories)
            {
                Console.WriteLine("\t" + dir);
            }

            //Get a Drive
            Console.WriteLine("\nCount a Drive of computer:");
            string[] drives = System.IO.Directory.GetLogicalDrives();
            foreach (string drive in drives)
            {
                System.Console.WriteLine("\t" + drive);
            }

            // Lastaccesstime
            Directory.SetLastWriteTime(directoryPath, DateTime.Now);
            DateTime lastWriteTime = Directory.GetLastWriteTime(directoryPath);
            Console.WriteLine("\nlastWriteTime" + lastWriteTime);

            //Move
            string newDirectoryPath = @"E:\kk\MoveDirectory";
            string newDirectory = Path.Combine(newDirectoryPath, "Copy");

            Console.WriteLine("If you want to move the directory, press 1");
            int move = int.Parse(Console.ReadLine());

            if (move == 1)
            {
                if (Directory.Exists(directoryPath))
                {
                    Directory.Move(directoryPath, newDirectory);
                    Console.WriteLine("Directory moved.");
                }
                else
                {
                    Console.WriteLine("Directory does not exist.");
                }
            }

            Console.WriteLine("If you want to delete the directory, press 1");
            int delete = int.Parse(Console.ReadLine());

            if (delete == 1)
            {
                string del = @"E:\kk\MoveDirectory\Copy";
                if (Directory.Exists(del))
                {
                    Directory.Delete(del, true);
                    Console.WriteLine("Directory deleted.");
                }
                else
                {
                    Console.WriteLine("Directory does not exist.");
                }
            }
        }
    }
}