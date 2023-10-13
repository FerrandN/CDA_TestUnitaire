using HeroGameLogic;

namespace HeroGame2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ihm ihm = new Ihm(new ConsoleOutPut(), new Dice());
            ihm.Start();
        }
    }
}