using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Antimony126p : RadioactiveSubstance
    {
        public override string name { get; } = "Antimony126p";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 125.90736d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((100000.0, 0.0124)), new Antimony126() } },

        };
    }
}
    
    