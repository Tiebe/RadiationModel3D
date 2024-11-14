using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cerium121 : RadioactiveSubstance
    {
        public override string name { get; } = "Cerium121";
        public override double halfLife { get; } = 1.1d;
        public override double atomicWeight { get; } = 120.94343d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 9500000.0), new Lanthanum121() } },

        };
    }
}
    
    