using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Arsenic80 : RadioactiveSubstance
    {
        public override string name { get; } = "Arsenic80";
        public override double halfLife { get; } = 15.2d;
        public override double atomicWeight { get; } = 79.92247d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 5544500.0), new Selenium80() } },

        };
    }
}
    
    