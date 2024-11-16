using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lead192 : RadioactiveSubstance
    {
        public override string name { get; } = "Lead192";
        public override double halfLife { get; } = 210.0d;
        public override double atomicWeight { get; } = 191.97579d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 3318000.0), new Thallium192() } },
            { 5.9e-05d, new List<RadioactiveSubstance> { new AlphaParticle(6241047.4), new Mercury188() } },

        };
    }
}
    
    