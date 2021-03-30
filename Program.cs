using System;
using System.Collections.Generic;

namespace Tri_Wizard_Interview_Task_Script //working out git bash kinks 2
{
    interface IShapes//todo: add a list, polymorphism, interface and refactor code
    {
        float circumference { get; set; }
        void Perimeter();       
    }
    public class TotalPerimeter 
    {
        public float circumference;

        float TotalP(IShapes ishap, IShapes ishape)
        {
		return circumference;
        }
    }

    public class Circle : IShapes // P = tau * radius
    {
        public float circumference { get; set; }//i removed public keyword from all three of these variables
        public float radius;//radius and tau are declaring the circle class
        public const float tau = 6.28f;
        

        public Circle(float radius) 
        {
            this.radius = radius;
            this.circumference = tau * radius;           
        }

        public void Perimeter()//testing git bash
        {
            Console.WriteLine("Perimeter of circle is " + circumference);    
        }        
    }

    public class Triangle : IShapes// P = a + b + c
    {
        public float sideA;
        public float sideB;
        public float sideC;

        public float circumference { get; set; }

        
        public Triangle(float sideA, float sideB, float sideC)
        {
            this.sideA = sideA;
            this.sideB = sideB;
            this.sideC = sideC;
            this.circumference = sideA + sideB + sideC;
        }

        public void Input() 
        {
            Console.WriteLine("What is the length of each side in your triangle?");
        }
        

        public void Perimeter()
        {
            Console.WriteLine("Perimeter of triangle is " + circumference);
        }


    }

    public class Rectangle : IShapes// P = 2(L + W)
    {
        public float length;
        public float width;
        public float circumference { get; set; }

        public Rectangle(float length, float width)
        {
            this.length = length;
            this.width = width;
            this.circumference = 2 * (length + width);
        }

        public void Input() 
        {
            Console.WriteLine("What is the length and width of your rectangle?");
        }
        

        public void Perimeter()
        {
            Console.WriteLine("Perimeter of rectangle is " + circumference);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Circle circle01 = new Circle(3f);//radius

            circle01.Perimeter();//this is how you are calling these methods

            Triangle triangle01 = new Triangle(2f, 3f, 5f);//length of sides a, b, c

            triangle01.Perimeter();

            Rectangle rectangle01 = new Rectangle(10f, 5f);//length, width

            rectangle01.Perimeter();

            Console.WriteLine("The total perimeter of all shapes is: " + (circle01.circumference + triangle01.circumference + rectangle01.circumference));
            //i removed (circle01.perimeter + circle02.perimeter)
                                
            Console.ReadKey();            
        }
    }
}
