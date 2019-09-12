using System;

namespace Task1
{
    class Rectangle
    {
        //vars
        public double length;
        public double width;
        public double x, y;

        //constructor
        public Rectangle(double length,double width,double x,double y)
        {
            this.length = length;
            this.width = width;
            this.x = x;
            this.y = y;
        }

        //methods
        public double getArea()
        {
            return this.length * this.width;
        }

        public double getPerimeter()
        {
            return this.length * 2 + this.width * 2;
        }

        public double getDiagonal()
        {
            return Math.Sqrt(this.length * this.length + this.width * this.width);
        }

        public string getInterCord()
        {
            //this.length/2 is x coordinate center, this.width/2 is height coordinate center +take into consideration upper starting point coordinate
            
            return "{" + (this.length / 2 + this.x).ToString() + "} {" +(this.width / 2 + this.y).ToString() + "} ";
        }
       
    }
}