using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Fermium244 : RadioactiveSubstance
    {
        public override string name { get; } = "Fermium244";
        public override double halfLife { get; } = 0.00312d;
        public override double atomicWeight { get; } = 244.07403d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.97d, new List<RadioactiveSubstance> {  } },
            { 0.02d, new List<RadioactiveSubstance> { new BetaParticle(1, 2930000.0), new Einsteinium244() } },
            { 0.01d, new List<RadioactiveSubstance> { new AlphaParticle(9568002.09), new Californium240() } },

        };
    }
}
    
    