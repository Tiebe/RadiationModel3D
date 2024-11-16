using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhodium107 : RadioactiveSubstance
    {
        public override string name { get; } = "Rhodium107";
        public override double halfLife { get; } = 1302.0d;
        public override double atomicWeight { get; } = 106.90675d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 1508700.0), new Palladium107() } },

        };
    }
}
    
    