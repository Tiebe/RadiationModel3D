using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Oxygen24 : RadioactiveSubstance
    {
        public override string name { get; } = "Oxygen24";
        public override double halfLife { get; } = 0.0774d;
        public override double atomicWeight { get; } = 24.01986d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 10960000.0), new Fluorine24() } },

        };
    }
}
    
    