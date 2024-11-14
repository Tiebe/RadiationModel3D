using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Indium114m : RadioactiveSubstance
    {
        public override string name { get; } = "Indium114m";
        public override double halfLife { get; } = 4277664.0d;
        public override double atomicWeight { get; } = 113.90512d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9675d, new List<RadioactiveSubstance> { new GammaParticle(0.00652), new Indium114() } },
            { 0.0325d, new List<RadioactiveSubstance> { new BetaParticle(1, 1635430.0), new Cadmium114() } },

        };
    }
}
    
    