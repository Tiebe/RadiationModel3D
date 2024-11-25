using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Nickel54m : RadioactiveSubstance
    {
        public override string name { get; } = "Nickel54m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 53.96477d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.64d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Nickel54() }, { 0.53504d, new GammaParticle(146100.0, 0.00849) }, { 0.032639999999999995d, new GammaParticle(3386200.0, 0.00037) }, { 0.0008076830737210368d, new GammaParticle(874.0, 1.41858) }, { 0.00806228965196241d, new GammaParticle(7461.0, 0.16618) }, { 0.01573436700226856d, new GammaParticle(7478.0, 0.1658) }, { 0.003279179286953028d, new GammaParticle(8296.0, 0.14945) }, { 0.003279179286953028d, new GammaParticle(8296.0, 0.14945) } } },
            { 0.36d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Cobalt53() }, { 1.0d, new ProtonParticle() } } },

        };
    }
}
    