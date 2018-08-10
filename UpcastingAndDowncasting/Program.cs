using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpcastingAndDowncasting
{



    public class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public void Draw()
        {

        }
    }



    public class Text : Shape
    {
        public int FontSize { get; set; }
        public string FontName { get; set; }
    }



    class Program
    {
        static void Main(string[] args)
        {

            // Upcasting

            Text text = new Text();
            Shape shape = text; // Can implicitely cast the shape to it's base class
                                // Both are references to the same point in memory

            text.Width = 200;
            shape.Width = 100;
            Console.WriteLine("The width of the text is: {0}", text.Width);  // 100


            StreamReader reader = new StreamReader(new MemoryStream());

            ArrayList list = new ArrayList();
            list.Add(1);
            list.Add("Mosh");
            list.Add(new Text());
            // All of these items will be converted to their base class

            var anotherList = new List<Shape>();



            // Downcasting

            Shape shapee = new Text(); // Will be casted to type Shape at runtime
            Text textt = (Text)shapee;
            //text.FontName    - Will now have access to the properties of type Text

        }
    }



}
