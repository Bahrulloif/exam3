var point = new Point(2, 3);
System.Console.WriteLine(point.GetX());
point.SetX(3);
System.Console.WriteLine(point.GetY());
point.SetY(4);
System.Console.WriteLine(point.ToString());
foreach (var item in point.GetXY())
{
    System.Console.WriteLine($"({item}, ");
}
point.SetXY(5,6);
System.Console.WriteLine(point.Distance(7,8));
var point2=new Point(7,8);
System.Console.WriteLine(point.Distance(point2));
System.Console.WriteLine(point.Distance());
//Circle

System.Console.WriteLine("Circle");
var circle=new Circle(3,4,1.0);
var circle2=new Circle(point, 2.0);
System.Console.WriteLine(circle2.GetRadius());
circle.SetRadius(3.0);
var c=circle.GetCenter();

System.Console.WriteLine($"({c.GetX()}, {c.GetY()})");



System.Console.WriteLine(circle.GetCenterX());
circle.SetCenterX(4);
System.Console.WriteLine(circle.GetCenterY());
circle.SetCenterY(5);

foreach (var item in circle.GetCenterXY())
{
    System.Console.WriteLine($"({item}, )");
}

circle.SetCenterXY(9,10);
System.Console.WriteLine(circle.ToString());
System.Console.WriteLine(circle.GetArea());
System.Console.WriteLine(circle.GetCircumference());
System.Console.WriteLine(circle.Distance(circle2));