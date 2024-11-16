using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Molybdenum104 : RadioactiveSubstance
    {
        public override string name { get; } = "Molybdenum104";
        public override double halfLife { get; } = 60.0d;
        public override double atomicWeight { get; } = 103.91375d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 2155000.0), new Technetium104() } },

        };
    }
}
    
    