using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lead191m : RadioactiveSubstance
    {
        public override string name { get; } = "Lead191m";
        public override double halfLife { get; } = 130.8d;
        public override double atomicWeight { get; } = 190.97828d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 6049000.0), new Thallium191() } },
            { 0.0002d, new List<RadioactiveSubstance> { new AlphaParticle(6482002.09), new Mercury187() } },

        };
    }
}
    
    