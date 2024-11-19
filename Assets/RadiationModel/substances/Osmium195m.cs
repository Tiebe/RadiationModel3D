using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Osmium195m : RadioactiveSubstance
    {
        public override string name { get; } = "Osmium195m";
        public override double halfLife { get; } = 47.0d;
        public override double atomicWeight { get; } = 194.96878d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00288, 430000.0), new Osmium195() } },

        };
    }
}
    
    