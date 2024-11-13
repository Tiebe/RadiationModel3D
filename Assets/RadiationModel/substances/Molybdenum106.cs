
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Molybdenum106 : RadioactiveSubstance
    {
        public override string name { get; } = "Molybdenum106";
        public override double halfLife { get; } = 8.73d;
        public override double atomicWeight { get; } = 105.91827d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Technetium106() } },

        };
    }
}
    
    