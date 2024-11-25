using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Palladium112 : RadioactiveSubstance
    {
        public override string name { get; } = "Palladium112";
        public override double halfLife { get; } = 75744.0d;
        public override double atomicWeight { get; } = 111.90733d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Silver112() }, { 1.0d, new BetaParticle(-1, 131350.0) }, { 0.27d, new GammaParticle(18500.0, 0.06702) }, { 0.03494502d, new GammaParticle(3218.0, 0.38528) } } },

        };
    }
}
    