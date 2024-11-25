using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Molybdenum99 : RadioactiveSubstance
    {
        public override string name { get; } = "Molybdenum99";
        public override double halfLife { get; } = 237326.4d;
        public override double atomicWeight { get; } = 98.90771d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Technetium99() }, { 1.0d, new BetaParticle(-1, 678895.0) }, { 0.0103822d, new GammaParticle(40583.23, 0.03055) }, { 3.0500000000000003e-05d, new GammaParticle(89400.0, 0.01387) }, { 0.00017568d, new GammaParticle(158782.0, 0.00781) }, { 0.00011956d, new GammaParticle(162370.0, 0.00764) }, { 0.060511999999999996d, new GammaParticle(181068.0, 0.00685) }, { 2.5620000000000002e-05d, new GammaParticle(242290.0, 0.00512) }, { 3.904e-05d, new GammaParticle(249030.0, 0.00498) }, { 0.0120048d, new GammaParticle(366421.0, 0.00338) }, { 0.00010491999999999999d, new GammaParticle(380130.0, 0.00326) }, { 3.172e-05d, new GammaParticle(391700.0, 0.00317) }, { 1.952e-05d, new GammaParticle(410270.0, 0.00302) }, { 0.00015006d, new GammaParticle(411491.0, 0.00301) }, { 1.342e-05d, new GammaParticle(455840.0, 0.00272) }, { 8.174000000000001e-05d, new GammaParticle(457600.0, 0.00271) }, { 2.684e-05d, new GammaParticle(469630.0, 0.00264) }, { 1.098e-05d, new GammaParticle(490530.0, 0.00253) }, { 0.0005319200000000001d, new GammaParticle(528788.0, 0.00234) }, { 3.294e-05d, new GammaParticle(537790.0, 0.00231) }, { 3.172e-05d, new GammaParticle(580510.0, 0.00214) }, { 9.76e-06d, new GammaParticle(581300.0, 0.00213) }, { 2.0739999999999998e-05d, new GammaParticle(599600.0, 0.00207) }, { 0.00027938d, new GammaParticle(620030.0, 0.002) }, { 0.000183d, new GammaParticle(621771.0, 0.00199) }, { 4.270000000000001e-06d, new GammaParticle(689600.0, 0.0018) }, { 0.122d, new GammaParticle(739500.0, 0.00168) }, { 4.026e-06d, new GammaParticle(761770.0, 0.00163) }, { 0.04306600000000001d, new GammaParticle(777921.0, 0.00159) }, { 0.001342d, new GammaParticle(822972.0, 0.00151) }, { 7.32e-06d, new GammaParticle(861200.0, 0.00144) }, { 0.0009515999999999999d, new GammaParticle(960754.0, 0.00129) }, { 1.464e-05d, new GammaParticle(986440.0, 0.00126) }, { 5.49e-05d, new GammaParticle(1001343.0, 0.00124) }, { 6.1e-06d, new GammaParticle(1017000.0, 0.00122) }, { 1.0858e-05d, new GammaParticle(1056200.0, 0.00117) }, { 0.0019656159279459644d, new GammaParticle(2586.0, 0.47944) }, { 0.009311899818067591d, new GammaParticle(18250.0, 0.06794) }, { 0.01770659786664307d, new GammaParticle(18367.0, 0.0675) }, { 0.0047060716606270635d, new GammaParticle(20695.0, 0.05991) }, { 0.00544963098300614d, new GammaParticle(20820.0, 0.05955) }, { 0.0007435593223790761d, new GammaParticle(21003.0, 0.05903) } } },

        };
    }
}
    