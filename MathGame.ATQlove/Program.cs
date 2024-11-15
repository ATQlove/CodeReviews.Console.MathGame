// Program.cs
using MathGame.ATQlove;
using System.Web;

class Program
{
    static void Main()
    {
        var menu = new Menu();
        var date = DateTime.UtcNow;
        string name = Utilities.GetName();
        menu.showMenu(name, date);
        //Console.WriteLine("Hello, World!");
    }
}
