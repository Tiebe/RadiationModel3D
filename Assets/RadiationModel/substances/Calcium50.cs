using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Calcium50 : RadioactiveSubstance
    {
        public override string name { get; } = "Calcium50";
        public override double halfLife { get; } = 13.45d;
        public override double atomicWeight { get; } = 49.9575d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Scandium50() }, { 1.0d, new BetaParticle(-1, 2473950.0) }, { 0.544362d, new GammaParticle(71552.0, 0.01733) }, { 0.991018d, new GammaParticle(256894.0, 0.00483) }, { 0.0045862d, new GammaParticle(328000.0, 0.00378) }, { 0.6161460000000001d, new GammaParticle(1519300.0, 0.00082) }, { 0.373875d, new GammaParticle(1590850.0, 0.00078) }, { 0.00023006942467857598d, new GammaParticle(422.0, 2.93801) }, { 0.0029627796292689993d, new GammaParticle(4086.0, 0.30344) }, { 0.005844899643458274d, new GammaParticle(4091.0, 0.30307) }, { 0.0011617328960727273d, new GammaParticle(4474.0, 0.27712) }, { 0.0011617328960727273d, new GammaParticle(4474.0, 0.27712) } } },

        };
    }
}
    