using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
   static class ExtentionMethods
    { 
        public static bool isOdd(this int num)
        {


            if (num % 2 != 0 && num>0)
            {
                return true;
            }
            else 
               return false;
        }
        public static bool isEven(this int num)
        {


            if (num % 2 == 0 && num > 0)
            {
                return true;
            }
            else
                return false;
        }
        public static bool IsContainsDigit(this string str)
        {
            bool check = false; ;
            foreach (var item in str)
            {
                if (char.IsDigit(item) == true)
                {
                    check = true;
                    return check;
                }
            }
            if (check)
                return true;
            else
                return false;
            }


        
        
        public static string ToCapitalize(this string str)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(char.ToUpper(str[0]));
            sb.Append((str.Substring(1).ToLower()));
            return sb.ToString();

        }
        public static void GetValueIndexes(this string str,char ch)
        {
            int[] arr = new int[0];
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i]==ch)
                {
                    Array.Resize<int>(ref arr, arr.Length+1);
                    arr[arr.Length - 1] = i;
                }

              
            }

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        

        }
    }
}

