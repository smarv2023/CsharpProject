string[] names = new[] { "Michael", "Pam", "Jim", "Dwight",
  "Angela", "Kevin", "Toby", "Creed", };
SelectionTitle("Deferred execution");

var query1 = names.Where(name => name.EndsWith("m"));

var query2 = from name in names
             where name.EndsWith("m")
             select name;

string[] result1 = query1.ToArray();

List<string> result2 = query2.ToList();

foreach (string name in query1)
{
  WriteLine(name);
  names[2] = "Jimmy";
}

// new Func<string output, resutl bool> (Fuction from partial class Program.Function)
var query = names.Where(new Func<string, bool>(NameLongerThanFour));

foreach (string item in query)
{
  WriteLine(item);
}
