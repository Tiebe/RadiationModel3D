using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhenium180 : RadioactiveSubstance
    {
        public override string name { get; } = "Rhenium180";
        public override double halfLife { get; } = 147.6d;
        public override double atomicWeight { get; } = 179.95079d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 3799200.0), new Tungsten180() } },

        };
    }
}
    
    