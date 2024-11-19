using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Praseodymium151m : RadioactiveSubstance
    {
        public override string name { get; } = "Praseodymium151m";
        public override double halfLife { get; } = 5e-05d;
        public override double atomicWeight { get; } = 150.92835d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.03542, 35000.0), new Praseodymium151() } },

        };
    }
}
    
    