using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Nickel68n : RadioactiveSubstance
    {
        public override string name { get; } = "Nickel68n";
        public override double halfLife { get; } = 0.00085d;
        public override double atomicWeight { get; } = 67.93493d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00044), new Nickel68() } },

        };
    }
}
    
    