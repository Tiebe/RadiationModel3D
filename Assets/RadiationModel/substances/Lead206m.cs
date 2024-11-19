using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lead206m : RadioactiveSubstance
    {
        public override string name { get; } = "Lead206m";
        public override double halfLife { get; } = 0.00013d;
        public override double atomicWeight { get; } = 205.97683d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((2200199.99999, 0.00056)), new Lead206() } },

        };
    }
}
    
    