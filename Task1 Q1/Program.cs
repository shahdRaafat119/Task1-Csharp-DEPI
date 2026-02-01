using System;

namespace Task1_Q1
{
    // ===========================
    // Classes & Structs Definitions
    // ===========================

    // Q1 Definitions
    struct ValuePoint
    {
        public int X;
    }
    class RefPoint
    {
        public int X;
    }

    // Q2 Definitions
    class Student
    {
        public string Name;
    }

    // Q4 Definitions
    class Car
    {
        public string Model;
    }

    // Q5 Definitions
    class Book
    {
        public void Read()
        {
            Console.WriteLine("Reading book...");
        }
    }

    // ===========================
    // Main Program
    // ===========================
    internal class Program
    {
        static void Main(string[] args)
        {
            // Q1: 
            Console.WriteLine("--- Q1 Output ---");
            ValuePoint vp = new ValuePoint { X = 10 };
            RefPoint rp = new RefPoint { X = 10 };
            Modify(vp, rp);
            Console.WriteLine($"Struct Value: {vp.X}");
            Console.WriteLine($"Class Value: {rp.X}");
            Console.WriteLine();


            // Q2: 
            Console.WriteLine("--- Q2 Output ---");
            Student s1 = new Student { Name = "Ali" };
            Student s2 = new Student { Name = "Ali" };
            Student s3 = s1;
            Console.WriteLine($"s1 == s2 : {s1 == s2}");
            Console.WriteLine($"s1 == s3 : {s1 == s3}");
            Console.WriteLine();


            // Q3: 
            Console.WriteLine("--- Q3 Output ---");
            int x = 5;
            int y = 10;
            Swap(ref x, ref y);
            Console.WriteLine($"x: {x}, y: {y}");
            Console.WriteLine();


            // Q4: 
            Console.WriteLine("--- Q4 Output ---");
            Car car1 = new Car { Model = "Toyota" };
            Car car2 = car1;
            car2.Model = "Tesla";
            Console.WriteLine($"Car1 Model: {car1.Model}");
            Console.WriteLine();


            // Q5: 
            Console.WriteLine("--- Q5 Output ---");
            Book myBook = new Book();
            myBook.Read();
            Console.WriteLine();
        }

        // Method for Q1
        static void Modify(ValuePoint v, RefPoint r)
        {
            v.X = 100;
            r.X = 100;
        }

        // Method for Q3
        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}


