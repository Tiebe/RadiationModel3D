using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Phosphorus35 : RadioactiveSubstance
    {
        public override string name { get; } = "Phosphorus35";
        public override double halfLife { get; } = 47.3d;
        public override double atomicWeight { get; } = 34.97331d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 3988410.0), new Sulfur35() } },

        };
    }
}
    
    