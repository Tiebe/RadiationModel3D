using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Manganese57 : RadioactiveSubstance
    {
        public override string name { get; } = "Manganese57";
        public override double halfLife { get; } = 85.4d;
        public override double atomicWeight { get; } = 56.93829d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Iron57() }, { 1.0d, new BetaParticle(-1, 1347860.0) }, { 0.1056d, new GammaParticle(14412.9, 0.08602) }, { 0.13915d, new GammaParticle(122063.0, 0.01016) }, { 0.01925d, new GammaParticle(136476.0, 0.00908) }, { 0.0022d, new GammaParticle(230250.0, 0.00538) }, { 0.0017050000000000001d, new GammaParticle(339600.0, 0.00365) }, { 0.0209d, new GammaParticle(352320.0, 0.00352) }, { 0.00396d, new GammaParticle(366730.0, 0.00338) }, { 7.699999999999999e-06d, new GammaParticle(460100.0, 0.00269) }, { 0.00517d, new GammaParticle(569930.0, 0.00218) }, { 0.055d, new GammaParticle(692000.0, 0.00179) }, { 0.002365d, new GammaParticle(706420.0, 0.00176) }, { 0.002585d, new GammaParticle(870680.0, 0.00142) }, { 7.15e-06d, new GammaParticle(898400.0, 0.00138) }, { 0.000935d, new GammaParticle(921030.0, 0.00135) }, { 0.0014299999999999998d, new GammaParticle(992680.0, 0.00125) }, { 0.00043999999999999996d, new GammaParticle(1019080.0, 0.00122) }, { 5.5e-07d, new GammaParticle(1250600.0, 0.00099) }, { 0.003245d, new GammaParticle(1260540.0, 0.00098) }, { 2.75e-07d, new GammaParticle(1265000.0, 0.00098) }, { 0.0002365d, new GammaParticle(1358710.0, 0.00091) }, { 0.007315d, new GammaParticle(1612820.0, 0.00077) }, { 6.6e-05d, new GammaParticle(1710200.0, 0.00072) }, { 0.00165d, new GammaParticle(1725180.0, 0.00072) }, { 0.007346143807662219d, new GammaParticle(728.0, 1.70308) }, { 0.08323132308943057d, new GammaParticle(6391.0, 0.194) }, { 0.1629749815731948d, new GammaParticle(6404.0, 0.1936) }, { 0.03368102247784714d, new GammaParticle(7082.0, 0.17507) }, { 0.03368102247784714d, new GammaParticle(7082.0, 0.17507) } } },

        };
    }
}
    