using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Indium105 : RadioactiveSubstance
    {
        public override string name { get; } = "Indium105";
        public override double halfLife { get; } = 304.2d;
        public override double atomicWeight { get; } = 104.9145d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 4692800.0), new Cadmium105() } },

        };
    }
}
    
    