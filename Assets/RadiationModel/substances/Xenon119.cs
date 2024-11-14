using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Xenon119 : RadioactiveSubstance
    {
        public override string name { get; } = "Xenon119";
        public override double halfLife { get; } = 348.0d;
        public override double atomicWeight { get; } = 118.91541d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 4984000.0), new Iodine119() } },
            { 0.79d, new List<RadioactiveSubstance> { new BetaParticle(1, 4984000.0), new Iodine119() } },
            { 0.21d, new List<RadioactiveSubstance> { new Iodine119() } },

        };
    }
}
    
    