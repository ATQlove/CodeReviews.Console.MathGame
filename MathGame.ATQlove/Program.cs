// Program.cs
using MathGame.ATQlove;

class Program
{
    static void Main()
    {
        var menu = new Menu();
        var date = DateTime.UtcNow;
        string name = Utilities.GetName();
        menu.ShowMenu(name, date);
    }
}
