//StreamReader
using System;
using System.IO;
using System.Text;
public class Reader
{
    public static void Main(string[] args)
    {
        string path= @"C:\Users\Sumon_\OneDrive\Desktop\record.txt";

        using(FileStream obj1 = new FileStream(path,FileMode.Open,FileAccess.Read))
        {
            using(StreamReader read1 = new StreamReader(obj1))
            {
                if(read1.Peek()>0)
                {
                    Console.WriteLine("True");
                }else{
                    Console.WriteLine("False");
                }
                //op True

                //will read only first line
                // string line1= read1.ReadLine();
                // Console.WriteLine(line1);

                //will print all names
                // string line2= "";
                // while((line2=read1.ReadLine())!=null)
                // {
                //     Console.WriteLine(line2+" ");
                // }

                //want to print in characters
                //will only print characters of first line only
                // foreach (var item in read1.ReadLine())
                // {
                //     Console.WriteLine(item);
                // }


                //want to store names in arrays and print it
                //6 names are there in the file in 6 seperated line
                // string[] arr1= new string[6];
                // for(int i=0;i<arr1.Length;i++)
                // {
                //     arr1[i]= read1.ReadLine();
                // }

                // foreach (var item1 in arr1)
                // {
                //     Console.WriteLine(item1);
                // }

                //ReadToEnd
                string line3= read1.ReadToEnd();
                Console.WriteLine(line3);

                //will print character of each line
                // foreach (var item2 in read1.ReadToEnd())
                // {
                //     Console.WriteLine(item2);
                // }

                
            }
        }
        Console.ReadLine();
    }
}