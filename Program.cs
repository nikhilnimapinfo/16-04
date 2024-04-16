using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upcasting_Downcasting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var text = new Text();
            Shape shape = text;


            text.Width = 100;
            shape.Width = 200;

             Console.WriteLine(text.Width);

            //   StreamReader streamreader = new StreamReader(new MemoryStream());

            Shape shape1 = new Text();
            Text text1 = (Text )shape1;
        }
    }
}
