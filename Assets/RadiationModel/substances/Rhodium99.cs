using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhodium99 : RadioactiveSubstance
    {
        public override string name { get; } = "Rhodium99";
        public override double halfLife { get; } = 1391040.0d;
        public override double atomicWeight { get; } = 98.90812d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Technetium99() }, { 1.0d, new BetaParticle(1, 871450.0) }, { 0.33352d, new GammaParticle(89760.0, 0.01381) }, { 0.0007580000000000001d, new GammaParticle(119400.0, 0.01038) }, { 0.020087d, new GammaParticle(175430.0, 0.00707) }, { 0.004927d, new GammaParticle(232700.0, 0.00533) }, { 0.013265d, new GammaParticle(295700.0, 0.00419) }, { 0.062156d, new GammaParticle(322450.0, 0.00385) }, { 0.34489d, new GammaParticle(353050.0, 0.00351) }, { 0.022361d, new GammaParticle(442800.0, 0.0028) }, { 0.00379d, new GammaParticle(486400.0, 0.00255) }, { 0.379d, new GammaParticle(528240.0, 0.00235) }, { 0.0014402d, new GammaParticle(576300.0, 0.00215) }, { 0.04169d, new GammaParticle(618130.0, 0.00201) }, { 0.0030320000000000004d, new GammaParticle(734100.0, 0.00169) }, { 0.0007580000000000001d, new GammaParticle(796000.0, 0.00156) }, { 0.01137d, new GammaParticle(807250.0, 0.00154) }, { 0.007959d, new GammaParticle(896900.0, 0.00138) }, { 0.0005306d, new GammaParticle(910800.0, 0.00136) }, { 0.012886d, new GammaParticle(940400.0, 0.00132) }, { 0.007959d, new GammaParticle(998700.0, 0.00124) }, { 0.002274d, new GammaParticle(1060750.0, 0.00117) }, { 0.003411d, new GammaParticle(1088800.0, 0.00114) }, { 0.001895d, new GammaParticle(1209320.0, 0.00103) }, { 0.0030320000000000004d, new GammaParticle(1293500.0, 0.00096) }, { 0.002653d, new GammaParticle(1324500.0, 0.00094) }, { 0.0007580000000000001d, new GammaParticle(1383500.0, 0.0009) }, { 0.0005306d, new GammaParticle(1441800.0, 0.00086) }, { 0.0005306d, new GammaParticle(1441800.0, 0.00086) }, { 0.0015160000000000002d, new GammaParticle(1483200.0, 0.00084) }, { 0.005306d, new GammaParticle(1531800.0, 0.00081) }, { 0.0024256d, new GammaParticle(1572500.0, 0.00079) }, { 0.0020466d, new GammaParticle(1616800.0, 0.00077) }, { 0.0008717d, new GammaParticle(1662000.0, 0.00075) }, { 0.0006822d, new GammaParticle(1749900.0, 0.00071) }, { 0.0015160000000000002d, new GammaParticle(1970000.0, 0.00063) }, { 0.0002274d, new GammaParticle(2059200.0, 0.0006) }, { 0.080626d, new GammaParticle(511000.0, 0.00243) }, { 0.062d, new GammaParticle(2737.0, 0.45299) }, { 0.27d, new GammaParticle(19150.0, 0.06474) }, { 0.51d, new GammaParticle(19279.0, 0.06431) }, { 0.13699999999999998d, new GammaParticle(21736.0, 0.05704) }, { 0.159d, new GammaParticle(21875.0, 0.05668) }, { 0.022000000000000002d, new GammaParticle(22072.0, 0.05617) } } },

        };
    }
}
    