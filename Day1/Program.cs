Console.WriteLine("Advent Of Code 2023 Day1");

var dataset = File.ReadAllLines("C:\\Dev\\Aoc-2023\\Day1\\data\\prod.txt");

var totalcount1 = 0;
var totalcount2 = 0;

// Solution 1

foreach (var line in dataset)
{
    totalcount1 += int.Parse(line.FirstOrDefault(char.IsDigit).ToString() + line.LastOrDefault(char.IsDigit).ToString());
}

// Solution 2

var replacementset = new Dictionary<string, string>
{
    {"one", "1" },
    {"two", "2" },
    {"three", "3" },
    {"four", "4" },
    {"five", "5" },
    {"six", "6" },
    {"seven", "7" },
    {"eight", "8" },
    {"nine", "9" }
};

foreach (var line in dataset)
{
    string newline = line;
    foreach (var key in replacementset.Keys)
    {
        newline = newline.Replace(key, string.Concat(key, replacementset[key], key));
    }

    var linecount = int.Parse(newline.FirstOrDefault(char.IsDigit).ToString() + newline.LastOrDefault(char.IsDigit).ToString());
    totalcount2 += linecount;
}

Console.WriteLine(totalcount1.ToString());
Console.WriteLine(totalcount2.ToString());
