using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Radium208 : RadioactiveSubstance
    {
        public override string name { get; } = "Radium208";
        public override double halfLife { get; } = 1.11d;
        public override double atomicWeight { get; } = 208.00186d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.87d, new List<RadioactiveSubstance> { new AlphaParticle(8295002.09), new Radon204() } },

        };
    }
}
    
    