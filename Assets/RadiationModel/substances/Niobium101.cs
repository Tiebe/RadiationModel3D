using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Niobium101 : RadioactiveSubstance
    {
        public override string name { get; } = "Niobium101";
        public override double halfLife { get; } = 7.1d;
        public override double atomicWeight { get; } = 100.91531d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 4629000.0), new Molybdenum101() } },

        };
    }
}
    
    