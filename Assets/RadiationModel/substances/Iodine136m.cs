
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iodine136m : RadioactiveSubstance
    {
        public override string name { get; } = "Iodine136m";
        public override double halfLife { get; } = 46.6d;
        public override double atomicWeight { get; } = 135.91483d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Xenon136() } },

        };
    }
}
    
    