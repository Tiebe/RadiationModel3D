using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rubidium83 : RadioactiveSubstance
    {
        public override string name { get; } = "Rubidium83";
        public override double halfLife { get; } = 7447680.0d;
        public override double atomicWeight { get; } = 82.91511d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new Krypton83() } },

        };
    }
}
    
    