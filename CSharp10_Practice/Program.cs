using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp10_Practice
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Console.ForegroundColor= ConsoleColor.Black;
            //Console.BackgroundColor= ConsoleColor.White;
            //Console.Clear();

            //Console.WriteLine("Hello");


            //Console.Write("Enter Name: ");
            //string name = Console.ReadLine();
            //Console.WriteLine($"Hello: {name}");

            //bool canIVote = false;
            //int myAge = 18;

            //Console.WriteLine($"int MinValue: {int.MinValue}");
            //Console.WriteLine($"int MaxValue: {int.MaxValue}");

            //Console.WriteLine($"long MinValue: {long.MinValue}");
            //Console.WriteLine($"long MaxValue: {long.MaxValue}");

            //Console.WriteLine($"Decimal MinValue: {decimal.MinValue}");
            //Console.WriteLine($"Decimal MaxValue: {decimal.MaxValue}");

            //Console.WriteLine($"double MinValue: {double.MinValue}");
            //Console.WriteLine($"double MaxValue: {double.MaxValue}");

            //Console.WriteLine("double MinValue: {0} and MaxValue: {1}", double.MinValue, double.MaxValue);
            //Console.WriteLine("float MinValue: {0} and MaxValue: {1}", float.MinValue, float.MaxValue);

            ////decimal myDecimalValue = 3.141234564323456M;
            ////decimal bigNum = 3.0000000000000009876545678909876545678M;

            //float myFloatVal = 3.17878998780988F;
            //Console.WriteLine(myFloatVal);

            //Console.WriteLine(myDecimalValue+bigNum);

            //bool boolFromStr = bool.Parse("true");
            //int intFromStr = int.Parse("100");
            //double doubleFromStr = double.Parse("1.122334");
            //string strFromDouble = doubleFromStr.ToString();

            //Console.WriteLine($"Data Type: {strFromDouble.GetType()}");

            //int intFromDouble = (int)3.123421;
            //Console.WriteLine($"{intFromDouble.GetType()}");

            //Console.WriteLine("Currency : {0:c}", 23.455);
            //Console.WriteLine("pad with zeros : {0:d4}", 23);
            //Console.WriteLine("pad with zeros : {0:f3}", 23.12342);
            //Console.WriteLine("pad with zeros : {0:n4}", 12345678765432);


            string randString = "This is a Sample string";

            Console.WriteLine("Length {0}", randString.Length);
            Console.WriteLine("Contains {0}", randString.Contains("is"));
            Console.WriteLine("index {0}", randString.IndexOf("is"));
            Console.WriteLine("removeStr {0}", randString.Remove(5,2));
        }
    }
}
