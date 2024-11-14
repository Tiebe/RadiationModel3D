using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Carbon9 : RadioactiveSubstance
    {
        public override string name { get; } = "Carbon9";
        public override double halfLife { get; } = 0.1265d;
        public override double atomicWeight { get; } = 9.03104d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 16494500.0), new Boron9() } },

        };
    }
}
    
    