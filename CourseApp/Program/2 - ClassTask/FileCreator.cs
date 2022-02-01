namespace CourseApp
{
    using System;
    using System.Collections.Generic;

    public class FileCreator
    {
        public FileCreator(string filename, string extension, string weight, string weightModificator)
        {
            FileName = filename;
            Extension = extension;
            Weight = weight;
            WeightModificator = weightModificator;
        }

        public FileCreator(List<string> customValues)
        {
            if (customValues.Count != 4)
            {
                throw new NullReferenceException();
            }

            FileName = customValues[0];
            Extension = customValues[1];
            Weight = customValues[2];
            WeightModificator = customValues[3];
        }

        public string FileName { get; set; }

        public string Extension { get; set; }

        public string Weight { get; set; }

        public string WeightModificator { get; set; }

        public string Display()
        {
            return $"{FileName}.{Extension} {Weight}{WeightModificator}";
        }
    }
}
