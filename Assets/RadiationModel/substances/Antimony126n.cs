using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Antimony126n : RadioactiveSubstance
    {
        public override string name { get; } = "Antimony126n";
        public override double halfLife { get; } = 11.0d;
        public override double atomicWeight { get; } = 125.9073d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.0d, new List<RadioactiveSubstance> { new GammaParticle(0.031), new Antimony126() } },
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.06199), new Antimony126m() } },

        };
    }
}
    
    