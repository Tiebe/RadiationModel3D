using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Neon17 : RadioactiveSubstance
    {
        public override string name { get; } = "Neon17";
        public override double halfLife { get; } = 0.1092d;
        public override double atomicWeight { get; } = 17.01771d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Oxygen17() }, { 1.0d, new BetaParticle(1, 8654632.1) }, { 0.0161d, new GammaParticle(495000.0, 0.0025) }, { 0.00021d, new GammaParticle(10695000.0, 0.00012) }, { 1.9945220000000001d, new GammaParticle(511000.0, 0.00243) } } },
            { 0.9520000000000001d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Oxygen16() }, { 1.0d, new ProtonParticle() } } },
            { 0.0277d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Nitrogen13() }, { 1.0d, new AlphaParticle(9752022.09) } } },

        };
    }
}
    