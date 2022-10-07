namespace AsyncVoid
{
    public class DataWriter
    {
        public async Task WriteDataAsync(string data)
        {
            using StreamWriter writer = new StreamWriter("Sub/Output.txt", true);

            await Task.Delay(1000);

            await writer.WriteLineAsync(data);

            Console.WriteLine("Data written.");
        }
    }
}
