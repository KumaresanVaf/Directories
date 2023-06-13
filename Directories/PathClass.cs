namespace Directories
{
    public class PathClass
    {
        public void path()
        {
            var path = @"E:\kk\System_IO\FileInfoClass\sample.docx";

            Console.WriteLine("Check an extension: "+Path.HasExtension(path));

            Console.WriteLine("Root Of Drive: " + Path.GetPathRoot(path));

            Console.WriteLine("Full Path: " + Path.GetFullPath(path));

            Console.WriteLine("Directory Name: " + Path.GetDirectoryName(path));

            Console.WriteLine("Random File Name: " + Path.GetRandomFileName());

            Console.WriteLine("File Extension: " + Path.GetExtension(path));

            Console.WriteLine("File Name: " + Path.GetFileName(path));

            //Path Combine and Create a path
            string combinedPath = Path.Combine(@"E:\kk\System_IO\FileInfoClass\", "subfolder");
            Directory.CreateDirectory(combinedPath);
            Console.WriteLine("Combined Path: " + combinedPath);

            Console.WriteLine("Temporary File Path: " + Path.GetTempFileName());

            Console.WriteLine("Temporary Path: " + Path.GetTempPath());

            Console.WriteLine("File Name without Extension: " + Path.GetFileNameWithoutExtension(path));

            Console.WriteLine("Is Path Rooted " + Path.IsPathRooted(path));
        }
    }
}