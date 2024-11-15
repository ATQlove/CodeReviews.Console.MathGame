using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGame.ATQlove.Model;

internal class Game
{
    public DateTime Date { get; set; }
    public int Score {  get; set; }
    public GameType Type { get; set; }

}

internal enum GameType
{
    Addition, 
    Subtraction, 
    Multiplication, 
    Division
}
