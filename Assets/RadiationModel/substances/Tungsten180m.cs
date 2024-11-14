using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tungsten180m : RadioactiveSubstance
    {
        public override string name { get; } = "Tungsten180m";
        public override double halfLife { get; } = 0.00547d;
        public override double atomicWeight { get; } = 179.94835d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00081), new Tungsten180() } },

        };
    }
}
    
    