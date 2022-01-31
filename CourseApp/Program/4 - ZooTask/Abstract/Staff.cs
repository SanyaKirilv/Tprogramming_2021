namespace CourseApp
{
    public abstract class Staff
    {
        public Staff(string type, string size, string material)
        {
            Type = type;
            Size = size;
            Material = material;
        }

        public string Type { get; set; }

        public string Size { get; set; }

        public string Material { get; set; }
    }
}
