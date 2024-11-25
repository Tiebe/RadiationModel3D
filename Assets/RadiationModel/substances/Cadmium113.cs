using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cadmium113 : RadioactiveSubstance
    {
        public override string name { get; } = "Cadmium113";
        public override double halfLife { get; } = 2.5371768483571968e+23d;
        public override double atomicWeight { get; } = 112.90441d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Indium113() }, { 1.0d, new BetaParticle(-1, 161915.0) } } },

        };
    }
}
    