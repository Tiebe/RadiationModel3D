using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Ruthenium101m : RadioactiveSubstance
    {
        public override string name { get; } = "Ruthenium101m";
        public override double halfLife { get; } = 2e-05d;
        public override double atomicWeight { get; } = 100.90614d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00235), new Ruthenium101() } },

        };
    }
}
    
    