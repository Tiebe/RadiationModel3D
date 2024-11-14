using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Phosphorus32 : RadioactiveSubstance
    {
        public override string name { get; } = "Phosphorus32";
        public override double halfLife { get; } = 1232841.6d;
        public override double atomicWeight { get; } = 31.97391d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 1710657.0999999999), new Sulfur32() } },

        };
    }
}
    
    