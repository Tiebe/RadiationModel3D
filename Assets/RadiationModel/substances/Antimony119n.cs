using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Antimony119n : RadioactiveSubstance
    {
        public override string name { get; } = "Antimony119n";
        public override double halfLife { get; } = 0.835d;
        public override double atomicWeight { get; } = 118.90699d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00044, 2842000.0), new Antimony119() } },

        };
    }
}
    
    