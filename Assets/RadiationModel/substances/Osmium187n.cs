using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Osmium187n : RadioactiveSubstance
    {
        public override string name { get; } = "Osmium187n";
        public override double halfLife { get; } = 0.00023d;
        public override double atomicWeight { get; } = 186.95603d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00482), new Osmium187() } },

        };
    }
}
    
    