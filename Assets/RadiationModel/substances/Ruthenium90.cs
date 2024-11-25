using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Ruthenium90 : RadioactiveSubstance
    {
        public override string name { get; } = "Ruthenium90";
        public override double halfLife { get; } = 11.7d;
        public override double atomicWeight { get; } = 89.93034d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Molybdenum90() }, { 1.0d, new BetaParticle(1, 7644500.0) }, { 0.42d, new GammaParticle(154600.0, 0.00802) }, { 0.0882d, new GammaParticle(492800.0, 0.00252) }, { 1.96d, new GammaParticle(511000.0, 0.00243) }, { 0.0011717337337d, new GammaParticle(2586.0, 0.47944) }, { 0.00557841373325225d, new GammaParticle(18250.0, 0.06794) }, { 0.010607365912249953d, new GammaParticle(18367.0, 0.0675) }, { 0.002819232948616404d, new GammaParticle(20695.0, 0.05991) }, { 0.0032646717544977948d, new GammaParticle(20820.0, 0.05955) }, { 0.00044543880588139177d, new GammaParticle(21003.0, 0.05903) } } },

        };
    }
}
    