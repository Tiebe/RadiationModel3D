using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Osmium185n : RadioactiveSubstance
    {
        public override string name { get; } = "Osmium185n";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 184.95434d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.0045), new Osmium185() } },

        };
    }
}
    
    