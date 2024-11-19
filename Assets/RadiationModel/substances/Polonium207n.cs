using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Polonium207n : RadioactiveSubstance
    {
        public override string name { get; } = "Polonium207n";
        public override double halfLife { get; } = 5e-05d;
        public override double atomicWeight { get; } = 206.98279d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((1115000.0, 0.00111)), new Polonium207() } },

        };
    }
}
    
    