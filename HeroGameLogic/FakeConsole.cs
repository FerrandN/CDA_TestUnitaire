using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroGameLogic
{
    public class FakeConsole : IConsole
    {
        public StringBuilder stringBuilder = new StringBuilder();

        public void Write(string text) 
        { 
            stringBuilder.Append(text);
        }

        public void WriteLine(string text) 
        {  
            stringBuilder.AppendLine(text); 
        }
    }
}
