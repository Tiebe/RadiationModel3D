using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Oxygen15 : RadioactiveSubstance
    {
        public override string name { get; } = "Oxygen15";
        public override double halfLife { get; } = 122.266d;
        public override double atomicWeight { get; } = 15.00307d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 2754161.9), new Nitrogen15() } },

        };
    }
}
    
    