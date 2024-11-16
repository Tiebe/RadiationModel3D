using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lead198 : RadioactiveSubstance
    {
        public override string name { get; } = "Lead198";
        public override double halfLife { get; } = 8640.0d;
        public override double atomicWeight { get; } = 197.97202d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 1462000.0), new Thallium198() } },

        };
    }
}
    
    