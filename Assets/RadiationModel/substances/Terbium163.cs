using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Terbium163 : RadioactiveSubstance
    {
        public override string name { get; } = "Terbium163";
        public override double halfLife { get; } = 1170.0d;
        public override double atomicWeight { get; } = 162.93065d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 1784900.0), new Dysprosium163() } },

        };
    }
}
    
    