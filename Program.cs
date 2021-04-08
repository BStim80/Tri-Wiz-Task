using System;
using System.Collections.Generic;

namespace Tri_Wizard_Interview_Task_Script

{//user input: circle - radius, triangle - all 3 sides, rectangle - length, width
    interface IShape//todo: 
    {
        void Input();
        float Perimeter();       
    }

  static class TotalPerimeter 
    {
      public static float TotalP(List<IShape> shapes)
        { 

            float totalPerimeter = 0;

            foreach(IShape shape in shapes)
            {
                totalPerimeter = totalPerimeter + shape.Perimeter(); // totalPerimeter += shape.Perimeter();
            }//Circle.Perimeter() + Triangle.Perimeter() + Rectangle.Perimeter()
            return totalPerimeter;
        }
    }
    
    public class Circle : IShape // P = tau * radius
    {
        public float circumference { get; set; }
        public float radius;
        public const float tau = 6.28f;
        

        public Circle(float radius) 
        {
            this.radius = radius;
            this.circumference = tau * radius;           
        }

        public void Input() 
        {
            Console.WriteLine("What is the length of the radius in your circle?");
        }

        public float Perimeter()
        {
            Console.WriteLine("Perimeter of circle is " + circumference); 
            return circumference;   
        }        
    }

    public class Triangle : IShape// P = a + b + c
    {
        public float sideA;
        public float sideB;
        public float sideC;

        public float tPerimeter { get; set; }

        
        public Triangle(float sideA, float sideB, float sideC)
        {
            this.sideA = sideA;
            this.sideB = sideB;
            this.sideC = sideC;
            this.tPerimeter = sideA + sideB + sideC;
        }

        public void Input() 
        {
            Console.WriteLine("What is the length of each side in your triangle?");
        }
        

        public float Perimeter()
        {
            Console.WriteLine("Perimeter of triangle is " + tPerimeter);
            return tPerimeter;
        }


    }

    public class Rectangle : IShape// P = 2(L + W)
    {
        public float length;
        public float width;
        public float rPerimeter { get; set; }

        public Rectangle(float length, float width)
        {
            this.length = length;
            this.width = width;
            this.rPerimeter = 2 * (length + width);
        }

        public void Input() 
        {
            Console.WriteLine("What is the length and width of your rectangle?");
        }
        

        public float Perimeter()
        {
            Console.WriteLine("Perimeter of rectangle is " + rPerimeter);
            return rPerimeter;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.Green;

            Circle circle01 = new Circle(3f);//radius

            Triangle triangle01 = new Triangle(2f, 3f, 5f);//length of sides a, b, c

            Rectangle rectangle01 = new Rectangle(10f, 5f);//length, width

            var shapes = new List<IShape>();
            shapes.Add(circle01);
            shapes.Add(triangle01);
            shapes.Add(rectangle01);
            // shapes.Add(rectangle01);

            var totalPermeter = TotalPerimeter.TotalP(shapes);

            Console.WriteLine("The total perimeter of all shapes is: " + totalPermeter);
                                
            Console.ReadKey();            
        }
    }
}