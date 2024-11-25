using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cesium130 : RadioactiveSubstance
    {
        public override string name { get; } = "Cesium130";
        public override double halfLife { get; } = 1752.6d;
        public override double atomicWeight { get; } = 129.90671d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9840000000000001d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Iodine130() }, { 1.0d, new BetaParticle(1, 18000.0) }, { 0.038d, new GammaParticle(536100.0, 0.00231) }, { 0.004699999999999999d, new GammaParticle(586100.0, 0.00212) }, { 0.00012d, new GammaParticle(671900.0, 0.00185) }, { 0.0039000000000000003d, new GammaParticle(894500.0, 0.00139) }, { 0.00017d, new GammaParticle(1028600.0, 0.00121) }, { 0.00073d, new GammaParticle(1122200.0, 0.0011) }, { 0.00077d, new GammaParticle(1257500.0, 0.00099) }, { 0.00037999999999999997d, new GammaParticle(1263800.0, 0.00098) }, { 7.000000000000001e-05d, new GammaParticle(1380700.0, 0.0009) }, { 0.00023d, new GammaParticle(1481800.0, 0.00084) }, { 0.0026d, new GammaParticle(1615000.0, 0.00077) }, { 0.0019d, new GammaParticle(1687400.0, 0.00073) }, { 0.0013800000000000002d, new GammaParticle(1707000.0, 0.00073) }, { 0.00031d, new GammaParticle(1850500.0, 0.00067) }, { 0.00017d, new GammaParticle(1958900.0, 0.00063) }, { 8.999999999999999e-05d, new GammaParticle(1967400.0, 0.00063) }, { 0.0017000000000000001d, new GammaParticle(1997300.0, 0.00062) }, { 0.00013d, new GammaParticle(2093400.0, 0.00059) }, { 0.00012d, new GammaParticle(2151200.0, 0.00058) }, { 1.9e-05d, new GammaParticle(2503600.0, 0.0005) }, { 0.87168d, new GammaParticle(511000.0, 0.00243) }, { 0.047163431732124d, new GammaParticle(4540.0, 0.27309) }, { 0.11853009520555258d, new GammaParticle(29458.0, 0.04209) }, { 0.21958150278909333d, new GammaParticle(29778.0, 0.04164) }, { 0.06365580004316675d, new GammaParticle(33726.0, 0.03676) }, { 0.0786785688533541d, new GammaParticle(34030.0, 0.03643) }, { 0.015022768810187352d, new GammaParticle(34414.0, 0.03603) } } },
            { 0.016d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Barium130() }, { 1.0d, new BetaParticle(-1, 178390.0) } } },

        };
    }
}
    