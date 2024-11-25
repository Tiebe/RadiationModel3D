using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Copper69 : RadioactiveSubstance
    {
        public override string name { get; } = "Copper69";
        public override double halfLife { get; } = 171.0d;
        public override double atomicWeight { get; } = 68.92943d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Zinc69() }, { 1.0d, new BetaParticle(-1, 1340850.0) }, { 0.00025739999999999997d, new GammaParticle(167200.0, 0.00742) }, { 0.000468d, new GammaParticle(173400.0, 0.00715) }, { 0.0025740000000000003d, new GammaParticle(173400.0, 0.00715) }, { 0.00035099999999999997d, new GammaParticle(178200.0, 0.00696) }, { 0.000936d, new GammaParticle(346300.0, 0.00358) }, { 0.001638d, new GammaParticle(417400.0, 0.00297) }, { 0.0014039999999999999d, new GammaParticle(421800.0, 0.00294) }, { 0.000936d, new GammaParticle(434000.0, 0.00286) }, { 0.001872d, new GammaParticle(476300.0, 0.0026) }, { 0.059669999999999994d, new GammaParticle(531200.0, 0.00233) }, { 0.026208d, new GammaParticle(594900.0, 0.00208) }, { 0.00117d, new GammaParticle(647400.0, 0.00192) }, { 0.020825999999999997d, new GammaParticle(649400.0, 0.00191) }, { 0.000936d, new GammaParticle(820700.0, 0.00151) }, { 0.13104d, new GammaParticle(834400.0, 0.00149) }, { 0.0014039999999999999d, new GammaParticle(851800.0, 0.00146) }, { 0.006552d, new GammaParticle(898200.0, 0.00138) }, { 0.011466d, new GammaParticle(993400.0, 0.00125) }, { 0.23399999999999999d, new GammaParticle(1007500.0, 0.00123) }, { 0.022932d, new GammaParticle(1180700.0, 0.00105) }, { 0.00117d, new GammaParticle(1205000.0, 0.00103) }, { 0.0042120000000000005d, new GammaParticle(1251800.0, 0.00099) }, { 0.00234d, new GammaParticle(1296600.0, 0.00096) }, { 0.000468d, new GammaParticle(1361900.0, 0.00091) }, { 0.034164d, new GammaParticle(1429800.0, 0.00087) }, { 0.0002808d, new GammaParticle(1458300.0, 0.00085) }, { 0.0028079999999999997d, new GammaParticle(1501600.0, 0.00083) }, { 0.000936d, new GammaParticle(1594200.0, 0.00078) }, { 0.0004212d, new GammaParticle(1633200.0, 0.00076) }, { 0.0025740000000000003d, new GammaParticle(1828600.0, 0.00068) }, { 0.0001872d, new GammaParticle(1894000.0, 0.00065) }, { 0.0003978d, new GammaParticle(2033000.0, 0.00061) } } },

        };
    }
}
    