using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Molybdenum91 : RadioactiveSubstance
    {
        public override string name { get; } = "Molybdenum91";
        public override double halfLife { get; } = 929.4d;
        public override double atomicWeight { get; } = 90.91175d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 4429000.0), new Niobium91() } },

        };
    }
}
    
    