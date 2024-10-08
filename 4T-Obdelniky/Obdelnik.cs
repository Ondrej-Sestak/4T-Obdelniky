using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4T_Obdelniky
{
    public class Obdelnik : Čtverec
    {
        public int StranaB { get; set; } = 0;
        public int ObsahObdelnik { get => StranaA * StranaB; }
        public int ObvodObdelnik { get { return 2 * (StranaA + StranaB); } }


        public Obdelnik(int stranaA, int stranaB) : base(stranaA)
        {
            this.StranaB = stranaB;
        }

        public Obdelnik(string stranaA, string stranaB) : base(stranaA)
        {
            this.StranaB = Convert.ToInt32(stranaB);
        }
        public Obdelnik(string CSVLine) : base(CSVLine)
        {
            StranaA = Convert.ToInt32(CSVLine.Split(';')[0]);
            StranaB = Convert.ToInt32(CSVLine.Split(';')[1]);
        }
        public override string ToCSV() => base.ToCSV() +";"+ StranaB;

        public override string ToString() => "Obdelník " + " strana A: " + StranaA + ", strana B: " + StranaB;
        //$"Obdélník strana A: {stranaA}, stranaB: {stranaB}";
    }
    public class Trojuhelnik : Obdelnik
    {
        public int StranaC { get; set; } = 0;
        public Trojuhelnik(int stranaA, int stranaB, int stranaC) : base(stranaA, stranaB)
        {
            this.StranaC = stranaC;
        }

        public Trojuhelnik(string CSVLine) : base(CSVLine)
        {

        }

        public int ObvodTrojuhelnik => base.Obvod/2+StranaC;



        public override string ToCSV()
        {
            return base.ToCSV() + ";" + this.StranaC;
        }
    }
    public class Čtverec
    {
        public int StranaA { get; set; } = 0;
        public int Obsah { get => StranaA * StranaA; }
        public int Obvod { get { return 4 * StranaA; } }

        public Čtverec(int stranaA)
        {
            StranaA = stranaA;
        }

        public Čtverec(string stranaA)
        {
            StranaA = Convert.ToInt32(stranaA);
        }

        public Čtverec(string CSVline, string prazdny)
        {
            StranaA = Convert.ToInt32(CSVline.Split(';'));
        }

        public virtual string ToCSV() => StranaA.ToString();
        public override string ToString() => "Čtverec " + " strana A: " + StranaA;
    }
}
