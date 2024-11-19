using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gold198n : RadioactiveSubstance
    {
        public override string name { get; } = "Gold198n";
        public override double halfLife { get; } = 196300.8d;
        public override double atomicWeight { get; } = 197.96912d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00153, 811900.0), new Gold198() } },

        };
    }
}
    
    