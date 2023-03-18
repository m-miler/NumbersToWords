using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parsers.Countries
{
    public interface IWords 
    {
        List<List<string>> Small { get; }
        List<string> Midium { get; }
        List<List<string>> Big { get; }
    }
}
