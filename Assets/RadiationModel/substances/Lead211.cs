using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lead211 : RadioactiveSubstance
    {
        public override string name { get; } = "Lead211";
        public override double halfLife { get; } = 2169.768d;
        public override double atomicWeight { get; } = 210.98874d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 1366000.0), new Bismuth211() } },

        };
    }
}
    
    