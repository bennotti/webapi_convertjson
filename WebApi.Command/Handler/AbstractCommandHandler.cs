using Newtonsoft.Json;
using System.IO;

namespace WebApi.Command.Handler
{
    public abstract class AbstractCommandHandler<T> where T : class, new()
    {
        public T ClassReference { get; set;}
        public string PathRoot { get; }
        public string PathModulo;

        public AbstractCommandHandler(T classReference, string pathModulo)
        {
            ClassReference = classReference;
            PathModulo = pathModulo;
        }

        public void SaveObjectJson()
        {
            var settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All };
            string jsonData = JsonConvert.SerializeObject(ClassReference, Formatting.None, settings);

            File.WriteAllText(PathModulo, jsonData); 
        }
    }
}
