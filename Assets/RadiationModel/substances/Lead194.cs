using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lead194 : RadioactiveSubstance
    {
        public override string name { get; } = "Lead194";
        public override double halfLife { get; } = 642.0d;
        public override double atomicWeight { get; } = 193.97401d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 2729000.0), new Thallium194() } },
            { 7.3e-08d, new List<RadioactiveSubstance> { new AlphaParticle(5760002.09), new Mercury190() } },

        };
    }
}
    
    