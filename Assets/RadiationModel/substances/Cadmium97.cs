using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cadmium97 : RadioactiveSubstance
    {
        public override string name { get; } = "Cadmium97";
        public override double halfLife { get; } = 1.16d;
        public override double atomicWeight { get; } = 96.9348d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 10174000.0), new Silver97() } },

        };
    }
}
    
    