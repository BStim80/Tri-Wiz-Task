using System;
using System.Collections.Generic;

namespace Tri_Wizard_Interview_Task_Script
{//user input: circle - radius, triangle - all 3 sides, rectangle - length, width
    interface IShapes//todo: 
    {
        void Input();
        void Perimeter();       
    }
//make a list to hold the variables from my constructors(circle, triangle, rectangle). 
//make foreach loop to run through the list until the end
//Then, do console.writeline or return totalPerimeter: the value of all of the elements in the list added up = total perimeter of all shapes

//try making a foreach loop that holds each of the constructors. 
//then, put an if statement inside of the loop that will check each conctructor for the circumference and add them all up at the end 

    class TotalPerimeter 
    {
        float TotalP()
        { 
            List<object> IShapes = new List<object>();

            Circle circle01 = new Circle(3f);//radius

            Triangle triangle01 = new Triangle(2f, 3f, 5f);//length of sides a, b, c
           
            Rectangle rectangle01 = new Rectangle(10f, 5f);//length, width
            
            IShapes.Add(circle01);
            IShapes.Add(triangle01);
            IShapes.Add(rectangle01);

            float totalPerimeter = 0;

            foreach(var shape in IShapes)
            {
                totalPerimeter = totalPerimeter + IShapes.Perimeter(); // totalPerimeter += shape.Perimeter();
            }
            return totalPerimeter;

            
        }
    }

    public class Circle : IShapes // P = tau * radius
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

        public void Perimeter()
        {
            Console.WriteLine("Perimeter of circle is " + circumference);    
        }        
    }

    public class Triangle : IShapes// P = a + b + c
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
        

        public void Perimeter()
        {
            Console.WriteLine("Perimeter of triangle is " + tPerimeter);
        }


    }

    public class Rectangle : IShapes// P = 2(L + W)
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
        

        public void Perimeter()
        {
            Console.WriteLine("Perimeter of rectangle is " + rPerimeter);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.Green;

            Circle circle01 = new Circle(3f);//radius

            circle01.Perimeter();//this is how you are calling these methods

            Triangle triangle01 = new Triangle(2f, 3f, 5f);//length of sides a, b, c

            triangle01.Perimeter();

            Rectangle rectangle01 = new Rectangle(10f, 5f);//length, width

            rectangle01.Perimeter();

            Console.WriteLine("The total perimeter of all shapes is: " + (circle01.circumference + triangle01.tPerimeter + rectangle01.rPerimeter));
                                
            Console.ReadKey();            
        }
    }
}
