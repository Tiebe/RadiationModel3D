using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rubidium102 : RadioactiveSubstance
    {
        public override string name { get; } = "Rubidium102";
        public override double halfLife { get; } = 0.037d;
        public override double atomicWeight { get; } = 101.96001d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 14910000.0), new Strontium102() } },

        };
    }
}
    
    