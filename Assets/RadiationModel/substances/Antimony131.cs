using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Antimony131 : RadioactiveSubstance
    {
        public override string name { get; } = "Antimony131";
        public override double halfLife { get; } = 1381.8d;
        public override double atomicWeight { get; } = 130.91199d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 3229620.0), new Tellurium131() } },

        };
    }
}
    
    