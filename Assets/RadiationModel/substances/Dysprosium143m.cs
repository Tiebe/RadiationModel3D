
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Dysprosium143m : RadioactiveSubstance
    {
        public override string name { get; } = "Dysprosium143m";
        public override double halfLife { get; } = 3.0d;
        public override double atomicWeight { get; } = 142.94433d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Terbium143() } },

        };
    }
}
    
    