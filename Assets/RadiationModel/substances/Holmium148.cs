using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Holmium148 : RadioactiveSubstance
    {
        public override string name { get; } = "Holmium148";
        public override double halfLife { get; } = 2.2d;
        public override double atomicWeight { get; } = 147.93775d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 9869000.0), new Dysprosium148() } },

        };
    }
}
    
    