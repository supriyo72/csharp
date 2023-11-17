//File

// using System;
// using System.IO;
// public class Program
// {
//     public static void Main(string[] args)
//     {
//         string path= @"C:\Users\Sumon_\OneDrive\Desktop\Supu.txt";
//         if(File.Exists(path))
//         {
//             Console.WriteLine("File Found");
//         }else{
//             Console.WriteLine("File Not Found");
//         }
//     }
// }



// using System;
// using System.IO;
// public class Program
// {
//     public static void Main(string[] args)
//     {
//         string path= @"C:\Users\Sumon_\OneDrive\Desktop\Supu.txt";
//         if(File.Exists(path))
//         {
//             Console.WriteLine("File Found");
//             string data= File.ReadAllText(path);
//             Console.WriteLine(data);
//         }else{
//             Console.WriteLine("File Not Found");
//         }
//     }
// }




//Copy-paste
// using System;
// using System.IO;
// public class Program
// {
//     public static void Main(string[] args)
//     {
//         string path1= @"C:\Users\Sumon_\OneDrive\Desktop\dummy.txt";
//         string path2= @"C:\Users\Sumon_\OneDrive\Desktop\dummy1.txt";

//         File.Copy(path1,path2);
//         Console.ReadLine();
//     }
// }



//copy-paste inside folder
// using System;
// using System.IO;
// public class Program
// {
//     public static void Main(string[] args)
//     {
//         string path1= @"C:\Users\Sumon_\OneDrive\Desktop\dummy.txt";
//         string path2= @"C:\Users\Sumon_\OneDrive\Desktop\supriyo\dummy1.txt";

//         File.Copy(path1,path2);
//         Console.ReadLine();
//     }
// }



//overwrite dummy folder
using System;
using System.IO;
public class Program
{
    public static void Main(string[] args)
    {
        string path1= @"C:\Users\Sumon_\OneDrive\Desktop\dummy.txt";
        string path2= @"C:\Users\Sumon_\OneDrive\Desktop\dummy1.txt";

        File.Copy(path1,path2,true);
        Console.ReadLine();
    }
}
