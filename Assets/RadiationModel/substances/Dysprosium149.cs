using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Dysprosium149 : RadioactiveSubstance
    {
        public override string name { get; } = "Dysprosium149";
        public override double halfLife { get; } = 252.0d;
        public override double atomicWeight { get; } = 148.92733d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 3795000.0), new Terbium149() } },

        };
    }
}
    
    