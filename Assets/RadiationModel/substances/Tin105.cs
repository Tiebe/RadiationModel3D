using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tin105 : RadioactiveSubstance
    {
        public override string name { get; } = "Tin105";
        public override double halfLife { get; } = 32.7d;
        public override double atomicWeight { get; } = 104.92127d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 6303000.0), new Indium105() } },

        };
    }
}
    
    