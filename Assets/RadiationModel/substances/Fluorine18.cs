using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Fluorine18 : RadioactiveSubstance
    {
        public override string name { get; } = "Fluorine18";
        public override double halfLife { get; } = 6586.2d;
        public override double atomicWeight { get; } = 18.00094d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Nitrogen18() }, { 1.0d, new BetaParticle(1, -6119950.0) }, { 1.9346d, new GammaParticle(511000.0, 0.00243) } } },

        };
    }
}
    