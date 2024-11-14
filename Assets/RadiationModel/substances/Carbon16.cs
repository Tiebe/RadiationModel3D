using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Carbon16 : RadioactiveSubstance
    {
        public override string name { get; } = "Carbon16";
        public override double halfLife { get; } = 0.75d;
        public override double atomicWeight { get; } = 16.0147d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 8010100.0), new Nitrogen16() } },

        };
    }
}
    
    