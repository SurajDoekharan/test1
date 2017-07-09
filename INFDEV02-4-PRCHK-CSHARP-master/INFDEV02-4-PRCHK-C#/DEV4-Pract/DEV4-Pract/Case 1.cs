using System;

namespace DEV4_Pract.Case1
{
  public interface GuiElement
  {
    void Draw();
  }
  public class Button : GuiElement
  {
    public void Draw() { Console.WriteLine("I am a button..."); }
  }
  public class Label : GuiElement
  {
    public void Draw() { Console.WriteLine("I am a label..."); }
  }

  //Simple factory
  public abstract class GuiElementFactory 
  {
    // TODO Missing code: 1.5 point
    public class createGuiElement
        {
            public void Draw() { Console.WriteLine("Creating element"); }
        }
    public class GuiElement
    {
      if (elementCode == 0)
      {
        return new Button();
      }
      return new Label();
    }
  }
}
