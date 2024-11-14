using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Niobium109 : RadioactiveSubstance
    {
        public override string name { get; } = "Niobium109";
        public override double halfLife { get; } = 0.1069d;
        public override double atomicWeight { get; } = 108.93914d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 9969000.0), new Molybdenum109() } },

        };
    }
}
    
    