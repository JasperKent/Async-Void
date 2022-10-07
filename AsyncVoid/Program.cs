using AsyncVoid;

//Func<int> func;

//func = () => Log(1);
//func += () =>Log( 2);
//func += () =>Log( 3);
//func += () =>Log( 4);

//Console.WriteLine(func());

//return;

int Log(int i)
{
    Console.WriteLine(i);
    return i;
}

var dataWriter = new DataWriter();

var message = Console.ReadLine();

while (!string.IsNullOrEmpty(message))
{
    try
    {
        Console.WriteLine("Calling...");

        await dataWriter.WriteDataAsync(message);

        Console.WriteLine("Complete.");
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }

    message = Console.ReadLine();
}



