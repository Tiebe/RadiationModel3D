using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gallium62 : RadioactiveSubstance
    {
        public override string name { get; } = "Gallium62";
        public override double halfLife { get; } = 0.11612d;
        public override double atomicWeight { get; } = 61.94419d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Copper62() }, { 1.0d, new BetaParticle(1, 5400250.0) }, { 0.0001d, new GammaParticle(850900.0, 0.00146) }, { 0.0008500000000000001d, new GammaParticle(953900.0, 0.0013) }, { 5.999999999999999e-06d, new GammaParticle(1032000.0, 0.0012) }, { 1.9e-05d, new GammaParticle(1156700.0, 0.00107) }, { 0.00019099999999999998d, new GammaParticle(1388500.0, 0.00089) }, { 3e-05d, new GammaParticle(1569800.0, 0.00079) }, { 3.5000000000000004e-05d, new GammaParticle(1619200.0, 0.00077) }, { 2.1e-05d, new GammaParticle(1644700.0, 0.00075) }, { 8e-06d, new GammaParticle(1679300.0, 0.00074) }, { 7.000000000000001e-05d, new GammaParticle(1805000.0, 0.00069) }, { 7.2e-05d, new GammaParticle(1849600.0, 0.00067) }, { 1.1999999999999999e-05d, new GammaParticle(2089000.0, 0.00059) }, { 4.7000000000000004e-05d, new GammaParticle(2092500.0, 0.00059) }, { 6.1000000000000005e-05d, new GammaParticle(2105900.0, 0.00059) }, { 0.000262d, new GammaParticle(2227200.0, 0.00056) }, { 1.3e-05d, new GammaParticle(2408300.0, 0.00051) }, { 2.6e-05d, new GammaParticle(2643900.0, 0.00047) }, { 5.999999999999999e-06d, new GammaParticle(2802000.0, 0.00044) }, { 1.7e-05d, new GammaParticle(2869800.0, 0.00043) }, { 1.6e-05d, new GammaParticle(3068100.0, 0.0004) }, { 9e-06d, new GammaParticle(3089000.0, 0.0004) }, { 4.2e-05d, new GammaParticle(3181300.0, 0.00039) }, { 1.8e-05d, new GammaParticle(3373500.0, 0.00037) }, { 5.7999999999999994e-05d, new GammaParticle(3493900.0, 0.00035) }, { 0.000149d, new GammaParticle(4021700.0, 0.00031) }, { 2.8999999999999997e-05d, new GammaParticle(4256600.0, 0.00029) }, { 0.00010899999999999999d, new GammaParticle(4447800.0, 0.00028) }, { 4.2e-05d, new GammaParticle(4894400.0, 0.00025) }, { 5.1000000000000006e-05d, new GammaParticle(5211500.0, 0.00024) }, { 8e-06d, new GammaParticle(5920500.0, 0.00021) }, { 1.996858d, new GammaParticle(511000.0, 0.00243) }, { 1.7827339726224e-05d, new GammaParticle(1035.0, 1.19791) }, { 0.00016616893280161496d, new GammaParticle(8616.0, 0.1439) }, { 0.0003231601182450699d, new GammaParticle(8639.0, 0.14352) }, { 6.933792653331523e-05d, new GammaParticle(9610.0, 0.12902) }, { 6.933792653331523e-05d, new GammaParticle(9610.0, 0.12902) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    