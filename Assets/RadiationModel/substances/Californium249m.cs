using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Californium249m : RadioactiveSubstance
    {
        public override string name { get; } = "Californium249m";
        public override double halfLife { get; } = 5e-05d;
        public override double atomicWeight { get; } = 249.07501d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00855, 145000.0), new Californium249() } },

        };
    }
}
    
    