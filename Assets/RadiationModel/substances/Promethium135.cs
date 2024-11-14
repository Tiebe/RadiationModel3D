using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Promethium135 : RadioactiveSubstance
    {
        public override string name { get; } = "Promethium135";
        public override double halfLife { get; } = 49.0d;
        public override double atomicWeight { get; } = 134.92479d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 6154000.0), new Neodymium135() } },

        };
    }
}
    
    