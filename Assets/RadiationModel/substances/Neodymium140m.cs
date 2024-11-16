using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Neodymium140m : RadioactiveSubstance
    {
        public override string name { get; } = "Neodymium140m";
        public override double halfLife { get; } = 0.0006d;
        public override double atomicWeight { get; } = 139.91193d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00056), new Neodymium140() } },

        };
    }
}
    
    