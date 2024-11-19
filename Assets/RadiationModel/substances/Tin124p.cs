using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tin124p : RadioactiveSubstance
    {
        public override string name { get; } = "Tin124p";
        public override double halfLife { get; } = 5e-05d;
        public override double atomicWeight { get; } = 123.90813d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00047, 2656600.0), new Tin124() } },

        };
    }
}
    
    