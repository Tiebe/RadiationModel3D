using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Molybdenum101 : RadioactiveSubstance
    {
        public override string name { get; } = "Molybdenum101";
        public override double halfLife { get; } = 876.6d;
        public override double atomicWeight { get; } = 100.91034d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 2825000.0), new Technetium101() } },

        };
    }
}
    
    