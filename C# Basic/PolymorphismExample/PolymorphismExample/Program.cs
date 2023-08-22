namespace PolymorphismExample
{
    class Program
    {
        public static void Main()
        {
            var shapes = new List<Shape>
            {
                new Rectangle(),
                new Triangle(),
                new Circle()
            };

            foreach (var shape in shapes)
            {
                shape.Draw();
            }
            /* Output: 
             * Drawing a rectangle 
             * Performoing base class drawing tasks
             * Drawing a triangle
             * Performing base class drawing tasks
             * Drawing a circle 
             * Performing base class drawing tasks
             */
        }
    }

}
