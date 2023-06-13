using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Directories
{
    public class DriveInfoClass
    {
        public void driveinfo()
        {
            DriveInfo info = new DriveInfo("D");

            // Print sizes.
            double availableFreeSpaceGB = (double)info.AvailableFreeSpace / (1024 * 1024 * 1024);
            double totalFreeSpaceGB = (double)info.TotalFreeSpace / (1024 * 1024 * 1024);
            double totalSizeGB = (double)info.TotalSize / (1024 * 1024 * 1024);

            Console.WriteLine("Available Free Space: " + availableFreeSpaceGB.ToString("0.00") + " GB");
            Console.WriteLine("Total Free Space: " + totalFreeSpaceGB.ToString("0.00") + " GB");
            Console.WriteLine("Total Size: " + totalSizeGB.ToString("0.00") + " GB");

            // Format and type.
            Console.WriteLine("DriveFormat: " + info.DriveFormat);
            Console.WriteLine("DriveType: " + info.DriveType);

            // Name and directories.
            Console.WriteLine("Name: " + info.Name);
            Console.WriteLine("RootDirectory: " + info.RootDirectory);
            Console.WriteLine("VolumeLabel: " + info.VolumeLabel);
            Console.WriteLine();

            /* var drives = DriveInfo.GetDrives();
             foreach (DriveInfo name in drives)
             {
                 Console.WriteLine(name.VolumeLabel);
             }*/
        }
    }
}
