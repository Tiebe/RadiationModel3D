using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Arsenic83 : RadioactiveSubstance
    {
        public override string name { get; } = "Arsenic83";
        public override double halfLife { get; } = 13.4d;
        public override double atomicWeight { get; } = 82.92521d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 5671700.0), new Selenium83() } },

        };
    }
}
    
    