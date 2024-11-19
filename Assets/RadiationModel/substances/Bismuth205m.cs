using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bismuth205m : RadioactiveSubstance
    {
        public override string name { get; } = "Bismuth205m";
        public override double halfLife { get; } = 1e-05d;
        public override double atomicWeight { get; } = 204.97899d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00083, 1497000.0), new Bismuth205() } },

        };
    }
}
    
    