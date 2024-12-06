using MyString_;
using System;

namespace dz_5
{
    public class Program
    {
        static void Main(string[] args)
        {
            char[] str = new char[] { 'H','E','L','L','O',',','W','O','R','L','D','!' };
            //11(0-11)
            MyString_.MyString myString = new MyString_.MyString(str);

            Console.WriteLine("------------------------------------");
            Console.WriteLine(myString.StartWith());


            Console.WriteLine("------------------------------------");
            Console.WriteLine(myString.EndWith());


            Console.WriteLine("------------------------------------");
            Console.WriteLine(myString.Substring(0,4));


            Console.WriteLine("------------------------------------");
            myString.Remove(0, 4);
            Console.WriteLine(new string(myString.Str));


            Console.WriteLine("------------------------------------");
            myString.RemoveAll();
            Console.WriteLine(new string(myString.Str));


            Console.WriteLine("------------------------------------");
            var str1 = new char[] { 'H', 'E', 'Y', ',' };
            var str2 = new char[] { ' ', 'P', 'E', 'A', 'C', 'E', '!' };
            myString.Concat(str1, str2);
            Console.WriteLine(new string(myString.Str));


            Console.WriteLine("------------------------------------");
            myString.Replace(new char[] { 'G', 'O', 'O', 'D', 'B', 'Y', 'E' });
            Console.WriteLine(new string(myString.Str));


            Console.WriteLine("------------------------------------");
            myString.Replace2(new char[] { 'O', 'O' }, new char[] { 'A','B' });
            Console.WriteLine(new string(myString.Str));


            Console.WriteLine("------------------------------------");
            var trim = new MyString(new char[]
            { 'H',' ','I',' ','!'});
            trim.Trim(' ');
            Console.WriteLine(new string(trim.Str));


            Console.WriteLine("------------------------------------");
            var str1_ = new char[] { 'H', 'E', 'L', 'L', 'O' };
            var str2_ = new char[] { 'H', 'E', 'L', 'L', 'O' };
            var str3_ = new char[] { 'W', 'O', 'R', 'L', 'D' };
            Console.WriteLine(myString.CompareTo(str1_, str2_));
            Console.WriteLine();
            Console.WriteLine(myString.CompareTo(str1_, str3_));


            Console.WriteLine("------------------------------------");
            var search = new char[] { 'A', 'B' };
            var indexOf = myString.IndexOf(search);
            Console.WriteLine($"IndexOf ('{new string(search)}') = " + indexOf);
            Console.WriteLine("------------------------------------");


            Console.ReadKey();
        }
    }
}
