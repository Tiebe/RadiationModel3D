using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Uranium238 : RadioactiveSubstance
    {
        public override string name { get; } = "Uranium238";
        public override double halfLife { get; } = 1.40838676776e+17d;
        public override double atomicWeight { get; } = 238.05079d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(5291702.09), new Thorium234() } },
            { 5.44e-07d, new List<RadioactiveSubstance> {  } },
            { 2.2e-12d, new List<RadioactiveSubstance> { new BetaParticle(-2, 1144600.0), new Plutonium238() } },

        };
    }
}
    
    