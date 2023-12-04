using System.Text.RegularExpressions;

Console.WriteLine("Advent Of Code 2023 Day2");

var dataset = File.ReadAllLines("C:\\Dev\\Aoc-2023\\Day2\\data\\prod.txt");

var limits = new Dictionary<string, int>
{
    {"red", 12},
    {"green", 13},
    {"blue", 14}
};


var totalcount1 = 0;

// Solution 1

foreach (var line in dataset)
{
    string[] header = line.Split(':');
    var game = int.Parse(new Regex(@"\d+").Match(header[0]).Value);//Regex.Match(header[0]);
    var validgame = true;
    string[] pulls = header[1].Split(";");
    foreach (var pull in pulls)
    {
        string[] values = pull.Split(",");
        foreach (var value in values)
        {
            string[] elements = value.Trim().Split(" ");
            if (int.Parse(elements[0]) > limits[elements[1]])
            {
                validgame = false;
            }
        }
    }
    if (validgame) totalcount1 = totalcount1 + game;

}

Console.WriteLine($"Solution 1 : {totalcount1}");
