using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cerium134 : RadioactiveSubstance
    {
        public override string name { get; } = "Cerium134";
        public override double halfLife { get; } = 273024.0d;
        public override double atomicWeight { get; } = 133.90893d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new Lanthanum134() } },

        };
    }
}
    
    