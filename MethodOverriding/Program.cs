using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverriding
{

    public abstract class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public Position Position { get; set; }
        //public ShapeType Type { get; set; }

        //public virtual void Draw()  // VIRTUAL allows you to 'override' this later in derived classes
        //{
        //    Console.WriteLine("Draw a shape");
        //}

        // But drawing a shape doesnt make any sense. Declaring a property/method as "Abstract" means that it is missing some kind of implementation and NEEDS an override
        public abstract void Draw();  // VIRTUAL allows you to 'override' this later in derived classes
        //{
             //CAN NOT HAVE A BODY IF ABSTRACT
        //}
        // The containing class needs to be declared as ABSTRACT too
        // Then means you can not do... var newShape = new Shape();   You can NOT create new classes that are marked as abstract
    }



    public class Position
    {
        public int FakeProp { get; set; }
    }



    //public enum ShapeType
    //{
    //    Circle,
    //    Rectangle,
    //    Triangle
    //}
    // INSTEAD OF HAVING AN ENUM, JUST MAKE THEM AS CLASSES



    public class Circle : Shape
    {
        public override void Draw()
        {
            //base.Draw(); // By default, VS includes this call to the parent's Draw() method
            Console.WriteLine("Draw a circle");
        }
    }



    public class Rectangle : Shape
    {
        public override void Draw()
        {
            //base.Draw();
            Console.WriteLine("Draw a rectangle");

        }

    }



    //public class Canvas
    //{
    //    public void DrawShapes(List<Shape> shapes)
    //    {
    //        foreach (var shape in shapes)
    //        {
    //            switch (shape.Type)
    //            {
    //                case ShapeType.Circle:
    //                    Console.WriteLine("Draw a circle");
    //                    break;

    //                case ShapeType.Rectangle:
    //                    Console.WriteLine("Draw a rectangle");
    //                    break;

    //                case ShapeType.Triangle:
    //                    Console.WriteLine("Draw a triangle");
    //                    break;
    //            }
    //        }
    //    }
    //}
    // INSTEAD IT GETS REFACTORED TO....
    public class Canvas
    {
        public void DrawShapes(List<Shape> shapes)
        {
            foreach (var shape in shapes)
            {
                shape.Draw();
            }
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            var shapes = new List<Shape>();
            shapes.Add(new Circle());
            shapes.Add(new Rectangle());

            var canvas = new Canvas();
            canvas.DrawShapes(shapes);
        }
    }
}
