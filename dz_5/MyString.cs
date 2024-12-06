using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyString_
{
    public class MyString
    {
        public char[] Str { get; set; }
        public int Length { get; }
        public MyString(char[] str)
        {
            //this.str = str;
            Str = str ?? throw new ArgumentNullException(nameof(str));
        }

        public char StartWith() => Str[0];
        public char EndWith() => Str[Str.Length - 1];
        public char[] Substring(int startIndex, int endIndex)
        {
            if (startIndex < 0 || endIndex < 0 || startIndex >= Str.Length || 
                endIndex >= Str.Length || startIndex > endIndex)
            {
                throw new ArgumentOutOfRangeException("Invalid indices!");
            }

            int length = endIndex - startIndex + 1;
            char[] result = new char[length];
            Array.Copy(Str, startIndex, result, 0, length);
            return result;
        }
        public void Remove(int startIndex, int endIndex)
        {
            if (startIndex < 0 || endIndex < 0 || startIndex >= Str.Length || 
                endIndex >= Str.Length || startIndex > endIndex)
            {
                throw new ArgumentOutOfRangeException("Invalid indices!");
            }

            int lengthToRemove = endIndex - startIndex + 1;
            char[] newStr = new char[Str.Length - lengthToRemove];
            Array.Copy(Str, 0, newStr, 0, startIndex);
            Array.Copy(Str, endIndex + 1, newStr, startIndex, Str.Length - endIndex - 1);
            Str = newStr;
        }
        public void RemoveAll()
        {
            Str = Array.Empty<char>();
        }
        public int IndexOf(char[] search)
        {
            if (search == null || search.Length == 0)
                throw new ArgumentNullException(nameof(search));

            string str = new string(Str);
            string search_Str = new string(search);
            return str.IndexOf(search_Str, StringComparison.Ordinal);
        }
        public void Concat(char[] str1, char[] str2)
        {
            if (str1 == null || str2 == null)
                throw new ArgumentNullException("Arguments can't be null!");

            Str = new char[str1.Length + str2.Length];
            Array.Copy(str1, 0, Str, 0, str1.Length);
            Array.Copy(str2, 0, Str, str1.Length, str2.Length);
        }
        public void Replace(char[] newValue)
        {
            if (newValue == null)
                throw new ArgumentNullException(nameof(newValue));

            Str = new char[newValue.Length];
            Array.Copy(newValue, Str, newValue.Length);
        }
        public void Replace2(char[] oldValue, char[] newValue)
        {
            if (oldValue == null || newValue == null)
                throw new ArgumentNullException("Arguments can't be null!");

            string str = new string(Str);
            string oldStr = new string(oldValue);
            string newStr = new string(newValue);
            Str = (str.Replace(oldStr, newStr)).ToCharArray();
        }
        public void Trim(char ch)
        {
            string trim_Str = new string(Str).Replace(ch.ToString(), string.Empty);
            Str = trim_Str.ToCharArray();
        }
        public bool CompareTo(char[] str1, char[] str2)
        {
            if (str1 == null || str2 == null)
                throw new ArgumentNullException("Arguments can't be null!");

            return new string(str1) == new string(str2);
        }
    }

}
