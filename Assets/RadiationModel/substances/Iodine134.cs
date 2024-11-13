
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iodine134 : RadioactiveSubstance
    {
        public override string name { get; } = "Iodine134";
        public override double halfLife { get; } = 3150.0d;
        public override double atomicWeight { get; } = 133.90978d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Xenon134() } },

        };
    }
}
    
    