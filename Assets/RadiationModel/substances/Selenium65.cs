
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Selenium65 : RadioactiveSubstance
    {
        public override string name { get; } = "Selenium65";
        public override double halfLife { get; } = 0.0342d;
        public override double atomicWeight { get; } = 64.96455d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Arsenic65() } },

        };
    }
}
    
    