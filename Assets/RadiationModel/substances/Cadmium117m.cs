using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cadmium117m : RadioactiveSubstance
    {
        public override string name { get; } = "Cadmium117m";
        public override double halfLife { get; } = 12387.6d;
        public override double atomicWeight { get; } = 116.90737d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 2661000.0), new Indium117() } },

        };
    }
}
    
    