// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


///Default
int a = default;
const int b = default;
int? d = default;

Console.WriteLine(d == null);

var e = new[] { default, 33, default };

string s = default;

if(s == default)
{

}

var x = a > 0 ? default : 1.5;

//Tuples ref name

var me = (name: "Dimitri", age: 30);
Console.WriteLine(me);

var alsoMe = (me.age, me.name);
Console.WriteLine(alsoMe.age);

var months = new[] { "March", "April", "May" };
var result = months.Select(m => (
    m.Length,
    FirstChat: m[0]
)).Where(t => t.Length == 3);

Console.WriteLine(string.Join(",", result));

var now = DateTime.UtcNow;
var u = (now.Hour, now.Minute);
var v = ((u.Hour, u.Minute) = (2, 1));
Console.WriteLine(v.Hour);



