using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Yttrium83m : RadioactiveSubstance
    {
        public override string name { get; } = "Yttrium83m";
        public override double halfLife { get; } = 171.0d;
        public override double atomicWeight { get; } = 82.92255d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.6d, new List<RadioactiveSubstance> { new BetaParticle(1, 4654000.0), new Strontium83() } },
            { 0.4d, new List<RadioactiveSubstance> { new GammaParticle(0.02, 62000.0), new Yttrium83() } },

        };
    }
}
    
    