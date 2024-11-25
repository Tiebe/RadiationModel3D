using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tellurium127 : RadioactiveSubstance
    {
        public override string name { get; } = "Tellurium127";
        public override double halfLife { get; } = 33660.0d;
        public override double atomicWeight { get; } = 126.90523d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Iodine127() }, { 1.0d, new BetaParticle(-1, 351250.0) }, { 0.000297d, new GammaParticle(57630.0, 0.02151) }, { 3.267e-05d, new GammaParticle(145200.0, 0.00854) }, { 2.97e-06d, new GammaParticle(172100.0, 0.0072) }, { 0.00058014d, new GammaParticle(202900.0, 0.00611) }, { 0.00038709d, new GammaParticle(215100.0, 0.00576) }, { 0.0013464000000000002d, new GammaParticle(360300.0, 0.00344) }, { 2.97e-06d, new GammaParticle(375000.0, 0.00331) }, { 0.009899999999999999d, new GammaParticle(417900.0, 0.00297) }, { 1.2870000000000001e-06d, new GammaParticle(618400.0, 0.002) }, { 0.0001159903631110356d, new GammaParticle(4335.0, 0.28601) }, { 0.0003014298669459208d, new GammaParticle(28318.0, 0.04378) }, { 0.0005598623085919778d, new GammaParticle(28613.0, 0.04333) }, { 0.00016129908931770108d, new GammaParticle(32395.0, 0.03827) }, { 0.0001977526835035015d, new GammaParticle(32680.0, 0.03794) }, { 3.645359418580044e-05d, new GammaParticle(33040.0, 0.03753) } } },

        };
    }
}
    