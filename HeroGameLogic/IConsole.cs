using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroGameLogic
{
    public interface IConsole
    {
        void Write(string text);
        void WriteLine(string text);
    }
}
