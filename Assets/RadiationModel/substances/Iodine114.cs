using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iodine114 : RadioactiveSubstance
    {
        public override string name { get; } = "Iodine114";
        public override double halfLife { get; } = 2.01d;
        public override double atomicWeight { get; } = 113.92202d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 9251000.0), new Tellurium114() } },
            { 7.699999999999999e-11d, new List<RadioactiveSubstance> { new AlphaParticle(3406047.4), new Antimony110() } },

        };
    }
}
    
    