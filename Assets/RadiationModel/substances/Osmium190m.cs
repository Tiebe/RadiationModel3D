using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Osmium190m : RadioactiveSubstance
    {
        public override string name { get; } = "Osmium190m";
        public override double halfLife { get; } = 591.6d;
        public override double atomicWeight { get; } = 189.96028d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00073, 1705700.0), new Osmium190() } },

        };
    }
}
    
    