namespace Directories
{
    public class Program
    {
        private static void Main()
        {
            DirectoriesClass obj = new DirectoriesClass();
            obj.dire();

            File_IO file_IO = new File_IO();
            file_IO.FileAttributes();

            FileInfoClass fileInfoClass = new FileInfoClass();
            fileInfoClass.FileInfoAttributes();

            PathClass pathClass = new PathClass();
            pathClass.path();

            DriveInfoClass driveInfoClass = new DriveInfoClass();
            driveInfoClass.driveinfo();

            //Exception Handling
            Arithmatic divied = new Arithmatic();
            divied.exep();

            Filecheck filecheck = new Filecheck();
            filecheck.method();


        }
    }
}