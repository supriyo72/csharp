//Filestream


// using System;
// using System.IO;
// public class filestream
// {
//     public static void Main(string[] args)
//     {
//         string path= @"C:\Users\Sumon_\OneDrive\Desktop\myFile.txt";

//         FileStream obj = new FileStream(path,FileMode.Create);
//         Console.WriteLine("File-Created");

//         obj.Close();
//     }
// }




// using System;
// using System.IO;
// public class filestream
// {
//     public static void Main(string[] args)
//     {
//         string path= @"C:\Users\Sumon_\OneDrive\Desktop\myFile.txt";

//         using(FileStream obj = new FileStream(path,FileMode.Create))
//         {
//             Console.WriteLine("File-Created");
//         }
        
//     }
// }




// using System;
// using System.IO;
// public class filestream
// {
//     public static void Main(string[] args)
//     {
//         string path= @"C:\Users\Sumon_\OneDrive\Desktop\myFile.txt";

//         using(FileStream obj = new FileStream(path,FileMode.Create,FileAccess.Write))
//         {
//             obj.WriteByte(65);
//             Console.WriteLine("File-Created");
//         }
        
//     }
// }




//myFile is created
// using System;
// using System.IO;
// public class filestream
// {
//     public static void Main(string[] args)
//     {
//         string path= @"C:\Users\Sumon_\OneDrive\Desktop\myFile.txt";

//         using(FileStream obj = new FileStream(path,FileMode.Append,FileAccess.Write))
//         {
//             obj.WriteByte(65);
//             obj.WriteByte(69);
//             obj.WriteByte(74);
//             Console.WriteLine("Append done");
//         }
        
//     }
// }





// using System;
// using System.IO;
// public class filestream
// {
//     public static void Main(string[] args)
//     {
//         string path= @"C:\Users\Sumon_\OneDrive\Desktop\myFile.txt";

//         using(FileStream obj = new FileStream(path,FileMode.CreateNew,FileAccess.Write))
//         {
//             obj.WriteByte(65);
            
//             Console.WriteLine("Creating new file");
//         }
        
//     }
// }
//Unhandled exception. System.IO.IOException: The file 'C:\Users\Sumon_\OneDrive\Desktop\myFile.txt' already exists.




// using System;
// using System.IO;
// public class filestream
// {
//     public static void Main(string[] args)
//     {
//         string path= @"C:\Users\Sumon_\OneDrive\Desktop\myNewFile.txt";

//         using(FileStream obj = new FileStream(path,FileMode.CreateNew,FileAccess.Write))
//         {
//             obj.WriteByte(65); //A
            
//             Console.WriteLine("Creating new file");
//         }
        
//     }
// }
//myNewFile will be created with 'A' written on it




// using System;
// using System.IO;
// public class filestream
// {
//     public static void Main(string[] args)
//     {
//         string path= @"C:\Users\Sumon_\OneDrive\Desktop\myNewFile.txt";

//         using(FileStream obj = new FileStream(path,FileMode.OpenOrCreate,FileAccess.Write))
//         {
//             obj.WriteByte(84);  //T
            
//             Console.WriteLine("Writing in a file");
//         }
        
//     }
// }
//will write 'T' in the existing file myNewFile




// using System;
// using System.IO;
// public class filestream
// {
//     public static void Main(string[] args)
//     {
//         string path= @"C:\Users\Sumon_\OneDrive\Desktop\fileNew.txt";

//         using(FileStream obj = new FileStream(path,FileMode.OpenOrCreate,FileAccess.Write))
//         {
//             obj.WriteByte(80);
            
//             Console.WriteLine("Writing in a file");
//         }
        
//     }
// }
//will create fileNew and will write P on it




//Truncate: will delete the data inside the file
// using System;
// using System.IO;
// public class filestream
// {
//     public static void Main(string[] args)
//     {
//         string path= @"C:\Users\Sumon_\OneDrive\Desktop\DelFile.txt";

//         using(FileStream obj = new FileStream(path,FileMode.Truncate,FileAccess.Write))
//         {
//             Console.WriteLine("Data deleted");
//         }
        
//     }
// }




// using System;
// using System.IO;
// using System.Text;
// public class filestream
// {
//     public static void Main(string[] args)
//     {
//         string path= @"C:\Users\Sumon_\OneDrive\Desktop\NewF.txt";

//         using(FileStream obj = new FileStream(path,FileMode.Create,FileAccess.Write))
//         {
//             string data= "Hello Everyone!...";
//             byte[] write_data= Encoding.UTF8.GetBytes(data);
//             obj.Write(write_data,0,data.Length);

//             Console.WriteLine("File written successfully");

//         }
        
//     }
// }




// using System;
// using System.IO;
// using System.Text;
// public class filestream
// {
//     public static void Main(string[] args)
//     {
//         string path= @"C:\Users\Sumon_\OneDrive\Desktop\NewF.txt";

//         using(FileStream obj = new FileStream(path,FileMode.Append,FileAccess.Write))
//         {
//             string data= "My name is Supriyo ghosh";
//             byte[] write_data= Encoding.UTF8.GetBytes(data);
//             obj.Write(write_data,0,data.Length);

//             Console.WriteLine("File written successfully");

//         }
        
//     }
// }
