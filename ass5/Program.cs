using ass5.question;
using ass5.question1;

namespace ass5
{
    internal class Program
    {
      
        static Point3D ReadPointFromUser(string message)
        {
            int x, y, z;
            while (true)
            {
                Console.WriteLine(message);
                Console.Write("Enter X coordinate: ");
                if (int.TryParse(Console.ReadLine(), out x))
                    break;
                else
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
            }

            while (true)
            {
                Console.Write("Enter Y coordinate: ");
                if (int.TryParse(Console.ReadLine(), out y))
                    break;
                else
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
            }

            while (true)
            {
                Console.Write("Enter Z coordinate: ");
                if (int.TryParse(Console.ReadLine(), out z))
                    break;
                else
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
            }

            return new Point3D(x, y, z);
        }
        static void Main(string[] args)
        {
            #region question 1 

            Point3D P = new Point3D(10, 10, 10);
            Console.WriteLine(P.ToString());


            Point3D P1 = ReadPointFromUser("Enter coordinates for Point P1:");
            Point3D P2 = ReadPointFromUser("Enter coordinates for Point P2:");


            if (P1 == P2)
                Console.WriteLine("P1 and P2 are equal.");
            else
                Console.WriteLine("P1 and P2 are not equal.");


            Point3D[] points = {
            new Point3D(3, 4, 1),
            new Point3D(1, 2, 3),
            new Point3D(2, 3, 4)
        };

            Array.Sort(points);

            Console.WriteLine("Sorted points:");
            foreach (var point in points)
            {
                Console.WriteLine(point.ToString());
            }


            Point3D clonePoint = (Point3D)P.Clone();
            Console.WriteLine("Cloned Point: " + clonePoint.ToString());
            #endregion

            #region question 2 

            double num1 = 10;
            double num2 = 5;


            Console.WriteLine($"Addition: {Maths.Add(num1, num2)}");
            Console.WriteLine($"Subtraction: {Maths.Subtract(num1, num2)}");
            Console.WriteLine($"Multiplication: {Maths.Multiply(num1, num2)}");


            if (num2 != 0)
            {
                Console.WriteLine($"Division: {Maths.Divide(num1, num2)}");
            }
            else
            {
                Console.WriteLine("Error: Cannot divide by zero.");
            }

            #endregion

            #region question 3 


            Duration D1 = new Duration(1, 10, 15);
            Console.WriteLine(D1);

            Duration D2 = new Duration(3600);
            Console.WriteLine(D2);

            Duration D3 = new Duration(7800);
            Console.WriteLine(D3);

            Duration D4 = new Duration(666);
            Console.WriteLine(D4);

        
            D3 = D1 + D2;
            Console.WriteLine($"D3 = D1 + D2: {D3}");

            D3 = D1 + 7800;
            Console.WriteLine($"D3 = D1 + 7800: {D3}");

            D3 = 666 + D3;
            Console.WriteLine($"D3 = 666 + D3: {D3}");

            D3 = ++D1; 
            Console.WriteLine($"D3 = ++D1: {D3}");

            D3 = --D2; 
            Console.WriteLine($"D3 = --D2: {D3}");

            D1 = D1 - D2;
            Console.WriteLine($"D1 = D1 - D2: {D1}");

            if (D1 > D2)
                Console.WriteLine("D1 is greater than D2");

            if (D1 <= D2)
                Console.WriteLine("D1 is less than or equal to D2");

            
            DateTime obj = D1;
            Console.WriteLine($"DateTime from D1: {obj}");

            #endregion
        }



    }  
}








       