
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iodine132 : RadioactiveSubstance
    {
        public override string name { get; } = "Iodine132";
        public override double halfLife { get; } = 8262.0d;
        public override double atomicWeight { get; } = 131.90799d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Xenon132() } },

        };
    }
}
    
    