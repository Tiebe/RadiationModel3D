using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thulium160m : RadioactiveSubstance
    {
        public override string name { get; } = "Thulium160m";
        public override double halfLife { get; } = 74.5d;
        public override double atomicWeight { get; } = 159.93534d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.85d, new List<RadioactiveSubstance> { new GammaParticle(0.01771, 70000.0), new Thulium160() } },
            { 0.15d, new List<RadioactiveSubstance> { new BetaParticle(1, 5834000.0), new Erbium160() } },

        };
    }
}
    
    