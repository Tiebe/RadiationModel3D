using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Dysprosium169 : RadioactiveSubstance
    {
        public override string name { get; } = "Dysprosium169";
        public override double halfLife { get; } = 39.0d;
        public override double atomicWeight { get; } = 168.94031d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 3196000.0), new Holmium169() } },

        };
    }
}
    
    