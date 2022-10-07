using System.IO;
using System.Threading.Tasks;

namespace AsyncVoid.GUI
{
    public class DataWriter
    {
        public async Task WriteDataAsync(string data)
        {
            using StreamWriter writer = new StreamWriter("Sub/Books.txt", true);

            await Task.Delay(1000);

            await writer.WriteLineAsync(data);
        }
    }
}
