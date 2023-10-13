using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroGameLogic
{
    public class FakeDice : IDice
    {
        private readonly int[] _diceList;
        private int _count;

        public FakeDice()
        {
            _diceList = new int[] { 4, 5, 1, 1, 4, 3, 5, 6, 6, 6, 1, 2, 4, 2, 3, 2, 6, 4, 5, 1, 1, 4, 3, 5, 6, 6, 6, 1, 2, 4, 2, 3, 2, 6 };
            _count = 0;
        }

        public int RollDice()
        {
            int result = _diceList[_count];
            _count++;
            return result;
        }
    }
}
