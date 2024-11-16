using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Molybdenum102 : RadioactiveSubstance
    {
        public override string name { get; } = "Molybdenum102";
        public override double halfLife { get; } = 678.0d;
        public override double atomicWeight { get; } = 101.91029d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 1012000.0), new Technetium102() } },

        };
    }
}
    
    