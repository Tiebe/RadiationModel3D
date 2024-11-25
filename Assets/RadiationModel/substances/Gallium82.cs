using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gallium82 : RadioactiveSubstance
    {
        public override string name { get; } = "Gallium82";
        public override double halfLife { get; } = 0.6d;
        public override double atomicWeight { get; } = 81.94318d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Germanium82() }, { 1.0d, new BetaParticle(-1, 6242200.0) }, { 0.015600000000000001d, new GammaParticle(415400.0, 0.00298) }, { 0.061799999999999994d, new GammaParticle(867000.0, 0.00143) }, { 0.0432d, new GammaParticle(938300.0, 0.00132) }, { 0.0282d, new GammaParticle(985300.0, 0.00126) }, { 0.6d, new GammaParticle(1348300.0, 0.00092) }, { 0.039d, new GammaParticle(1354000.0, 0.00092) }, { 0.021d, new GammaParticle(1365400.0, 0.00091) }, { 0.009000000000000001d, new GammaParticle(1727400.0, 0.00072) }, { 0.0654d, new GammaParticle(1910200.0, 0.00065) }, { 0.0108d, new GammaParticle(1951500.0, 0.00064) }, { 0.111d, new GammaParticle(2215430.0, 0.00056) }, { 0.0192d, new GammaParticle(2714300.0, 0.00046) }, { 0.0048d, new GammaParticle(2826600.0, 0.00044) }, { 0.019799999999999998d, new GammaParticle(2872600.0, 0.00043) }, { 0.0078000000000000005d, new GammaParticle(3076300.0, 0.0004) }, { 0.0108d, new GammaParticle(3360600.0, 0.00037) }, { 0.0108d, new GammaParticle(3560100.0, 0.00035) }, { 0.0108d, new GammaParticle(3571400.0, 0.00035) }, { 0.0138d, new GammaParticle(3848400.0, 0.00032) }, { 0.0084d, new GammaParticle(4269400.0, 0.00029) }, { 0.0054d, new GammaParticle(4664100.0, 0.00027) }, { 0.0006d, new GammaParticle(5326700.0, 0.00023) } } },
            { 0.222d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Germanium82() }, { 1.0d, new BetaParticle(-1, 6242200.0) }, { 0.015600000000000001d, new GammaParticle(415400.0, 0.00298) }, { 0.061799999999999994d, new GammaParticle(867000.0, 0.00143) }, { 0.0432d, new GammaParticle(938300.0, 0.00132) }, { 0.0282d, new GammaParticle(985300.0, 0.00126) }, { 0.6d, new GammaParticle(1348300.0, 0.00092) }, { 0.039d, new GammaParticle(1354000.0, 0.00092) }, { 0.021d, new GammaParticle(1365400.0, 0.00091) }, { 0.009000000000000001d, new GammaParticle(1727400.0, 0.00072) }, { 0.0654d, new GammaParticle(1910200.0, 0.00065) }, { 0.0108d, new GammaParticle(1951500.0, 0.00064) }, { 0.111d, new GammaParticle(2215430.0, 0.00056) }, { 0.0192d, new GammaParticle(2714300.0, 0.00046) }, { 0.0048d, new GammaParticle(2826600.0, 0.00044) }, { 0.019799999999999998d, new GammaParticle(2872600.0, 0.00043) }, { 0.0078000000000000005d, new GammaParticle(3076300.0, 0.0004) }, { 0.0108d, new GammaParticle(3360600.0, 0.00037) }, { 0.0108d, new GammaParticle(3560100.0, 0.00035) }, { 0.0108d, new GammaParticle(3571400.0, 0.00035) }, { 0.0138d, new GammaParticle(3848400.0, 0.00032) }, { 0.0084d, new GammaParticle(4269400.0, 0.00029) }, { 0.0054d, new GammaParticle(4664100.0, 0.00027) }, { 0.0006d, new GammaParticle(5326700.0, 0.00023) } } },

        };
    }
}
    