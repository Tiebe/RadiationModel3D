using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Molybdenum103 : RadioactiveSubstance
    {
        public override string name { get; } = "Molybdenum103";
        public override double halfLife { get; } = 67.5d;
        public override double atomicWeight { get; } = 102.91309d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 3650000.0), new Technetium103() } },

        };
    }
}
    
    