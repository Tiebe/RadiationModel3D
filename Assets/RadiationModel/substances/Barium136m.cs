using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Barium136m : RadioactiveSubstance
    {
        public override string name { get; } = "Barium136m";
        public override double halfLife { get; } = 0.3084d;
        public override double atomicWeight { get; } = 135.90676d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00061, 2030530.0), new Barium136() } },

        };
    }
}
    
    