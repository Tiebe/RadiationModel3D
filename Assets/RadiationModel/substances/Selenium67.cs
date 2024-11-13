
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Selenium67 : RadioactiveSubstance
    {
        public override string name { get; } = "Selenium67";
        public override double halfLife { get; } = 0.133d;
        public override double atomicWeight { get; } = 66.94999d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Arsenic67() } },

        };
    }
}
    
    