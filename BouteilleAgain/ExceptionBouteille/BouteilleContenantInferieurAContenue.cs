using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BouteilleAgain.ExceptionBouteille
{
    public class BouteilleContenantInferieurAContenue : Exception
    {


        public BouteilleContenantInferieurAContenue(string message) : base(message) 
        {
            Console.WriteLine(message);
        }
    }
}
