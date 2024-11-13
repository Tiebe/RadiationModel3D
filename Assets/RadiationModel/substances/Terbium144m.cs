
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Terbium144m : RadioactiveSubstance
    {
        public override string name { get; } = "Terbium144m";
        public override double halfLife { get; } = 4.25d;
        public override double atomicWeight { get; } = 143.93347d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.66d, new List<RadioactiveSubstance> { new GammaParticle(), new Terbium144() } },

            { 0.34d, new List<RadioactiveSubstance> { new BetaParticle(), new Gadolinium144() } },

        };
    }
}
    
    