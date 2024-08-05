for (int i = 1; i <= 10000; i++)
{
    string text = "";

    if (i % 3 == 0)
        text += "Fizz";

    if (i % 13 == 0)
        text += "Fezz";

    if (i % 5 == 0)
        text += "Buzz";

    if (i % 7 == 0)
        text += "Bang";

    if (i % 11 == 0)
    {
        text = "Bong";
        if (i % 13 == 0)
            text = "FezzBong";
    }

    if (i % 17 == 0)
    {
        if (text.Length == 8)
        {
            text = text.Substring(4, 4) + text.Substring(0, 4);
        }
        else if (text.Length == 12)
        {
            text = text.Substring(8, 4) + text.Substring(4, 4) + text.Substring(0, 4);
        }
    }

    if (text != "")
        Console.WriteLine(text);
    else
        Console.WriteLine(i);
}