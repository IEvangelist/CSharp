static void PrintStars(object obj)
{
    // Constant pattern "null", instead of (obj == null)
    if (obj is null)
    {
        return;
    }

    // Mixing metaphors...
    // (obj is int i)
    // "obj is int"     // type assertion
    //        "int i"   // declaration

    if (obj is int i)   // Type pattern "int i"
    {
        WriteLine(new string('*', i));
    }

    // Note: that "i" is still available to us in this scope.
    var f = i;
}

class Shape
{
    protected internal double Height { get; }

    protected internal double Length { get; }

    protected Shape(
        double height = 0,
        double length = 0)
    {
        Height = height;
        Length = length;
    }
}

class Circle : Shape
{
    internal double Radius => Height / 2;

    internal double Diameter => Radius * 2;

    internal double Circumference => 2 * PI * Radius;

    internal Circle(double height = 10, double length = 10) 
        : base(height, length) { }
}

class Rectangle : Shape
{
    internal bool IsSquare => Height == Length;

    internal Rectangle(double height = 10, double length = 10) 
        : base(height, length) { }
}

void OutputShapes(List<Shape> shapes)
  => shapes.ForEach(shape =>
     {
         // Before C# 7, Types had to be concrete
         // such as enums, numerics, bools, strings, etc.
         switch (shape)
         {
             case Circle c:
                 WriteLine($"circle with circumference {c.Circumference}");
                 break;
             case Rectangle s when (s.IsSquare):
                 WriteLine($"{s.Length} x {s.Height} square");
                 break;
             case Rectangle r:
                 WriteLine($"{r.Length} x {r.Height} rectangle");
                 break;
             default:
                 WriteLine("This is not a shape that we're familiar with...");
                 break;
         }
     });










// Hacker!
