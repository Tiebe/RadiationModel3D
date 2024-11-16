using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lanthanum155 : RadioactiveSubstance
    {
        public override string name { get; } = "Lanthanum155";
        public override double halfLife { get; } = 0.101d;
        public override double atomicWeight { get; } = 154.95928d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 9850000.0), new Cerium155() } },

        };
    }
}
    
    