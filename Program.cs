using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vj._3_klase_i_objekti
{
    public class Stablo
    {
        private bool otpadajuListovi;
        private string vrstaStabla;

        public bool OtpadajuListovi
        {
            get { return otpadajuListovi; }
            set { otpadajuListovi = value; }
        }

        public Stablo(bool otpadajuListovi)
        {
            this.otpadajuListovi = otpadajuListovi;
        }

        public override string ToString()
        {
            if (otpadajuListovi)
            {
                vrstaStabla = "bijelogorično";
            }
            else
            {
                vrstaStabla = "crnogorično";
            }

            return $"Vrsta stabla: {vrstaStabla}, Otpadaju listovi: {otpadajuListovi}";
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Stablo stablo1 = new Stablo(false);
            Stablo stablo2 = new Stablo(true);

            Console.WriteLine(stablo1.ToString());
            Console.WriteLine(stablo2.ToString());

            Console.ReadKey();
        }
    }

}
