using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Antimony133m : RadioactiveSubstance
    {
        public override string name { get; } = "Antimony133m";
        public override double halfLife { get; } = 2e-05d;
        public override double atomicWeight { get; } = 132.92015d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00027), new Antimony133() } },

        };
    }
}
    
    