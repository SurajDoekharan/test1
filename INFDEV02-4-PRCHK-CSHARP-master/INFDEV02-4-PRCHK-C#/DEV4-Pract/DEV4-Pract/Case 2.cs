using System;

namespace DEV4_Pract.Case2
{
  public interface GuiElement
  {
        // TODO Missing code: 1 point
        void Draw();
        string Visit(Func<string> p1, Func<string> p2);
    }
  public class Button : GuiElement // TODO Missing code: 0.5 point
  {
    public U Visit<U>(Func<U> onLabel, Func<U> onButton)
    {
      // TODO Missing code: 1 point
    }
  }
  public class Label : GuiElement// TODO Missing code: 0.5 point
  {
    public U Visit<U>(Func<U> onLabel, Func<U> onButton)
    {
      // TODO Missing code: 1 point
    }
  }
}