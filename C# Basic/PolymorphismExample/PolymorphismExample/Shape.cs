using System;
namespace PolymorphismExample
{
	public class Shape
	{
        public int X { get; private set; }
        public int Y { get; private set; }
		private int Height { get; set; }
		private int Width { get; set; }
		public virtual void Draw()
		{
			Console.WriteLine("Performing base class drawing tasks");
		}
	}
}

