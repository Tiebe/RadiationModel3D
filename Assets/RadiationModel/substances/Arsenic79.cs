using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Arsenic79 : RadioactiveSubstance
    {
        public override string name { get; } = "Arsenic79";
        public override double halfLife { get; } = 540.6d;
        public override double atomicWeight { get; } = 78.92095d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 2281470.0), new Selenium79() } },

        };
    }
}
    
    