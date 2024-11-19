using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Platinum176 : RadioactiveSubstance
    {
        public override string name { get; } = "Platinum176";
        public override double halfLife { get; } = 6.33d;
        public override double atomicWeight { get; } = 175.96894d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.4d, new List<RadioactiveSubstance> { new AlphaParticle(6907002.09), new Osmium172() } },

        };
    }
}
    
    