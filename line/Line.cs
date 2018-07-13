using System;

namespace Line
{
  public class Line
  {
    private double length; // Length of a line

    public Line()
    {
      Console.WriteLine("Object is being created");
    }

    public void setLength(double len)
    {
      length = len;
    }

    public double getLength()
    {
      return length;
    }
  }
}