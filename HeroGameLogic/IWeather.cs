using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroGameLogic
{
    public interface IWeather
    {
        public enum Meteo
        {
            Soleil,
            Pluie,
            Tempete
        }

        Meteo WhatWeatherIsIt();
    }
}
