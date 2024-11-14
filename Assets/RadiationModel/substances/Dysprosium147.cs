using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Dysprosium147 : RadioactiveSubstance
    {
        public override string name { get; } = "Dysprosium147";
        public override double halfLife { get; } = 67.0d;
        public override double atomicWeight { get; } = 146.93108d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 6547000.0), new Terbium147() } },

        };
    }
}
    
    