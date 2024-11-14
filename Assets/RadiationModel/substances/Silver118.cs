using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Silver118 : RadioactiveSubstance
    {
        public override string name { get; } = "Silver118";
        public override double halfLife { get; } = 3.76d;
        public override double atomicWeight { get; } = 117.9146d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 7148200.0), new Cadmium118() } },

        };
    }
}
    
    