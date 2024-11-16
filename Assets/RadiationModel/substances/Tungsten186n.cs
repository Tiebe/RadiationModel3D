using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tungsten186n : RadioactiveSubstance
    {
        public override string name { get; } = "Tungsten186n";
        public override double halfLife { get; } = 2.0d;
        public override double atomicWeight { get; } = 185.95817d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00035), new Tungsten186() } },

        };
    }
}
    
    