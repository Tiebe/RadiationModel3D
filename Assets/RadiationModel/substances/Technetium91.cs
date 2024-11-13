
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Technetium91 : RadioactiveSubstance
    {
        public override string name { get; } = "Technetium91";
        public override double halfLife { get; } = 188.4d;
        public override double atomicWeight { get; } = 90.91842d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Molybdenum91() } },

        };
    }
}
    
    