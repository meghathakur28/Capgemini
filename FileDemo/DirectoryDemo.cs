using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace FileDemo
{
    public class DirectoryDemo
    {
        public void DirectoryDemoFunc(string DirectoryName)
        {
            if(Directory.Exists(DirectoryName))
            {
                Console.WriteLine("Directory already exists.");
                return;
            }
            else
            {
                Directory.CreateDirectory(DirectoryName);
                Console.WriteLine("Directory created successfully.");
            }
        }
        public void DriveInfoFunc(string driveName)
        {
            DriveInfo dInfo  = new DriveInfo(driveName);
            Console.WriteLine("Drive Name: "+ dInfo.Name);
            Console.WriteLine("Drive FileSystem: " + dInfo.DriveType);
            Console.WriteLine("Drive Size: " + dInfo.TotalSize);
            Console.WriteLine("Drive FreeSpace: " + dInfo.AvailableFreeSpace);
        }
        public void PathDemoFunc()
        {
            string s = @"D:\Spark lec";
            System.Console.WriteLine(Path.GetFileName(s));
            System.Console.WriteLine(Path.GetTempPath());
        }
    }
}
