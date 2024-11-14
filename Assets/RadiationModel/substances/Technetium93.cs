using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Technetium93 : RadioactiveSubstance
    {
        public override string name { get; } = "Technetium93";
        public override double halfLife { get; } = 9900.0d;
        public override double atomicWeight { get; } = 92.91025d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 3200980.0), new Molybdenum93() } },

        };
    }
}
    
    