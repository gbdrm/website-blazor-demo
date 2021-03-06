﻿using System;
using System.Linq;

namespace MerryYellow.RoslynWeb
{
    public class Program
    {
        const string Source = @"
using System;
namespace ConsoleApplication1
{

        class Program //: BaseClass
        {
            static void Main(string[] args)
            {
			    var self = new Program();
                Console.WriteLine(""Hello World!"");
            }
        }

        //class BaseClass{}

    }
";

    public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            try
            {


            var pl = Compiler.GetPatternList();
            var cl = Compiler.GetClassList(Source);
            var ns = Compiler.ApplyPattern(Source, pl.ElementAt(0), cl.ElementAt(0),
                "Instance", "_instance", true, true);

            }
            catch(Exception e)
            {
                Console.WriteLine("EXCEPTION");
                Console.WriteLine(e.Message);
                Console.WriteLine(e.InnerException?.Message);
                Console.WriteLine(e.StackTrace);
                Console.WriteLine(e.ToString());
                Console.WriteLine(e.HResult);
                Console.WriteLine(e.Data.Count);

            }

        }
    }
}
