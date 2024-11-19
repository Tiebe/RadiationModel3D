using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tin124n : RadioactiveSubstance
    {
        public override string name { get; } = "Tin124n";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 123.90778d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00053, 2325000.0), new Tin124() } },

        };
    }
}
    
    