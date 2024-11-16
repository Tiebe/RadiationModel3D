using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Sulfur38 : RadioactiveSubstance
    {
        public override string name { get; } = "Sulfur38";
        public override double halfLife { get; } = 10218.0d;
        public override double atomicWeight { get; } = 37.97116d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 2937120.0), new Chlorine38() } },

        };
    }
}
    
    