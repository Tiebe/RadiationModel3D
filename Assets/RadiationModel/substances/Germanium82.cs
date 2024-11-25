using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Germanium82 : RadioactiveSubstance
    {
        public override string name { get; } = "Germanium82";
        public override double halfLife { get; } = 4.0d;
        public override double atomicWeight { get; } = 81.92977d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Arsenic82() }, { 1.0d, new BetaParticle(-1, 2344950.0) }, { 0.00774d, new GammaParticle(92600.0, 0.01339) }, { 0.027864d, new GammaParticle(249100.0, 0.00498) }, { 0.00387d, new GammaParticle(329300.0, 0.00377) }, { 0.0020898d, new GammaParticle(420400.0, 0.00295) }, { 0.0067338d, new GammaParticle(426600.0, 0.00291) }, { 0.00387d, new GammaParticle(447400.0, 0.00277) }, { 0.009675d, new GammaParticle(516500.0, 0.0024) }, { 0.0017028d, new GammaParticle(526300.0, 0.00236) }, { 0.001548d, new GammaParticle(553100.0, 0.00224) }, { 0.008514d, new GammaParticle(575300.0, 0.00216) }, { 0.06192d, new GammaParticle(843400.0, 0.00147) }, { 0.010835999999999998d, new GammaParticle(951800.0, 0.0013) }, { 0.0012384d, new GammaParticle(1063900.0, 0.00117) }, { 0.774d, new GammaParticle(1092000.0, 0.00114) }, { 0.00387d, new GammaParticle(1199100.0, 0.00103) }, { 0.004644d, new GammaParticle(1201100.0, 0.00103) }, { 0.0026316d, new GammaParticle(1311300.0, 0.00095) }, { 0.0023994d, new GammaParticle(1462400.0, 0.00085) }, { 0.0006966d, new GammaParticle(1600100.0, 0.00077) }, { 0.0009288d, new GammaParticle(2196600.0, 0.00056) }, { 1.584347814e-05d, new GammaParticle(1320.0, 0.93927) }, { 0.0001288912296974457d, new GammaParticle(10509.0, 0.11798) }, { 0.0002501285264844667d, new GammaParticle(10544.0, 0.11759) }, { 5.7192613044986985e-05d, new GammaParticle(11773.0, 0.10531) }, { 5.935449381808749e-05d, new GammaParticle(11791.0, 0.10515) }, { 2.161880773100508e-06d, new GammaParticle(11861.0, 0.10453) } } },

        };
    }
}
    