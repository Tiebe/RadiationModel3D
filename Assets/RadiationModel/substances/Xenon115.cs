using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Xenon115 : RadioactiveSubstance
    {
        public override string name { get; } = "Xenon115";
        public override double halfLife { get; } = 18.0d;
        public override double atomicWeight { get; } = 114.92629d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 7681000.0), new Iodine115() } },

        };
    }
}
    
    