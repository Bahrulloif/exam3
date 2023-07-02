public class Circle : Point
{
    private Point _center = new Point(0, 0);
    private double _radius = 1.0;
    public Circle()
    {

    }
    public Circle(int xCenter, int yCenter, double radius) : base(xCenter, yCenter)
    {

    }
    public Circle(Point center, double radius)
    {

    }
    public double GetRadius()
    {
        return _radius;
    }
    public void SetRadius(double radius)
    {
        _radius = radius;
    }
    public Point GetCenter()
    {
        return _center;
    }
    public void SetCenter(Point center)
    {
        _center = center;
    }
    public int GetCenterX()
    {
        return _center.GetX();
    }
    public void SetCenterX(int x)
    {
        _center.SetX(x);
    }
    public int GetCenterY()
    {
        return _center.GetY();
    }
    public void SetCenterY(int y)
    {
        _center.SetY(y);
    }
    public int[] GetCenterXY()
    {
        return _center.GetXY();
    }
    public void SetCenterXY(int x, int y)
    {
        _center.SetXY(x, y);
    }
    public override string ToString()
    {
        return $"center={base.ToString()},radius={_radius}";
    }
    public double GetArea()
    {
        return 3.14 * _radius * _radius;
    }
    public double GetCircumference()
    {
        return 2 * 3.14 * _radius;
    }
    public double Distance(Circle another){
        return base.Distance(another);
    }
}