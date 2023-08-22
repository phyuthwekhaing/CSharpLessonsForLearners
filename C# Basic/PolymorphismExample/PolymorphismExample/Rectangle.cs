using System;
namespace PolymorphismExample
{
	public class Rectangle:Shape
	{
        public override void Draw()
        {
            Console.WriteLine("Drawing a rectangle");
            base.Draw();
        }
    }
}

