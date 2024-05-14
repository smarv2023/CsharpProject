List<int> numbers = [23, 10, 30, 40, 90, 60, 50];

IEnumerable<int> scores = from score in numbers
                          where score > 30
                          select score;

foreach (int score in scores)
    Console.WriteLine(score);

Console.WriteLine("myScores query");
List<int> myScore = scores.ToList();
foreach (int score in myScore)
    Console.WriteLine(score);

Console.WriteLine();
Console.WriteLine("String interpolation");
IEnumerable<string> scoresString = from score in numbers
                                   where score > 30
                                   select $"The score {score}";

foreach (string score in scoresString)
    Console.WriteLine(score);

Console.WriteLine();
Console.WriteLine("String query");
string[] names = new[] { "Michael", "Pam", "Jim", "Dwight",
  "Angela", "Kevin", "Toby", "Creed" };

var query = from name in names
            where name.Length > 4
            orderby name.Length
            select name;
foreach (string name in query)
    Console.WriteLine(name);

Console.WriteLine();
Console.WriteLine("String query2");
var query2 = names
        .Where(x => x.Length > 4)
        .OrderBy(x => x.Length);
        //.Select(x => x);
foreach (string name in query2)
    Console.WriteLine(name);
