using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Selenium92m : RadioactiveSubstance
    {
        public override string name { get; } = "Selenium92m";
        public override double halfLife { get; } = 2e-05d;
        public override double atomicWeight { get; } = 91.95193d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00064), new Selenium92() } },

        };
    }
}
    
    