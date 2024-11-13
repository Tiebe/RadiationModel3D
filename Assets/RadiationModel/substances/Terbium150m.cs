
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Terbium150m : RadioactiveSubstance
    {
        public override string name { get; } = "Terbium150m";
        public override double halfLife { get; } = 348.0d;
        public override double atomicWeight { get; } = 149.92416d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Gadolinium150() } },

        };
    }
}
    
    