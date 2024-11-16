using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Fermium245 : RadioactiveSubstance
    {
        public override string name { get; } = "Fermium245";
        public override double halfLife { get; } = 4.2d;
        public override double atomicWeight { get; } = 245.07535d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(9455047.4), new Californium241() } },
            { 0.07d, new List<RadioactiveSubstance> { new BetaParticle(1, 3870000.0), new Einsteinium245() } },
            { 0.003d, new List<RadioactiveSubstance> {  } },

        };
    }
}
    
    