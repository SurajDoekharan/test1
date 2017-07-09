using System;

namespace DEV4_Pract.Case3
{
  public interface Shape
  {
    void Draw();  
  }

  public class Circle : Shape
  {
    float x, y, radius;
    public Circle(float x, float y, float radius)
    {
      this.x = x;
      this.y = y;
      this.radius = radius;
    }
    public void Draw()
    {
      Console.WriteLine("Drawing a circle at: (" + x + "," + y + ") with radius " + radius);
    }
  }

  public class Rectangle : Shape // TODO Missing code: 1 point
  {

        // TODO Missing code: 1 point
        float x, y, width, height;
    public Rectangle(float x, float y, float width, float height)
    {
      this.x = x;
      this.y = y;
      this.width = width;
      this.height = height;
      this.rectangle = Rectangle; // TODO Missing code: 1 point
    }

    public void Draw()
    {
      Console.WriteLine("Adapting...");
      // TODO Missing code: 1.5 point
    }
  }

  public class LegacyRectangle
  {
    public void Draw(float x, float y, float width, float height)
    {
      Console.WriteLine("Drawing a rectangle at: (" + x + "," + y + ") with width " + width + " and height " + height);
    }
  }
}



