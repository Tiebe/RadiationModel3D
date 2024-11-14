using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Holmium162m : RadioactiveSubstance
    {
        public override string name { get; } = "Holmium162m";
        public override double halfLife { get; } = 4020.0d;
        public override double atomicWeight { get; } = 161.92922d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.62d, new List<RadioactiveSubstance> { new GammaParticle(0.0117), new Holmium162() } },
            { 0.38d, new List<RadioactiveSubstance> { new BetaParticle(1, 2246200.0), new Dysprosium162() } },

        };
    }
}
    
    