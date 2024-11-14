using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Molybdenum115 : RadioactiveSubstance
    {
        public override string name { get; } = "Molybdenum115";
        public override double halfLife { get; } = 0.0455d;
        public override double atomicWeight { get; } = 114.95217d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 11250000.0), new Technetium115() } },

        };
    }
}
    
    