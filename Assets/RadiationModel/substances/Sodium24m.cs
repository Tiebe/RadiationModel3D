
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Sodium24m : RadioactiveSubstance
    {
        public override string name { get; } = "Sodium24m";
        public override double halfLife { get; } = 0.02018d;
        public override double atomicWeight { get; } = 23.99147d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(), new Sodium24() } },

            { 0.0005d, new List<RadioactiveSubstance> { new BetaParticle(), new Magnesium24() } },

        };
    }
}
    
    