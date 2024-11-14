using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tungsten171 : RadioactiveSubstance
    {
        public override string name { get; } = "Tungsten171";
        public override double halfLife { get; } = 142.8d;
        public override double atomicWeight { get; } = 170.94945d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 4634000.0), new Tantalum171() } },

        };
    }
}
    
    