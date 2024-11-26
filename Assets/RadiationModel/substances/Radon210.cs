using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Radon210 : RadioactiveSubstance
    {
        public override string name { get; } = "Radon210";
        public override double halfLife { get; } = 8640.0d;
        public override double atomicWeight { get; } = 209.98969d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.96d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Polonium206() }, { 1.0d, new AlphaParticle(7181002.09) } } },
            { 0.04d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Polonium210() }, { 1.0d, new BetaParticle(1, betaPlusSpectrum) }, { 0.006500000000000001d, new GammaParticle(72700.0, 0.01705) }, { 0.00017999999999999998d, new GammaParticle(147300.0, 0.00842) }, { 0.0016d, new GammaParticle(190350.0, 0.00651) }, { 0.0037d, new GammaParticle(196300.0, 0.00632) }, { 0.00057d, new GammaParticle(225100.0, 0.00551) }, { 0.0058d, new GammaParticle(233300.0, 0.00531) }, { 0.0017000000000000001d, new GammaParticle(238100.0, 0.00521) }, { 0.00018999999999999998d, new GammaParticle(239500.0, 0.00518) }, { 8.999999999999999e-05d, new GammaParticle(248000.0, 0.005) }, { 0.0011d, new GammaParticle(255500.0, 0.00485) }, { 0.00057d, new GammaParticle(283750.0, 0.00437) }, { 0.00089d, new GammaParticle(307300.0, 0.00403) }, { 0.0043d, new GammaParticle(314000.0, 0.00395) }, { 0.00018999999999999998d, new GammaParticle(331700.0, 0.00374) }, { 0.00054d, new GammaParticle(360000.0, 0.00344) }, { 0.00052d, new GammaParticle(396550.0, 0.00313) }, { 0.0017000000000000001d, new GammaParticle(423500.0, 0.00293) }, { 0.0004d, new GammaParticle(437850.0, 0.00283) }, { 0.019d, new GammaParticle(458250.0, 0.00271) }, { 0.0014000000000000002d, new GammaParticle(472800.0, 0.00262) }, { 8.999999999999999e-05d, new GammaParticle(484500.0, 0.00256) }, { 0.00041d, new GammaParticle(488700.0, 0.00254) }, { 0.0016d, new GammaParticle(496150.0, 0.0025) }, { 0.0013d, new GammaParticle(521900.0, 0.00238) }, { 0.0007199999999999999d, new GammaParticle(540000.0, 0.0023) }, { 0.009300000000000001d, new GammaParticle(570950.0, 0.00217) }, { 0.00043d, new GammaParticle(591900.0, 0.00209) }, { 0.0008500000000000001d, new GammaParticle(598200.0, 0.00207) }, { 0.009300000000000001d, new GammaParticle(648700.0, 0.00191) }, { 0.00037999999999999997d, new GammaParticle(673000.0, 0.00184) }, { 0.00018999999999999998d, new GammaParticle(689000.0, 0.0018) }, { 0.0032d, new GammaParticle(696250.0, 0.00178) }, { 0.0007599999999999999d, new GammaParticle(721200.0, 0.00172) }, { 0.0018d, new GammaParticle(756600.0, 0.00164) }, { 0.006d, new GammaParticle(761400.0, 0.00163) }, { 0.0037d, new GammaParticle(767300.0, 0.00162) }, { 0.00015d, new GammaParticle(796000.0, 0.00156) }, { 0.0015d, new GammaParticle(804200.0, 0.00154) }, { 6.6e-05d, new GammaParticle(828000.0, 0.0015) }, { 0.00017d, new GammaParticle(837000.0, 0.00148) }, { 0.00053d, new GammaParticle(879650.0, 0.00141) }, { 0.00066d, new GammaParticle(911900.0, 0.00136) }, { 0.0033d, new GammaParticle(914150.0, 0.00136) }, { 0.0031d, new GammaParticle(957750.0, 0.00129) }, { 0.0014000000000000002d, new GammaParticle(964050.0, 0.00129) }, { 0.0031d, new GammaParticle(980150.0, 0.00126) }, { 0.0033d, new GammaParticle(994600.0, 0.00125) }, { 0.00010999999999999999d, new GammaParticle(1164500.0, 0.00106) }, { 0.0026d, new GammaParticle(1198050.0, 0.00103) }, { 0.0005099999999999999d, new GammaParticle(1202500.0, 0.00103) }, { 0.034462913778176d, new GammaParticle(13686.0, 0.09059) }, { 0.014187271041474506d, new GammaParticle(78947.0, 0.0157) }, { 0.023516113113665683d, new GammaParticle(81517.0, 0.01521) }, { 0.008142784106509364d, new GammaParticle(92333.0, 0.01343) }, { 0.01070776110005981d, new GammaParticle(93473.0, 0.01326) }, { 0.0025649769935504494d, new GammaParticle(94897.0, 0.01307) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    