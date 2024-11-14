using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Osmium182m : RadioactiveSubstance
    {
        public override string name { get; } = "Osmium182m";
        public override double halfLife { get; } = 0.00078d;
        public override double atomicWeight { get; } = 181.95408d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00068), new Osmium182() } },

        };
    }
}
    
    