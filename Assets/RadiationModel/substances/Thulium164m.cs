using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thulium164m : RadioactiveSubstance
    {
        public override string name { get; } = "Thulium164m";
        public override double halfLife { get; } = 306.0d;
        public override double atomicWeight { get; } = 163.93356d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.8d, new List<RadioactiveSubstance> { new GammaParticle((20000.0, 0.06199)), new Thulium164() } },
            { 0.2d, new List<RadioactiveSubstance> { new BetaParticle(1, 4053600.0), new Erbium164() } },

        };
    }
}
    
    