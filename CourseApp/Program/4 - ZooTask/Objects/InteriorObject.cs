namespace CourseApp
{
    using System;

    public class InteriorObject : Staff, IDrawable
    {
        public InteriorObject(string type, string size, string material)
            : base(type, size, material)
        {
            Type = type;
            Size = size;
            Material = material;
        }

        public void Draw()
        {
            var information = @$"  Class: InteriorObject
    Type: {(string.IsNullOrEmpty(Type) ? "none" : Type)}
    Size: {(string.IsNullOrEmpty(Size) ? "none" : Size)}
    Material: {(string.IsNullOrEmpty(Material) ? "none" : Material)}
    ";
            Console.WriteLine(information);
        }
    }
}