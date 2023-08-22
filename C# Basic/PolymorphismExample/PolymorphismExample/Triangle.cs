using System;
namespace PolymorphismExample
{
	public class Triangle: Shape
	{
		public override void Draw()
		{
			Console.WriteLine("Drawing a triangle");
			base.Draw();
		}
	}
}

