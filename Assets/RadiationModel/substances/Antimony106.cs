using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Antimony106 : RadioactiveSubstance
    {
        public override string name { get; } = "Antimony106";
        public override double halfLife { get; } = 0.6d;
        public override double atomicWeight { get; } = 105.92864d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 10881000.0), new Tin106() } },

        };
    }
}
    
    