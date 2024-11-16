using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tellurium114 : RadioactiveSubstance
    {
        public override string name { get; } = "Tellurium114";
        public override double halfLife { get; } = 912.0d;
        public override double atomicWeight { get; } = 113.91209d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 2607000.0), new Antimony114() } },

        };
    }
}
    
    