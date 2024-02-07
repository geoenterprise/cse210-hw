using System;

class Program
{
    static void Main(string[] args)
    {
        //  Mycode: 
                    // Square square  = new Square("White", 5);
                    // Rectangle rectangle = new Rectangle("Blue", 5, 8);
                    // Circle circle = new Circle("Green", 4);

                    // Console.WriteLine($"Square color: {square.GetColor}");
                    // Console.WriteLine($"Square area: {square.GetArea}");

                    // List<Shape> shapes = new List<Shape>();

                    // shapes.Add(square);
                    // shapes.Add(rectangle);
                    // shapes.Add(circle);

                    // foreach (var shape in shapes)
                    // {
                    //     Console.WriteLine($"The shape color: {shape.GetColor()}");
                    //     Console.WriteLine($"The shape area: {shape.GetArea()}");

                    // }
        // Teacher's code:
         // Notice that the list is a list of "Shape" objects. That means
        // you can put any Shape objects in there, and also, any object where
        // the class inherits from Shape
        List<Shape> shapes = new List<Shape>();

        Square s1 = new Square("Red", 3);
        shapes.Add(s1);

        Rectangle s2 = new Rectangle("Blue", 4, 5);
        shapes.Add(s2);

        Circle s3 = new Circle("Green", 6);
        shapes.Add(s3);

        foreach (Shape s in shapes)
        {
            // Notice that all shapes have a GetColor method from the base class
            string color = s.GetColor();

            // Notice that all shapes have a GetArea method, but the behavior is
            // different for each type of shape
            double area = s.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}.");
        }
    }
        

}