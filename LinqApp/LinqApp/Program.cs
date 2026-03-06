
using LinqApp;

var mas = new int[]{ 1, 2, 3, 6, -7, 2, -4, 3, 15, -8, 2, 6 };


var m1 = mas.Where(x => x > 0).Skip(3).OrderBy(x => x % 3).Any(x=>x>10);

Console.WriteLine(m1);

//foreach (var x in m1)
//    Console.WriteLine(x);
Console.WriteLine("**************************************");

var l = Student.GetStudents().Where(s => s.Age == 20).SelectMany(s => s.Marks);

foreach (var m in l)
{
    Console.WriteLine(m);
}



Console.WriteLine("**************************************");

var lst = Student.GetStudents().Where(s => s.Age > 20)
    .OrderByDescending(s => s.Marks.Average())
    .Select(s => new { s.Name, s.Age, Coef = s.Age*s.Id })
    .OrderBy(a=>a.Coef);

foreach (var s in lst)
{
    Console.WriteLine(s);
}


Console.WriteLine("**************************************");

var gr = Student.GetStudents().GroupBy(s => s.Age)
    .Select(g => new { Age = g.Key, Count = g.Count(), Max = g.Min(s => s.Name) });

foreach (var g in gr)
{
    Console.WriteLine(g);

}

var gr2 = Student.GetStudents().GroupBy(s => new { s.Age, s.Marks.Count })
    .Select(g => new {g.Key, Count = g.Count(), Max = g.Min(s => s.Name) });

foreach (var g in gr2)
{
    Console.WriteLine(g);
}


Console.WriteLine("**************************************");

//var st = Student.GetStudents().OrderByDescending(s => s.Name[s.Name.Length - 1]).First();

var st = Student.GetStudents().LastOrDefault(s=>s.Age==28);

if (st != null)
    Console.WriteLine(st);
else
    Console.WriteLine("нет таких");


Console.WriteLine("**************************************");


var gr1 = Group.GetGroups();
var st1 = Student.GetStudents();


var res = st1
    .Join(gr1, s => s.GroupId, g => g.Id, (s, g) => new { s.Name, s.Age, Group = g.Name, g.Faculty})
    .GroupBy(g=>g.Group).Select(f=>new { Group = f.Key, Count =  f.Count() });

var res2 = gr1
    .Join(st1, g => g.Id, s => s.GroupId, (g, s) => new { s.Name, s.Age, Group = g.Name, g.Faculty })
    .GroupBy(g => g.Group).Select(f => new { Group = f.Key, Count = f.Count() });


foreach (var r in res2)
{
    Console.WriteLine(r);
}
