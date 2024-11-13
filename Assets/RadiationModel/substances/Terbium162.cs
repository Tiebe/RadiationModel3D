
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Terbium162 : RadioactiveSubstance
    {
        public override string name { get; } = "Terbium162";
        public override double halfLife { get; } = 456.0d;
        public override double atomicWeight { get; } = 161.92928d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Dysprosium162() } },

        };
    }
}
    
    