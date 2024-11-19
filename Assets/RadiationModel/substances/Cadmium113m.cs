using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cadmium113m : RadioactiveSubstance
    {
        public override string name { get; } = "Cadmium113m";
        public override double halfLife { get; } = 438326063.28d;
        public override double atomicWeight { get; } = 112.90469d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9990359999999999d, new List<RadioactiveSubstance> { new BetaParticle(-1, 587370.0), new Indium113() } },
            { 0.000964d, new List<RadioactiveSubstance> { new GammaParticle(0.0047, 263540.0), new Cadmium113() } },

        };
    }
}
    
    