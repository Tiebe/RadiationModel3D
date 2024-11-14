using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iodine111 : RadioactiveSubstance
    {
        public override string name { get; } = "Iodine111";
        public override double halfLife { get; } = 2.5d;
        public override double atomicWeight { get; } = 110.93027d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 8633000.0), new Tellurium111() } },
            { 0.0008799999999999999d, new List<RadioactiveSubstance> { new AlphaParticle(4294047.4), new Antimony107() } },

        };
    }
}
    
    