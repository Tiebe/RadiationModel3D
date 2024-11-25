using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Platinum197 : RadioactiveSubstance
    {
        public override string name { get; } = "Platinum197";
        public override double halfLife { get; } = 71609.4d;
        public override double atomicWeight { get; } = 196.96734d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Gold197() }, { 1.0d, new BetaParticle(-1, 360000.0) }, { 0.17204999999999998d, new GammaParticle(77350.0, 0.01603) }, { 0.037000000000000005d, new GammaParticle(191437.0, 0.00648) }, { 0.002331d, new GammaParticle(268780.0, 0.00461) }, { 0.20156155802529038d, new GammaParticle(11419.0, 0.10858) }, { 0.00997824852174928d, new GammaParticle(66991.0, 0.01851) }, { 0.016987144231782905d, new GammaParticle(68806.0, 0.01802) }, { 0.005731976427050286d, new GammaParticle(78048.0, 0.01589) }, { 0.007388517614467818d, new GammaParticle(78983.0, 0.0157) }, { 0.0016565411874175325d, new GammaParticle(80133.0, 0.01547) } } },

        };
    }
}
    