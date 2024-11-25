using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lutetium180 : RadioactiveSubstance
    {
        public override string name { get; } = "Lutetium180";
        public override double halfLife { get; } = 342.0d;
        public override double atomicWeight { get; } = 179.94989d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Hafnium180() }, { 1.0d, new BetaParticle(-1, 1549750.0) }, { 0.01505d, new GammaParticle(69000.0, 0.01797) }, { 0.11739000000000001d, new GammaParticle(93308.0, 0.01329) }, { 0.0005547d, new GammaParticle(108300.0, 0.01145) }, { 0.01849d, new GammaParticle(135000.0, 0.00918) }, { 0.011051d, new GammaParticle(198300.0, 0.00625) }, { 0.22059d, new GammaParticle(215241.0, 0.00576) }, { 0.01118d, new GammaParticle(234900.0, 0.00528) }, { 0.129d, new GammaParticle(316500.0, 0.00392) }, { 0.012470000000000002d, new GammaParticle(333000.0, 0.00372) }, { 0.43d, new GammaParticle(407960.0, 0.00304) }, { 0.01204d, new GammaParticle(424400.0, 0.00292) }, { 0.00946d, new GammaParticle(451600.0, 0.00275) }, { 0.00215d, new GammaParticle(875300.0, 0.00142) }, { 0.007138d, new GammaParticle(891600.0, 0.00139) }, { 0.0258d, new GammaParticle(982700.0, 0.00126) }, { 0.001591d, new GammaParticle(997100.0, 0.00124) }, { 0.01763d, new GammaParticle(1066400.0, 0.00116) }, { 0.01161d, new GammaParticle(1089900.0, 0.00114) }, { 0.01634d, new GammaParticle(1100900.0, 0.00113) }, { 0.22661d, new GammaParticle(1106600.0, 0.00112) }, { 0.13846d, new GammaParticle(1198000.0, 0.00103) }, { 0.2322d, new GammaParticle(1199700.0, 0.00103) }, { 0.0043d, new GammaParticle(1219200.0, 0.00102) }, { 0.0043d, new GammaParticle(1230800.0, 0.00101) }, { 0.0043d, new GammaParticle(1282500.0, 0.00097) }, { 0.13459d, new GammaParticle(1299300.0, 0.00095) }, { 0.00989d, new GammaParticle(1316200.0, 0.00094) }, { 0.020640000000000002d, new GammaParticle(1434100.0, 0.00086) }, { 0.00645d, new GammaParticle(1446100.0, 0.00086) }, { 0.086d, new GammaParticle(1514400.0, 0.00082) }, { 0.0013716999999999998d, new GammaParticle(1613600.0, 0.00077) }, { 0.00602d, new GammaParticle(1874500.0, 0.00066) }, { 0.010320000000000001d, new GammaParticle(1888400.0, 0.00066) }, { 0.133696463048356d, new GammaParticle(9114.0, 0.13604) }, { 0.05654513041487098d, new GammaParticle(54608.0, 0.0227) }, { 0.09895892617233283d, new GammaParticle(55786.0, 0.02222) }, { 0.032647260498970966d, new GammaParticle(63333.0, 0.01958) }, { 0.04136407905219621d, new GammaParticle(64057.0, 0.01936) }, { 0.008716818553225248d, new GammaParticle(64935.0, 0.01909) } } },

        };
    }
}
    