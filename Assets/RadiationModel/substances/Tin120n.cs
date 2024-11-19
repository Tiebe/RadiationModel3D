using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tin120n : RadioactiveSubstance
    {
        public override string name { get; } = "Tin120n";
        public override double halfLife { get; } = 1e-05d;
        public override double atomicWeight { get; } = 119.90532d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00043, 2902200.0), new Tin120() } },

        };
    }
}
    
    