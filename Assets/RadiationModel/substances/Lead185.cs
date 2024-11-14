using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lead185 : RadioactiveSubstance
    {
        public override string name { get; } = "Lead185";
        public override double halfLife { get; } = 6.3d;
        public override double atomicWeight { get; } = 184.98761d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.66d, new List<RadioactiveSubstance> { new BetaParticle(1, 8217000.0), new Thallium185() } },
            { 0.34d, new List<RadioactiveSubstance> { new AlphaParticle(7715047.4), new Mercury181() } },

        };
    }
}
    
    