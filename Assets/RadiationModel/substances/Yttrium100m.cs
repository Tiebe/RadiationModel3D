
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Yttrium100m : RadioactiveSubstance
    {
        public override string name { get; } = "Yttrium100m";
        public override double halfLife { get; } = 0.727d;
        public override double atomicWeight { get; } = 99.92788d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Zirconium100() } },

        };
    }
}
    
    