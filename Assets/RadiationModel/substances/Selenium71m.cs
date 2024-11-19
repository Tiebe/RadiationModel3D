using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Selenium71m : RadioactiveSubstance
    {
        public override string name { get; } = "Selenium71m";
        public override double halfLife { get; } = 1e-05d;
        public override double atomicWeight { get; } = 70.93226d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.02541, 48800.0), new Selenium71() } },

        };
    }
}
    
    