using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithFiles1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            doApp(); 
        }
        static void doApp()
        {
            string greeting = "Hello, ";
         
            Console.WriteLine("Original string=" + greeting);

            Console.WriteLine("Clone of a string =" + greeting.Clone());
            Console.WriteLine("Compare two strings =" + greeting.CompareTo("Mary had a big lamb"));
            Console.WriteLine("Characters in a string =" + greeting.Contains("r"));
            Console.WriteLine("String ending with =" + greeting.EndsWith("lamb."));
            Console.WriteLine("Lowercase =" + greeting.ToLower());
            Console.WriteLine("Uppercase =" + greeting.ToUpper());
            Console.WriteLine("Insert string within a string =" + greeting.Insert(6, " and Jim "));
            Console.WriteLine("Splitting string into words:");
            string[] parts = greeting.Split(' ');
            foreach (string p in parts)
            {
                Console.WriteLine(p);
            }
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("Hello, ");
            stringBuilder.Append("Jhan");
            string result = stringBuilder.ToString();

            Console.WriteLine("\nUsing StringBuilder:");
            Console.WriteLine(result);



            StringBuilder sb = new StringBuilder("");
            for (int i = 0; i < 10; i++)
            {
                sb.Append(i.ToString() + " ");
            }
            Console.WriteLine(sb.ToString());

            Console.ReadLine();


            }
        }
}
