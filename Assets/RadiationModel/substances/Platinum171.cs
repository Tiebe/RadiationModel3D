using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Platinum171 : RadioactiveSubstance
    {
        public override string name { get; } = "Platinum171";
        public override double halfLife { get; } = 0.0455d;
        public override double atomicWeight { get; } = 170.98125d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.86d, new List<RadioactiveSubstance> { new AlphaParticle(7627002.09), new Osmium167() } },

        };
    }
}
    
    