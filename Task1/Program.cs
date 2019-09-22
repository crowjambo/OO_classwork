//EVALDAS PAULAUSKAS PI18E
//TASK 1


using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
                       //create rect obj length,width, x, y
            Rectangle newRect = new Rectangle(20,15,0,0);

            //calculate and output
            Console.WriteLine("Perimeter: " + newRect.getPerimeter());
            Console.WriteLine("Area: " + newRect.getArea());
            Console.WriteLine("Diagonal length: {0:0.00}", newRect.getDiagonal());
            Console.WriteLine("Diagonal cross point coordinates: " + newRect.getInterCord());
        }
    }
}
