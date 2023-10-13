namespace BarnabeTestUnitaire
{
    public class Program
    {
        static void Main(string[] args)
        {
            CalculeNombreDeMagasinVisite(1500);
        }

        static public int CalculeNombreDeMagasinVisite(int balance)
        {
            int _balance = balance;
            int depense;
            int nbMagasin = 0;

            while (balance > 0)
            {
                //Console.WriteLine("Barnabe a " + balance + " euros");
                depense = (balance / 2) + 1;
                if (balance - depense >= 1)
                {
                    balance = balance - depense;
                }
                else
                {
                    balance = 0;
                }
                nbMagasin++;
                //Console.WriteLine("Barnabe a dépensé " + depense + " euros." + " IL lui reste " + balance + "et il a visité " + nbMagasin + "Magasins");
            }

            return nbMagasin;
        }
    }
}