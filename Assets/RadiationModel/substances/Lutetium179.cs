using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lutetium179 : RadioactiveSubstance
    {
        public override string name { get; } = "Lutetium179";
        public override double halfLife { get; } = 16524.0d;
        public override double atomicWeight { get; } = 178.94733d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Hafnium179() }, { 1.0d, new BetaParticle(-1, 702000.0) }, { 0.001512d, new GammaParticle(122790.0, 0.0101) }, { 0.00462d, new GammaParticle(123380.0, 0.01005) }, { 0.1176d, new GammaParticle(214330.0, 0.00578) }, { 0.0047599999999999995d, new GammaParticle(215010.0, 0.00577) }, { 1.96e-05d, new GammaParticle(279200.0, 0.00444) }, { 6.440000000000001e-05d, new GammaParticle(304030.0, 0.00408) }, { 0.0018759999999999998d, new GammaParticle(337670.0, 0.00367) }, { 4.2e-05d, new GammaParticle(532510.0, 0.00233) }, { 0.00028000000000000003d, new GammaParticle(655850.0, 0.00189) }, { 5.6e-06d, new GammaParticle(680200.0, 0.00182) }, { 0.0001736d, new GammaParticle(735780.0, 0.00169) }, { 2.24e-06d, new GammaParticle(789400.0, 0.00157) }, { 2.8e-05d, new GammaParticle(830370.0, 0.00149) }, { 0.001036d, new GammaParticle(859160.0, 0.00144) }, { 0.000588d, new GammaParticle(870140.0, 0.00142) }, { 2.24e-05d, new GammaParticle(891500.0, 0.00139) }, { 1.3719999999999999e-05d, new GammaParticle(953900.0, 0.0013) }, { 9.24e-05d, new GammaParticle(983170.0, 0.00126) }, { 2.8e-06d, new GammaParticle(999100.0, 0.00124) }, { 0.0001204d, new GammaParticle(1003320.0, 0.00124) }, { 3.92e-05d, new GammaParticle(1045630.0, 0.00119) }, { 2.8e-06d, new GammaParticle(1073500.0, 0.00115) }, { 8.4e-05d, new GammaParticle(1076900.0, 0.00115) }, { 0.0002772d, new GammaParticle(1105920.0, 0.00112) }, { 8.400000000000001e-06d, new GammaParticle(1120800.0, 0.00111) }, { 1.428e-05d, new GammaParticle(1168400.0, 0.00106) }, { 5.0400000000000005e-05d, new GammaParticle(1199500.0, 0.00103) }, { 0.0035005571507990716d, new GammaParticle(9114.0, 0.13604) }, { 0.0028796059604814916d, new GammaParticle(54608.0, 0.0227) }, { 0.005039562408963059d, new GammaParticle(55786.0, 0.02222) }, { 0.0016625878344690215d, new GammaParticle(63333.0, 0.01958) }, { 0.00210649878627225d, new GammaParticle(64057.0, 0.01936) }, { 0.00044391095180322873d, new GammaParticle(64935.0, 0.01909) } } },

        };
    }
}
    