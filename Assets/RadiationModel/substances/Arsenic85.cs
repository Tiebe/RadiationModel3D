using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Arsenic85 : RadioactiveSubstance
    {
        public override string name { get; } = "Arsenic85";
        public override double halfLife { get; } = 2.022d;
        public override double atomicWeight { get; } = 84.93216d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 9224600.0), new Selenium85() } },

        };
    }
}
    
    