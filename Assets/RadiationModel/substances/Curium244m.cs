using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Curium244m : RadioactiveSubstance
    {
        public override string name { get; } = "Curium244m";
        public override double halfLife { get; } = 0.034d;
        public override double atomicWeight { get; } = 244.06387d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00119), new Curium244() } },

        };
    }
}
    
    