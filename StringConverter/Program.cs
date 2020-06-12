using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace StringConverter
{
    internal class Program
    {
        //Converting all strings in a List to Uppercase with Linq
        //Exercise from abundantcode.com
        static void Main(string[] args)
        {
            //First, create the List that names will get added to
            List<string> Names = new List<string>();

            //Use .Add() from Linq to put names in List efficiently
            Names.Add("Abundantcode");

            Names.Add("Programming");

            Names.Add("Websites");

            Names.Add("Coding");

            Names.Add("Technologies");

            Names.Add("USA");

            Names.Add("C#");

            Names.Add(".NET Core");

            /*Now, feed the names through var result, convert to uppercase
             * by using Linq method ToUpper() */
            var result = Names.Select(m => m.ToUpper());

            /*Finally, Console will print each name in ALL CAPS, then wait
             * for a keystroke before printing the next item in the list */
            foreach(var item in result)
            {
                Console.WriteLine(item);
                Console.ReadLine();
            }
        }
    }
}
