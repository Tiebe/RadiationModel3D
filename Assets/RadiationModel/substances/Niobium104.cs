using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Niobium104 : RadioactiveSubstance
    {
        public override string name { get; } = "Niobium104";
        public override double halfLife { get; } = 0.98d;
        public override double atomicWeight { get; } = 103.92291d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 8533000.0), new Molybdenum104() } },

        };
    }
}
    
    