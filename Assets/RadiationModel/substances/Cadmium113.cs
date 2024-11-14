using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cadmium113 : RadioactiveSubstance
    {
        public override string name { get; } = "Cadmium113";
        public override double halfLife { get; } = 2.5371789407999997e+23d;
        public override double atomicWeight { get; } = 112.90441d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 323830.0), new Indium113() } },

        };
    }
}
    
    