using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cerium132m : RadioactiveSubstance
    {
        public override string name { get; } = "Cerium132m";
        public override double halfLife { get; } = 0.0094d;
        public override double atomicWeight { get; } = 131.91398d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00053, 2341000.0), new Cerium132() } },

        };
    }
}
    
    