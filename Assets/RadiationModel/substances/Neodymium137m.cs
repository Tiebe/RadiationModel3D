using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Neodymium137m : RadioactiveSubstance
    {
        public override string name { get; } = "Neodymium137m";
        public override double halfLife { get; } = 1.6d;
        public override double atomicWeight { get; } = 136.91512d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((519000.0, 0.00239)), new Neodymium137() } },

        };
    }
}
    
    