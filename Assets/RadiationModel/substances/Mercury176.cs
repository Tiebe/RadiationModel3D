using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Mercury176 : RadioactiveSubstance
    {
        public override string name { get; } = "Mercury176";
        public override double halfLife { get; } = 0.0203d;
        public override double atomicWeight { get; } = 175.98735d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9d, new List<RadioactiveSubstance> { new AlphaParticle(7919002.09), new Platinum172() } },

        };
    }
}
    
    