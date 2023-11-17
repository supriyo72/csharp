//StreamWriter


// using System;
// using System.IO;
// using System.Text;
// public class Stream
// {
//     public static void Main(string[] args)
//     {
//         string path= @"C:\Users\Sumon_\OneDrive\Desktop\Data1.txt";
//         using(FileStream obj1= new FileStream(path,FileMode.Create,FileAccess.Write))
//         {
//             Console.WriteLine("File Created");
//         }

//         using(FileStream obj2= new FileStream(path,FileMode.Open,FileAccess.Write))
//         {
//             using(StreamWriter obj3= new StreamWriter(obj2,Encoding.UTF8))
//             {
//                 obj3.WriteLine("Hello my name is Supriyo");
//             }
//         }
        
//     }
// }






using System;
using System.IO;
using System.Text;
public class Stream
{
    public static void Main(string[] args)
    {
        string path= @"C:\Users\Sumon_\OneDrive\Desktop\Data2.txt";
        
        using(FileStream obj1= new FileStream(path,FileMode.OpenOrCreate,FileAccess.Write))
        {
            using(StreamWriter obj2= new StreamWriter(obj1,Encoding.UTF8))
            {
                obj2.Write("Hare Krishna hare rama");
            }
        }

        using(FileStream obj3= new FileStream(path,FileMode.Append,FileAccess.Write))
        {
            using(StreamWriter obj4= new StreamWriter(obj3,Encoding.UTF8))
            {
                obj4.WriteLine(" Rama rama hare hare");
                obj4.WriteLine("Data1 file");
                obj4.WriteLine("Data2 file");
                obj4.WriteLine("Data3 file");
            }
        }
        
    }
}
