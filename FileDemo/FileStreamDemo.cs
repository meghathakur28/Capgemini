using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace FileDemo
{
    public class FileStreamDemo
    {
        FileStream fs = null;
        public void CreateFile(string filename)
        {
            StreamWriter sw = null;
            try
            {
                fs = new FileStream(filename, FileMode.Create, FileAccess.Write);
                sw = new StreamWriter(fs);
                sw.WriteLine("Hello File Handling using FileStream");
                sw.WriteLine("hii my name is Megha Thakur");
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (FileLoadException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                sw.Close();
                fs.Close();
            }
        }
        public void ReadFile(string filename)
        {
            fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            System.Console.WriteLine(sr.ReadToEnd());
            sr.Close();
            fs.Close();
        }
    }
}
