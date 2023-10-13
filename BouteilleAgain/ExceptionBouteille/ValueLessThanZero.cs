using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BouteilleAgain.ExceptionBouteille
{
    public class ValueLessThanZero : Exception
    {
        public ValueLessThanZero(string message) : base(message) 
        {
            Console.WriteLine(message);
        }
    }
}
