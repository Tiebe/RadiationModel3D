
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Neon30 : RadioactiveSubstance
    {
        public override string name { get; } = "Neon30";
        public override double halfLife { get; } = 0.00722d;
        public override double atomicWeight { get; } = 30.02499d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Sodium30() } },

        };
    }
}
    
    