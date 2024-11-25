using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gallium64 : RadioactiveSubstance
    {
        public override string name { get; } = "Gallium64";
        public override double halfLife { get; } = 157.62d;
        public override double atomicWeight { get; } = 63.93684d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Copper64() }, { 1.0d, new BetaParticle(1, 3295800.0) }, { 0.0028000000000000004d, new GammaParticle(110700.0, 0.0112) }, { 0.00101d, new GammaParticle(577300.0, 0.00215) }, { 0.0138d, new GammaParticle(756580.0, 0.00164) }, { 0.145d, new GammaParticle(807930.0, 0.00153) }, { 0.085d, new GammaParticle(918840.0, 0.00135) }, { 0.483d, new GammaParticle(991560.0, 0.00125) }, { 0.0008d, new GammaParticle(1185400.0, 0.00105) }, { 0.0633d, new GammaParticle(1276380.0, 0.00097) }, { 0.00145d, new GammaParticle(1352000.0, 0.00092) }, { 0.133d, new GammaParticle(1387340.0, 0.00089) }, { 0.0015d, new GammaParticle(1411300.0, 0.00088) }, { 0.021400000000000002d, new GammaParticle(1455840.0, 0.00085) }, { 0.001d, new GammaParticle(1461300.0, 0.00085) }, { 0.0023d, new GammaParticle(1514700.0, 0.00082) }, { 0.0242d, new GammaParticle(1566590.0, 0.00079) }, { 0.0181d, new GammaParticle(1617770.0, 0.00077) }, { 0.011899999999999999d, new GammaParticle(1625870.0, 0.00076) }, { 0.041100000000000005d, new GammaParticle(1799530.0, 0.00069) }, { 0.018500000000000003d, new GammaParticle(1995900.0, 0.00062) }, { 0.0017000000000000001d, new GammaParticle(2103600.0, 0.00059) }, { 0.10679999999999999d, new GammaParticle(2195220.0, 0.00056) }, { 0.0226d, new GammaParticle(2270380.0, 0.00055) }, { 0.07780000000000001d, new GammaParticle(2374300.0, 0.00052) }, { 0.0063d, new GammaParticle(2433600.0, 0.00051) }, { 0.00169d, new GammaParticle(2544400.0, 0.00049) }, { 0.0028000000000000004d, new GammaParticle(2655200.0, 0.00047) }, { 0.0072d, new GammaParticle(2803300.0, 0.00044) }, { 0.0001d, new GammaParticle(2913000.0, 0.00043) }, { 0.002d, new GammaParticle(3186800.0, 0.00039) }, { 0.0014000000000000002d, new GammaParticle(3261700.0, 0.00038) }, { 0.0008699999999999999d, new GammaParticle(3322000.0, 0.00037) }, { 0.154d, new GammaParticle(3365760.0, 0.00037) }, { 0.0478d, new GammaParticle(3424970.0, 0.00036) }, { 0.00048d, new GammaParticle(3462400.0, 0.00036) }, { 0.00106d, new GammaParticle(3617100.0, 0.00034) }, { 0.0137d, new GammaParticle(3795100.0, 0.00033) }, { 0.0083d, new GammaParticle(4454300.0, 0.00028) }, { 0.00034d, new GammaParticle(4609000.0, 0.00027) }, { 0.00018999999999999998d, new GammaParticle(4712000.0, 0.00026) }, { 1.9506000000000001d, new GammaParticle(511000.0, 0.00243) }, { 0.000361d, new GammaParticle(1035.0, 1.19791) }, { 0.00337d, new GammaParticle(8616.0, 0.1439) }, { 0.00655d, new GammaParticle(8639.0, 0.14352) }, { 0.0014000000000000002d, new GammaParticle(9610.0, 0.12902) }, { 0.0014000000000000002d, new GammaParticle(9610.0, 0.12902) } } },

        };
    }
}
    