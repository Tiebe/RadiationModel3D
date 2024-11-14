using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iridium189 : RadioactiveSubstance
    {
        public override string name { get; } = "Iridium189";
        public override double halfLife { get; } = 1140480.0d;
        public override double atomicWeight { get; } = 188.95872d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new Osmium189() } },

        };
    }
}
    
    