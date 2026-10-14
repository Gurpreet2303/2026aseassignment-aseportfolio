using System;

namespace Lab05_Interfaces
{
    public interface ILoggable
    {
        void LogDetails();
    }

    public abstract class Shape : ILoggable
    {
        public string Name { get; set; }

        protected Shape(string name)
        {
            Name = name;
        }

        public abstract double CalculateArea();

        public void LogDetails()
        {
            Console.WriteLine($"Shape: {Name}, Area: {CalculateArea():F2}");
        }
    }

    public class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius) : base("Circle")
        {
            Radius = radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lab 5: Interfaces and Abstract Classes");
            
            Shape myCircle = new Circle(5.0);
            myCircle.LogDetails();
        }
    }
}