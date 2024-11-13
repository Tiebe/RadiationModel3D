
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Xenon132m : RadioactiveSubstance
    {
        public override string name { get; } = "Xenon132m";
        public override double halfLife { get; } = 0.00839d;
        public override double atomicWeight { get; } = 131.90711d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(), new Xenon132() } },

        };
    }
}
    
    