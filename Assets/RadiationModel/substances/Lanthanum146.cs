using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lanthanum146 : RadioactiveSubstance
    {
        public override string name { get; } = "Lanthanum146";
        public override double halfLife { get; } = 9.9d;
        public override double atomicWeight { get; } = 145.92569d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 6404800.0), new Cerium146() } },

        };
    }
}
    
    