using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Boron17 : RadioactiveSubstance
    {
        public override string name { get; } = "Boron17";
        public override double halfLife { get; } = 0.00508d;
        public override double atomicWeight { get; } = 17.04694d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 22688000.0), new Carbon17() } },

        };
    }
}
    
    