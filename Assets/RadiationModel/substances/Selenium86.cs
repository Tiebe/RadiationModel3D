using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Selenium86 : RadioactiveSubstance
    {
        public override string name { get; } = "Selenium86";
        public override double halfLife { get; } = 14.3d;
        public override double atomicWeight { get; } = 85.92431d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 5128800.0), new Bromine86() } },

        };
    }
}
    
    