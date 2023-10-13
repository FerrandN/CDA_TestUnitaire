using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroGameLogic
{
    public class Ihm
    {
        private readonly IConsole _console;
        private readonly IDice _dice;
        public Ihm(IConsole console, IDice dice)
        {
            _console = console;
            _dice = dice;
        }
        public void Start()
        {

            Game game = new Game(new Weather());
            _console.WriteLine($"A l'attaque : points/vie {game.Hero.points}/{game.Hero.lifePoint}");

            while (game.Hero.lifePoint > 0)
            {
                var result = game.Turn(_dice.RollDice(), _dice.RollDice());

                switch (result)
                {
                    case Result.Win:
                        _console.Write($"Monstre Battu");
                        break;

                    case Result.Lost:
                        _console.Write($"Combat perdu");
                        break;
                }
                _console.WriteLine($": points/vie {game.Hero.points}/{game.Hero.lifePoint}");
            }
        }
    }
}
