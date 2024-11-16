using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Yttrium93m : RadioactiveSubstance
    {
        public override string name { get; } = "Yttrium93m";
        public override double halfLife { get; } = 0.82d;
        public override double atomicWeight { get; } = 92.91039d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00163), new Yttrium93() } },

        };
    }
}
    
    