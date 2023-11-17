//StreamWriter



// using System;
// using System.IO;
// using System.Text;
// public class Files
// {
//     public static void Main(string[] args)
//     {
//         string path= @"C:\Users\Sumon_\OneDrive\Desktop\files.txt";

//         using(FileStream obj= File.Create(path))
//         {
//             Console.WriteLine("File Created");
//         }
//     }
// }




using System;
using System.IO;
using System.Text;
public class Files
{
    public static void Main(string[] args)
    {
        string path= @"C:\Users\Sumon_\OneDrive\Desktop\Data.txt";
        using(FileStream obj1= new FileStream(path,FileMode.Create,FileAccess.Write))
        {
            using(StreamWriter obj2 = new StreamWriter(obj1,Encoding.UTF8))
            {
                obj2.Write("Ram Laxman SitaMaiya");
            }
        }
        using(FileStream obj2= new FileStream(path,FileMode.Append,FileAccess.Write))
        {
            using(StreamWriter obj3 = new StreamWriter(obj2,Encoding.UTF8))
            {
                obj3.WriteLine(" Ki jai ho");
                obj3.WriteLine("Data-1");
                obj3.WriteLine("Data-2");
            }
        }
        using(FileStream obj3= new FileStream(path,FileMode.Append,FileAccess.Write))
        {
            using(StreamWriter obj4 = new StreamWriter(obj3,Encoding.UTF8))
            {
                int[] arr1= {25,55,68,10,97};
                char[] arr2= {'A','B','C','D'};

                foreach (var item in arr1)
                {
                    obj4.Write(item+" ");
                }
                foreach (var item1 in arr2)
                {
                    obj4.Write(item1+" ");
                }
            }
        }
    }
}
