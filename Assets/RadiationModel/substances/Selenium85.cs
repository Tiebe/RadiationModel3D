using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Selenium85 : RadioactiveSubstance
    {
        public override string name { get; } = "Selenium85";
        public override double halfLife { get; } = 32.9d;
        public override double atomicWeight { get; } = 84.92226d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 6161400.0), new Bromine85() } },

        };
    }
}
    
    