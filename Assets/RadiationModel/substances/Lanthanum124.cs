using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lanthanum124 : RadioactiveSubstance
    {
        public override string name { get; } = "Lanthanum124";
        public override double halfLife { get; } = 29.21d;
        public override double atomicWeight { get; } = 123.92457d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 8830000.0), new Barium124() } },

        };
    }
}
    
    