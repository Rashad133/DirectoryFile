using Newtonsoft.Json;

namespace Task_26._10
{
    internal class Program
    {
        private static string path = "names.json";
        static void Main(string[] args)
        {
            List<string> list = new List<string> { };
            Serialize(names);
            Add();
            Delete();

        }

        static void Add(string name)
        {
            List<string> names = Deserialize;
            if(name == null)
            {
                name = path;
            }
            Serialize(names);
            Console.WriteLine($"{name}");


        }

        static bool Search(string search)
        {
            List<string> names = Deserialize();

        }

        static void Delete(string name)
        {
            List<string> names = Deserialize();
        }

        public static List<string> Serialize(List<string> names)
        {
            string result = JsonConvert.SerializeObject(names);

            using(StreamWriter sw = new StreamWriter(result))
            {
                sw.Write(result);
            }
        }
      
        public static List<string> Deserialize()
        {
            string result;
            using(StreamReader sr  = new StreamReader(path))
            {
                result = sr.ReadToEnd();
            }
            
        }
    }
}