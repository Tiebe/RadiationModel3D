using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Californium251m : RadioactiveSubstance
    {
        public override string name { get; } = "Californium251m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 251.07998d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((370000.0, 0.00335)), new Californium251() } },

        };
    }
}
    
    