using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lutetium178 : RadioactiveSubstance
    {
        public override string name { get; } = "Lutetium178";
        public override double halfLife { get; } = 1704.0d;
        public override double atomicWeight { get; } = 177.94596d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Hafnium178() }, { 1.0d, new BetaParticle(-1, 1048750.0) }, { 0.06d, new GammaParticle(93179.0, 0.01331) }, { 0.00066d, new GammaParticle(151200.0, 0.0082) }, { 0.00306d, new GammaParticle(203800.0, 0.00608) }, { 0.00066d, new GammaParticle(204100.0, 0.00607) }, { 0.0012d, new GammaParticle(213434.0, 0.00581) }, { 0.00017999999999999998d, new GammaParticle(244200.0, 0.00508) }, { 0.0009d, new GammaParticle(256600.0, 0.00483) }, { 0.00017999999999999998d, new GammaParticle(268900.0, 0.00461) }, { 0.00035999999999999997d, new GammaParticle(307000.0, 0.00404) }, { 0.000456d, new GammaParticle(962200.0, 0.00129) }, { 4.7999999999999994e-05d, new GammaParticle(970400.0, 0.00128) }, { 0.000444d, new GammaParticle(1081400.0, 0.00115) }, { 0.0012360000000000001d, new GammaParticle(1106100.0, 0.00112) }, { 0.00114d, new GammaParticle(1167000.0, 0.00106) }, { 0.000354d, new GammaParticle(1174200.0, 0.00106) }, { 0.00017999999999999998d, new GammaParticle(1183700.0, 0.00105) }, { 0.000258d, new GammaParticle(1189300.0, 0.00104) }, { 0.0020399999999999997d, new GammaParticle(1216800.0, 0.00102) }, { 0.000354d, new GammaParticle(1229200.0, 0.00101) }, { 0.00216d, new GammaParticle(1254760.0, 0.00099) }, { 0.009300000000000001d, new GammaParticle(1269200.0, 0.00098) }, { 4.2e-05d, new GammaParticle(1276600.0, 0.00097) }, { 0.011399999999999999d, new GammaParticle(1309900.0, 0.00095) }, { 0.03444d, new GammaParticle(1340800.0, 0.00092) }, { 0.0005099999999999999d, new GammaParticle(1350600.0, 0.00092) }, { 0.004739999999999999d, new GammaParticle(1403200.0, 0.00088) }, { 0.0012180000000000001d, new GammaParticle(1420500.0, 0.00087) }, { 0.00084d, new GammaParticle(1436400.0, 0.00086) }, { 0.000852d, new GammaParticle(1468300.0, 0.00084) }, { 0.000972d, new GammaParticle(1473300.0, 0.00084) }, { 0.0028799999999999997d, new GammaParticle(1496100.0, 0.00083) }, { 0.0012720000000000001d, new GammaParticle(1513600.0, 0.00082) }, { 0.000672d, new GammaParticle(1561400.0, 0.00079) }, { 0.00264d, new GammaParticle(1678800.0, 0.00074) }, { 0.00027d, new GammaParticle(1725000.0, 0.00072) }, { 9.599999999999999e-05d, new GammaParticle(1928300.0, 0.00064) }, { 0.056555494288799996d, new GammaParticle(9114.0, 0.13604) }, { 0.017860072144644766d, new GammaParticle(54608.0, 0.0227) }, { 0.031256689087582716d, new GammaParticle(55786.0, 0.02222) }, { 0.010311806225550522d, new GammaParticle(63333.0, 0.01958) }, { 0.013065058487772509d, new GammaParticle(64057.0, 0.01936) }, { 0.0027532522622219897d, new GammaParticle(64935.0, 0.01909) } } },

        };
    }
}
    