using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thallium208 : RadioactiveSubstance
    {
        public override string name { get; } = "Thallium208";
        public override double halfLife { get; } = 183.18d;
        public override double atomicWeight { get; } = 207.98202d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Lead208() }, { 1.0d, new BetaParticle(-1, 2499200.0) }, { 0.0018d, new GammaParticle(211400.0, 0.00586) }, { 0.0031d, new GammaParticle(233360.0, 0.00531) }, { 0.0078000000000000005d, new GammaParticle(252610.0, 0.00491) }, { 0.066d, new GammaParticle(277371.0, 0.00447) }, { 0.00049d, new GammaParticle(485950.0, 0.00255) }, { 0.226d, new GammaParticle(510770.0, 0.00243) }, { 0.85d, new GammaParticle(583187.0, 0.00213) }, { 0.0006d, new GammaParticle(587700.0, 0.00211) }, { 0.0005d, new GammaParticle(650100.0, 0.00191) }, { 0.00021999999999999998d, new GammaParticle(705200.0, 0.00176) }, { 0.0024d, new GammaParticle(722040.0, 0.00172) }, { 0.00046d, new GammaParticle(748700.0, 0.00166) }, { 0.0179d, new GammaParticle(763130.0, 0.00162) }, { 0.0003d, new GammaParticle(808300.0, 0.00153) }, { 0.00041d, new GammaParticle(821200.0, 0.00151) }, { 0.0007599999999999999d, new GammaParticle(835900.0, 0.00148) }, { 0.125d, new GammaParticle(860557.0, 0.00144) }, { 0.00031d, new GammaParticle(883300.0, 0.0014) }, { 0.00125d, new GammaParticle(927600.0, 0.00134) }, { 0.0020499999999999997d, new GammaParticle(982700.0, 0.00126) }, { 5e-05d, new GammaParticle(1004000.0, 0.00123) }, { 0.0043d, new GammaParticle(1093900.0, 0.00113) }, { 5e-05d, new GammaParticle(1125700.0, 0.0011) }, { 0.00010999999999999999d, new GammaParticle(1160800.0, 0.00107) }, { 0.00017d, new GammaParticle(1185200.0, 0.00105) }, { 0.00052d, new GammaParticle(1282800.0, 0.00097) }, { 7.000000000000001e-05d, new GammaParticle(1381100.0, 0.0009) }, { 2e-05d, new GammaParticle(1647500.0, 0.00075) }, { 2e-05d, new GammaParticle(1744000.0, 0.00071) }, { 0.9975400000000001d, new GammaParticle(2614511.0, 0.00047) }, { 7.000000000000001e-05d, new GammaParticle(3197700.0, 0.00039) }, { 3e-05d, new GammaParticle(3475100.0, 0.00036) }, { 4e-05d, new GammaParticle(3708400.0, 0.00033) }, { 3e-05d, new GammaParticle(3960900.0, 0.00031) }, { 0.0277d, new GammaParticle(12522.0, 0.09901) }, { 0.020499999999999997d, new GammaParticle(72805.0, 0.01703) }, { 0.0345d, new GammaParticle(74970.0, 0.01654) }, { 0.0118d, new GammaParticle(84986.0, 0.01459) }, { 0.015300000000000001d, new GammaParticle(86022.0, 0.01441) }, { 0.00356d, new GammaParticle(87301.0, 0.0142) } } },

        };
    }
}
    