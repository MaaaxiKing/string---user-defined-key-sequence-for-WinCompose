while (true)
{
    string n = String.Empty;
    Console.ReadLine().ToList().ForEach(c => n += $"<{c}> ");
    Console.WriteLine($"<Multi_key> {n}: \"\"");
}
