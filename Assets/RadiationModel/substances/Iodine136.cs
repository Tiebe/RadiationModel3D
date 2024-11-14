using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iodine136 : RadioactiveSubstance
    {
        public override string name { get; } = "Iodine136";
        public override double halfLife { get; } = 83.4d;
        public override double atomicWeight { get; } = 135.9146d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 6884170.0), new Xenon136() } },

        };
    }
}
    
    