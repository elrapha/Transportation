using System.IO;
using Transportation.Interfaces;

namespace Transportation.Services
{
    public class JsonFileWriter : IWriter
    {
        public string FilePath;
        private const string FileExt = ".json";

        public JsonFileWriter(string path)
        {
            if (string.IsNullOrEmpty(path))
            {
                FilePath = "output";
            }
            FilePath = path;
        }


        public void Write(IVehicle vehicle)
        {
            Write(vehicle.ToString());
        }

        public void Write(string s)
        {
            File.WriteAllText(FilePath + FileExt, s);
        }
    }
}