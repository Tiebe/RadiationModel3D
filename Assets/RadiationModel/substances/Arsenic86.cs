using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Arsenic86 : RadioactiveSubstance
    {
        public override string name { get; } = "Arsenic86";
        public override double halfLife { get; } = 0.945d;
        public override double atomicWeight { get; } = 85.9367d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 11541200.0), new Selenium86() } },

        };
    }
}
    
    