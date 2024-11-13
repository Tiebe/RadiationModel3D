
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Fluorine25 : RadioactiveSubstance
    {
        public override string name { get; } = "Fluorine25";
        public override double halfLife { get; } = 0.08d;
        public override double atomicWeight { get; } = 25.01216d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Neon25() } },

        };
    }
}
    
    