using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Yttrium88m : RadioactiveSubstance
    {
        public override string name { get; } = "Yttrium88m";
        public override double halfLife { get; } = 0.0003d;
        public override double atomicWeight { get; } = 87.90992d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00316), new Yttrium88() } },

        };
    }
}
    
    