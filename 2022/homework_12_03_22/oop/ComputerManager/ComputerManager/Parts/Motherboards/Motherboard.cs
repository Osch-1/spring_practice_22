using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerManager.Parts.Motherboards;

public abstract class Motherboard : IPart
{
    public string GetInfo()
    {
        throw new NotImplementedException();
    }
}
