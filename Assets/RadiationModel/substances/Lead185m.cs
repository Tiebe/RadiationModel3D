using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lead185m : RadioactiveSubstance
    {
        public override string name { get; } = "Lead185m";
        public override double halfLife { get; } = 4.07d;
        public override double atomicWeight { get; } = 184.98769d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.5d, new List<RadioactiveSubstance> { new AlphaParticle(7786047.4), new Mercury181() } },

        };
    }
}
    
    