try
{
    var replace = new Dictionary<string, string>
    {
        { "\\n", Environment.NewLine },
        { "\\", string.Empty },
    };

    if (args.Count() != 1)
    {
        return;
    }

    Console.WriteLine($"Formatting {args[0]}...");

    var file = File.ReadAllText(args[0]);

    foreach (var item in replace)
    {
        file = file.Replace(item.Key, item.Value);
    }

    var output = $"{args[0]}.dec";
    Console.WriteLine($"Writing to {output}...");

    File.WriteAllText(output, file);
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}
finally
{
    Console.ReadKey();
}
