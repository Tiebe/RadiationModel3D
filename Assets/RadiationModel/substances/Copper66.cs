using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Copper66 : RadioactiveSubstance
    {
        public override string name { get; } = "Copper66";
        public override double halfLife { get; } = 307.2d;
        public override double atomicWeight { get; } = 65.92887d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Zinc66() }, { 1.0d, new BetaParticle(-1, 1320450.0) }, { 0.00219674d, new GammaParticle(833000.0, 0.00149) }, { 0.09230000000000001d, new GammaParticle(1039200.0, 0.00119) }, { 3.692e-05d, new GammaParticle(1332500.0, 0.00093) }, { 4.615e-06d, new GammaParticle(1872200.0, 0.00066) }, { 3.5599999999999996e-07d, new GammaParticle(1035.0, 1.19791) }, { 3.3399999999999998e-06d, new GammaParticle(8616.0, 0.1439) }, { 6.5e-06d, new GammaParticle(8639.0, 0.14352) }, { 1.3899999999999998e-06d, new GammaParticle(9610.0, 0.12902) }, { 1.3899999999999998e-06d, new GammaParticle(9610.0, 0.12902) } } },

        };
    }
}
    