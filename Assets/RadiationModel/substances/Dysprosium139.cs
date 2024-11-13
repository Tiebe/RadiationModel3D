
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Dysprosium139 : RadioactiveSubstance
    {
        public override string name { get; } = "Dysprosium139";
        public override double halfLife { get; } = 0.6d;
        public override double atomicWeight { get; } = 138.95953d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Terbium139() } },

        };
    }
}
    
    