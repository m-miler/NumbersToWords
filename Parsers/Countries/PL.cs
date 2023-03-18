using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parsers.Countries
{
    public class PL : Convert, IWords
    {
        public override List<List<string>> Small { get; }
        public override List<string> Midium { get; }
        public override List<List<string>> Big { get; }


        public PL() 
        {
            Small = new List<List<string>>();
            Midium = new List<string> { "dziesięć", "jedenaście", "dwanaście", "trzynaście", "czternaście", "piętnaście", "szesnaście", "siedemnaście",
                                        "osiemnaście", "dziewiętnaście"};
            Big = new List<List<string>>();

            Small.Add(new List<string> { "", "jeden", "dwa", "trzy", "cztery", "pięć", "sześć", "siedem", "osiem", "dziewięć" });
            Small.Add(new List<string> { "", "", "dwadzieścia", "trzydzieści", "czterdzieści", "pięćdziesiąt", "sześćdziesiąt",
                                        "siedemdziesiąt","osiemdziesiąt", "dziewięćdziesiąt" });
            Small.Add(new List<string> { "", "sto", "dwieście", "trzysta", "czterysta", "pięćset", "sześćset", "siedemset", "osiemset", "dziewięćset" });

            Big.Add(new List<string> { "tysiąc", "tysiące", "tysięcy" });
            Big.Add(new List<string> { "milion", "miliony", "milionów" });
            Big.Add(new List<string> { "miliard", "miliardy", "miliardów" });
            Big.Add(new List<string> { "bilion", "biliony", "bilionów" });
        }


    }
}
