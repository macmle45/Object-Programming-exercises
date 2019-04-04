using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiclesLogic.Interfaces
{
    interface IEngine
    {
        string EngineType { get; set; }
        double EnginePower { get; set; }
        string EnginePetrolType { get; set; }
    }
}
