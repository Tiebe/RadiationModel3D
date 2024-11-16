using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Ruthenium119 : RadioactiveSubstance
    {
        public override string name { get; } = "Ruthenium119";
        public override double halfLife { get; } = 0.0695d;
        public override double atomicWeight { get; } = 118.94409d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 10743000.0), new Rhodium119() } },

        };
    }
}
    
    