using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Phosphorus38 : RadioactiveSubstance
    {
        public override string name { get; } = "Phosphorus38";
        public override double halfLife { get; } = 0.64d;
        public override double atomicWeight { get; } = 37.9843d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 12241000.0), new Sulfur38() } },

        };
    }
}
    
    