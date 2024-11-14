using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Terbium169 : RadioactiveSubstance
    {
        public override string name { get; } = "Terbium169";
        public override double halfLife { get; } = 5.13d;
        public override double atomicWeight { get; } = 168.94581d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 5120000.0), new Dysprosium169() } },

        };
    }
}
    
    