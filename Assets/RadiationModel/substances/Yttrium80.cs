using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Yttrium80 : RadioactiveSubstance
    {
        public override string name { get; } = "Yttrium80";
        public override double halfLife { get; } = 30.1d;
        public override double atomicWeight { get; } = 79.93435d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Rubidium80() }, { 1.0d, new BetaParticle(1, 5513750.0) }, { 0.0096d, new GammaParticle(325700.0, 0.00381) }, { 0.96d, new GammaParticle(385900.0, 0.00321) }, { 0.0036d, new GammaParticle(413600.0, 0.003) }, { 0.0216d, new GammaParticle(428900.0, 0.00289) }, { 0.0036d, new GammaParticle(463400.0, 0.00268) }, { 0.0024d, new GammaParticle(534300.0, 0.00232) }, { 0.0036d, new GammaParticle(586400.0, 0.00211) }, { 0.0048d, new GammaParticle(590200.0, 0.0021) }, { 0.49920000000000003d, new GammaParticle(594800.0, 0.00208) }, { 0.0084d, new GammaParticle(647700.0, 0.00191) }, { 0.0108d, new GammaParticle(673100.0, 0.00184) }, { 0.037200000000000004d, new GammaParticle(690300.0, 0.0018) }, { 0.022799999999999997d, new GammaParticle(725400.0, 0.00171) }, { 0.0984d, new GammaParticle(756200.0, 0.00164) }, { 0.0096d, new GammaParticle(765300.0, 0.00162) }, { 0.0552d, new GammaParticle(783100.0, 0.00158) }, { 0.012d, new GammaParticle(847700.0, 0.00146) }, { 0.046799999999999994d, new GammaParticle(851800.0, 0.00146) }, { 0.0072d, new GammaParticle(861200.0, 0.00144) }, { 0.0072d, new GammaParticle(987400.0, 0.00126) }, { 0.0516d, new GammaParticle(1142100.0, 0.00109) }, { 0.1164d, new GammaParticle(1185200.0, 0.00105) }, { 0.006d, new GammaParticle(1225500.0, 0.00101) }, { 0.0204d, new GammaParticle(1267600.0, 0.00098) }, { 0.0192d, new GammaParticle(1276600.0, 0.00097) }, { 0.0192d, new GammaParticle(1278700.0, 0.00097) }, { 0.012d, new GammaParticle(1315500.0, 0.00094) }, { 0.0132d, new GammaParticle(1320400.0, 0.00094) }, { 0.024d, new GammaParticle(1387200.0, 0.00089) }, { 0.0048d, new GammaParticle(1396300.0, 0.00089) }, { 0.018000000000000002d, new GammaParticle(1438200.0, 0.00086) }, { 0.0168d, new GammaParticle(1446700.0, 0.00086) }, { 0.0132d, new GammaParticle(1451400.0, 0.00085) }, { 0.012d, new GammaParticle(1487000.0, 0.00083) }, { 0.0048d, new GammaParticle(1523500.0, 0.00081) }, { 0.0048d, new GammaParticle(1544700.0, 0.0008) }, { 0.0096d, new GammaParticle(1591900.0, 0.00078) }, { 0.0084d, new GammaParticle(1653600.0, 0.00075) }, { 0.006d, new GammaParticle(1658000.0, 0.00075) }, { 0.0048d, new GammaParticle(1806000.0, 0.00069) }, { 0.022799999999999997d, new GammaParticle(1855800.0, 0.00067) }, { 1.996d, new GammaParticle(511000.0, 0.00243) }, { 0.00045d, new GammaParticle(1890.0, 0.656) }, { 0.0028000000000000004d, new GammaParticle(14098.0, 0.08794) }, { 0.0054d, new GammaParticle(14165.0, 0.08753) }, { 0.0013d, new GammaParticle(15898.0, 0.07799) }, { 0.0015d, new GammaParticle(15955.0, 0.07771) }, { 0.00017d, new GammaParticle(16085.0, 0.07708) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    