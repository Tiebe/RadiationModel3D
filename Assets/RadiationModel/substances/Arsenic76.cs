
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Arsenic76 : RadioactiveSubstance
    {
        public override string name { get; } = "Arsenic76";
        public override double halfLife { get; } = 94461.12d;
        public override double atomicWeight { get; } = 75.92239d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Selenium76() } },

        };
    }
}
    
    