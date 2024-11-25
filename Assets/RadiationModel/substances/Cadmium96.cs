using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cadmium96 : RadioactiveSubstance
    {
        public override string name { get; } = "Cadmium96";
        public override double halfLife { get; } = 1.03d;
        public override double atomicWeight { get; } = 95.94034d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Palladium96() }, { 1.0d, new BetaParticle(1, 10306500.0) } } },

        };
    }
}
    