//DirectoryInfo


using System;
using System.IO;
public class Directory
{
    public static void Main(string[] args)
    {
        // string path1= @"C:\Users\Sumon_\OneDrive\Desktop\Dir1";
        // string path2= @"C:\Users\Sumon_\OneDrive\Desktop\Dir2";
        // string path3= @"C:\Users\Sumon_\OneDrive\Desktop\Del"; //empty directory
        // string path4= @"C:\Users\Sumon_\OneDrive\Desktop\Del1"; //contains text files

        // DirectoryInfo dir = new DirectoryInfo(path1);
        //Create
        // dir.Create();
        // Console.WriteLine("Directory Created");

        //CreateSubDirectory
        // dir.CreateSubdirectory("Sub Dir1");
        // Console.WriteLine("Sub-Directory Created");

        //MoveTo
        // dir.MoveTo(path2);
        // Console.WriteLine("Moved successfully");

        //Delete
        // DirectoryInfo dirs = new DirectoryInfo(path3);
        // dirs.Delete();
        // Console.WriteLine("Deleted successfully");

        // DirectoryInfo dirs1 = new DirectoryInfo(path4);
        // dirs1.Delete(true);
        // Console.WriteLine("Deleted successfully");

        //GetDirectories
        // string path4= @"C:\Users\Sumon_\OneDrive\Desktop\newDir";
        // DirectoryInfo obj = new DirectoryInfo(path4);
        // DirectoryInfo[] obj1= obj.GetDirectories();

        // foreach (var item in obj1)
        // {
        //     Console.WriteLine(item);
        // }
        // Console.WriteLine("Got directories successfully");

        // foreach (var item in obj1)
        // {
        //     Console.WriteLine(item.GetFiles().Length);
        // }
        // Console.WriteLine("Got Files Length successfully");


        string path5= @"C:\Users\Sumon_\OneDrive\Desktop\newDir\new2";
        DirectoryInfo obj2= new DirectoryInfo(path5);
        Console.WriteLine(obj2.Name);
        Console.WriteLine(obj2.FullName);
        Console.WriteLine(obj2.Attributes);
        Console.WriteLine(obj2.Parent);
        Console.WriteLine(obj2.CreationTime);
        Console.WriteLine(obj2.Root);
        Console.WriteLine(obj2.LastAccessTime);
        Console.WriteLine(obj2.LastWriteTime);
    }
}
