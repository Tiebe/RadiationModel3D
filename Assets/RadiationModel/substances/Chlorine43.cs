using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Chlorine43 : RadioactiveSubstance
    {
        public override string name { get; } = "Chlorine43";
        public override double halfLife { get; } = 3.13d;
        public override double atomicWeight { get; } = 42.97406d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Argon43() }, { 1.0d, new BetaParticle(-1, 3925000.0) }, { 0.011970000000000001d, new GammaParticle(352130.0, 0.00352) }, { 0.007011d, new GammaParticle(411800.0, 0.00301) }, { 0.012825d, new GammaParticle(619560.0, 0.002) }, { 0.057d, new GammaParticle(679240.0, 0.00183) }, { 0.028158d, new GammaParticle(726580.0, 0.00171) }, { 0.57d, new GammaParticle(761810.0, 0.00163) }, { 0.009633000000000001d, new GammaParticle(948960.0, 0.00131) }, { 0.003876d, new GammaParticle(1008820.0, 0.00123) }, { 0.51129d, new GammaParticle(1031840.0, 0.0012) }, { 0.035910000000000004d, new GammaParticle(1381790.0, 0.0009) }, { 0.00912d, new GammaParticle(1441690.0, 0.00086) }, { 0.003933d, new GammaParticle(1628100.0, 0.00076) }, { 0.007352999999999999d, new GammaParticle(1631800.0, 0.00076) }, { 0.001767d, new GammaParticle(1758200.0, 0.00071) }, { 0.015504d, new GammaParticle(1793500.0, 0.00069) }, { 0.018126d, new GammaParticle(1816500.0, 0.00068) }, { 0.001938d, new GammaParticle(1933300.0, 0.00064) }, { 0.02223d, new GammaParticle(1944960.0, 0.00064) }, { 0.003249d, new GammaParticle(2036400.0, 0.00061) }, { 0.003306d, new GammaParticle(2108000.0, 0.00059) }, { 0.006840000000000001d, new GammaParticle(2215400.0, 0.00056) }, { 0.01539d, new GammaParticle(2344000.0, 0.00053) }, { 0.02907d, new GammaParticle(2390500.0, 0.00052) }, { 0.008322000000000001d, new GammaParticle(2430000.0, 0.00051) }, { 0.007866d, new GammaParticle(2452700.0, 0.00051) }, { 0.01653d, new GammaParticle(2805430.0, 0.00044) }, { 0.004731d, new GammaParticle(2865700.0, 0.00043) }, { 0.005301d, new GammaParticle(3109300.0, 0.0004) }, { 0.012768d, new GammaParticle(3395800.0, 0.00037) }, { 0.019950000000000002d, new GammaParticle(4247000.0, 0.00029) } } },

        };
    }
}
    