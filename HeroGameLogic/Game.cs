using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HeroGameLogic.IWeather;

namespace HeroGameLogic
{
    public enum Result
    {
        Win,
        Lost
    }

    public class Game
    {
        public Hero Hero { get; }
        public Result Result { get; set; }

        private readonly IWeather _weather;

        public Game(IWeather weather)
        {
            Hero = new Hero(15);
            _weather = weather;
        }

        public Result Turn(int herosDice, int monsterDice)
        {
            if (WinBattle(herosDice, monsterDice))
            {
                Hero.WinBattle();
                this.Result = Result.Win;
                return Result.Win;
            }
            else
            {
                Meteo temps = _weather.WhatWeatherIsIt();
                if(temps == Meteo.Tempete)
                Hero.LostBattle(2*(monsterDice - herosDice));
                else
                    Hero.LostBattle((monsterDice - herosDice));
                this.Result = Result.Lost;
                return Result.Lost;
            }
        }

        private bool WinBattle(int dice, int otherDice)
        {
            return dice >= otherDice;
        }
    }
}
