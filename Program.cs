Console.Write("Enter a number: ");

int limit = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= limit; i++)
{
    string text = "";

    if (i % 3 == 0 && args.Contains("3"))
        text += "Fizz";

    if (i % 13 == 0 && args.Contains("13"))
        text += "Fezz";

    if (i % 5 == 0 && args.Contains("5"))
        text += "Buzz";

    if (i % 7 == 0 && args.Contains("7"))
        text += "Bang";

    if (i % 11 == 0 && args.Contains("11"))
    {
        text = "Bong";
        if (i % 13 == 0 && args.Contains("13"))
            text = "FezzBong";
    }

    if (i % 17 == 0 && args.Contains("17"))
    {
        if (text.Length == 8)
        {
            // text = text.Substring(4, 4) + text.Substring(0, 4);
            text = string.Concat(text.AsSpan(4, 4), text.AsSpan(0, 4));
        }
        else if (text.Length == 12)
        {
            // text = text.Substring(8, 4) + text.Substring(4, 4) + text.Substring(0, 4);
            text = string.Concat(text.AsSpan(8, 4), text.AsSpan(4, 4), text.AsSpan(0, 4));
        }
    }

    if (text != "")
        Console.WriteLine(text);
    else
        Console.WriteLine(i);
}