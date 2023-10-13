using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroGameLogic
{
    public class Weather : IWeather
    {
        private readonly Random _random;

        public Weather()
        {
            _random = new Random();
        }

        public IWeather.Meteo WhatWeatherIsIt()
        {
            int result = _random.Next(0,21);
            if(result < 10)
            {
                return IWeather.Meteo.Soleil;
            }
            if (result < 20)
            {
                return IWeather.Meteo.Pluie;
            }
            return IWeather.Meteo.Tempete;
        }
    }
}
