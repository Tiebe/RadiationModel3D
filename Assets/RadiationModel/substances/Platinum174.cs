using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Platinum174 : RadioactiveSubstance
    {
        public override string name { get; } = "Platinum174";
        public override double halfLife { get; } = 0.862d;
        public override double atomicWeight { get; } = 173.97282d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.7490000000000001d, new List<RadioactiveSubstance> { new AlphaParticle(7205002.09), new Osmium170() } },

        };
    }
}
    
    