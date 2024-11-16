using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Xenon114 : RadioactiveSubstance
    {
        public override string name { get; } = "Xenon114";
        public override double halfLife { get; } = 10.0d;
        public override double atomicWeight { get; } = 113.92798d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 5553000.0), new Iodine114() } },

        };
    }
}
    
    