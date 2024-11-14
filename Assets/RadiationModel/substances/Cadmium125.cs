using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cadmium125 : RadioactiveSubstance
    {
        public override string name { get; } = "Cadmium125";
        public override double halfLife { get; } = 0.68d;
        public override double atomicWeight { get; } = 124.92126d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 7064200.0), new Indium125() } },

        };
    }
}
    
    