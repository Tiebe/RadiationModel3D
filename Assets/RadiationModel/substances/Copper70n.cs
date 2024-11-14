using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Copper70n : RadioactiveSubstance
    {
        public override string name { get; } = "Copper70n";
        public override double halfLife { get; } = 6.6d;
        public override double atomicWeight { get; } = 69.93265d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.932d, new List<RadioactiveSubstance> { new BetaParticle(-1, 6830900.0), new Zinc70() } },
            { 0.068d, new List<RadioactiveSubstance> { new GammaParticle(0.00511), new Copper70() } },

        };
    }
}
    
    