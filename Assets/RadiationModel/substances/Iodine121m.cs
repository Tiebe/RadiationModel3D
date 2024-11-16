using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iodine121m : RadioactiveSubstance
    {
        public override string name { get; } = "Iodine121m";
        public override double halfLife { get; } = 1e-05d;
        public override double atomicWeight { get; } = 120.90996d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00052), new Iodine121() } },

        };
    }
}
    
    