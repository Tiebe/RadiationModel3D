using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tungsten178 : RadioactiveSubstance
    {
        public override string name { get; } = "Tungsten178";
        public override double halfLife { get; } = 1866240.0d;
        public override double atomicWeight { get; } = 177.94589d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new Tantalum178() } },

        };
    }
}
    
    