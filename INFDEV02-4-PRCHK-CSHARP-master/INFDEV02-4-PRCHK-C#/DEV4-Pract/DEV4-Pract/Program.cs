using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV4_Pract
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Testing case 1:");
      Case1.GuiElement aGuiElement = Case1.GuiElementFactory.createGuiElement(1);
      Console.WriteLine("Who are you?");
      aGuiElement.Draw();
      Console.WriteLine();
      Console.WriteLine();

      Console.WriteLine("Testing case 2:");
      Case2.GuiElement anotherGuiElement = new Case2.Button();
      string res = anotherGuiElement.Visit(() => "I am label", 
                                           () => "I am a button");
      Console.WriteLine(res);
      Console.WriteLine();
      Console.WriteLine();

      Console.WriteLine("Testing case 3:");
      Case3.Shape aShape = new Case3.Circle(0, 0, 10);
      Case3.Shape anotherShape = new Case3.Rectangle(10, 10, 50, 40);
      aShape.Draw();
      Console.WriteLine();
      anotherShape.Draw();
      Console.WriteLine();
      Console.WriteLine();
    }
  }
}
