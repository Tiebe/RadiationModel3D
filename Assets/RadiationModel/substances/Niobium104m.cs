using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Niobium104m : RadioactiveSubstance
    {
        public override string name { get; } = "Niobium104m";
        public override double halfLife { get; } = 4.9d;
        public override double atomicWeight { get; } = 103.92292d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 8542800.0), new Molybdenum104() } },

        };
    }
}
    
    