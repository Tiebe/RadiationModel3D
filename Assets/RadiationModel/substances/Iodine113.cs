using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iodine113 : RadioactiveSubstance
    {
        public override string name { get; } = "Iodine113";
        public override double halfLife { get; } = 6.6d;
        public override double atomicWeight { get; } = 112.92365d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 7227000.0), new Tellurium113() } },
            { 3.31e-07d, new List<RadioactiveSubstance> { new AlphaParticle(3726047.4), new Antimony109() } },

        };
    }
}
    
    