using System;
namespace PolymorphismExample
{
	public class Circle: Shape
	{
        public override void Draw()
        {
            Console.WriteLine("Drawing a circle");
            base.Draw();
        }
    }
}

