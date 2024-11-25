using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Uranium234 : RadioactiveSubstance
    {
        public override string name { get; } = "Uranium234";
        public override double halfLife { get; } = 7747225326762.336d;
        public override double atomicWeight { get; } = 234.04095d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Thorium230() }, { 1.0d, new AlphaParticle(5879502.09) }, { 0.00123d, new GammaParticle(53200.0, 0.02331) }, { 0.000342d, new GammaParticle(120900.0, 0.01026) }, { 2.5e-07d, new GammaParticle(454950.0, 0.00273) }, { 7.9e-09d, new GammaParticle(503500.0, 0.00246) }, { 1.5e-07d, new GammaParticle(508200.0, 0.00244) }, { 1.2000000000000002e-07d, new GammaParticle(581700.0, 0.00213) }, { 8.4e-09d, new GammaParticle(624400.0, 0.00199) }, { 1e-08d, new GammaParticle(677600.0, 0.00183) }, { 0.09824816107234241d, new GammaParticle(15784.0, 0.07855) }, { 2.5146901564574528e-05d, new GammaParticle(89954.0, 0.01378) }, { 4.067761495401897e-05d, new GammaParticle(93347.0, 0.01328) }, { 1.447450101455983e-05d, new GammaParticle(105566.0, 0.01174) }, { 1.9352407856466492e-05d, new GammaParticle(106894.0, 0.0116) }, { 4.877906841906663e-06d, new GammaParticle(108580.0, 0.01142) } } },
            { 1.64e-11d, new Dictionary<double, RadioactiveSubstance> {  } },
            { 1.4e-13d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    