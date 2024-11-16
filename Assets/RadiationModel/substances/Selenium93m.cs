using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Selenium93m : RadioactiveSubstance
    {
        public override string name { get; } = "Selenium93m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 92.95686d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00182), new Selenium93() } },

        };
    }
}
    
    