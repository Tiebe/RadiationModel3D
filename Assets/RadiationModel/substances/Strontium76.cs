using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Strontium76 : RadioactiveSubstance
    {
        public override string name { get; } = "Strontium76";
        public override double halfLife { get; } = 7.89d;
        public override double atomicWeight { get; } = 75.94176d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Krypton76() }, { 1.0d, new BetaParticle(1, 7382000.0) }, { 0.14d, new GammaParticle(39000.0, 0.03179) }, { 0.29d, new GammaParticle(101400.0, 0.01223) }, { 0.033d, new GammaParticle(145200.0, 0.00854) }, { 0.013000000000000001d, new GammaParticle(192400.0, 0.00644) }, { 0.035d, new GammaParticle(230300.0, 0.00538) }, { 0.011000000000000001d, new GammaParticle(246600.0, 0.00503) }, { 0.15d, new GammaParticle(375400.0, 0.0033) }, { 0.07400000000000001d, new GammaParticle(414600.0, 0.00299) }, { 0.012d, new GammaParticle(453000.0, 0.00274) }, { 0.013000000000000001d, new GammaParticle(466900.0, 0.00266) }, { 0.49d, new GammaParticle(476800.0, 0.0026) }, { 0.028999999999999998d, new GammaParticle(494000.0, 0.00251) }, { 0.057999999999999996d, new GammaParticle(506100.0, 0.00245) }, { 0.034d, new GammaParticle(515800.0, 0.0024) }, { 0.023d, new GammaParticle(550100.0, 0.00225) }, { 0.0064d, new GammaParticle(563700.0, 0.0022) }, { 0.032d, new GammaParticle(580800.0, 0.00213) }, { 0.004d, new GammaParticle(608000.0, 0.00204) }, { 0.0033d, new GammaParticle(657300.0, 0.00189) }, { 0.005d, new GammaParticle(679700.0, 0.00182) }, { 0.009399999999999999d, new GammaParticle(707800.0, 0.00175) }, { 0.0048d, new GammaParticle(726800.0, 0.00171) }, { 0.012d, new GammaParticle(812800.0, 0.00153) }, { 0.053d, new GammaParticle(881600.0, 0.00141) }, { 0.0087d, new GammaParticle(935900.0, 0.00132) }, { 0.11d, new GammaParticle(982900.0, 0.00126) }, { 0.004699999999999999d, new GammaParticle(1124000.0, 0.0011) }, { 0.013000000000000001d, new GammaParticle(1171200.0, 0.00106) }, { 0.0026d, new GammaParticle(1187000.0, 0.00104) }, { 0.0059d, new GammaParticle(1432100.0, 0.00087) }, { 0.0032d, new GammaParticle(1471300.0, 0.00084) }, { 0.013000000000000001d, new GammaParticle(1546000.0, 0.0008) }, { 0.0028000000000000004d, new GammaParticle(1568300.0, 0.00079) }, { 0.0059d, new GammaParticle(1584900.0, 0.00078) }, { 0.0036d, new GammaParticle(1592700.0, 0.00078) }, { 0.0038d, new GammaParticle(1612500.0, 0.00077) }, { 0.011000000000000001d, new GammaParticle(1624400.0, 0.00076) }, { 0.0028000000000000004d, new GammaParticle(1657000.0, 0.00075) }, { 0.0048d, new GammaParticle(1695700.0, 0.00073) }, { 0.013000000000000001d, new GammaParticle(1805000.0, 0.00069) }, { 0.0033d, new GammaParticle(2039000.0, 0.00061) }, { 0.0017000000000000001d, new GammaParticle(2140500.0, 0.00058) }, { 0.002d, new GammaParticle(2172500.0, 0.00057) }, { 0.0036d, new GammaParticle(2248900.0, 0.00055) }, { 0.0013d, new GammaParticle(2499900.0, 0.0005) }, { 0.001d, new GammaParticle(2684500.0, 0.00046) }, { 0.0037d, new GammaParticle(2719100.0, 0.00046) }, { 0.0038d, new GammaParticle(2934600.0, 0.00042) }, { 2.1386000000000003d, new GammaParticle(511000.0, 0.00243) }, { 0.0096d, new GammaParticle(1767.0, 0.70166) }, { 0.064d, new GammaParticle(13336.0, 0.09297) }, { 0.12300000000000001d, new GammaParticle(13396.0, 0.09255) }, { 0.03d, new GammaParticle(15021.0, 0.08254) }, { 0.033d, new GammaParticle(15070.0, 0.08227) }, { 0.0034999999999999996d, new GammaParticle(15187.0, 0.08164) } } },
            { 3.4e-05d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Krypton75() }, { 1.0d, new ProtonParticle() } } },

        };
    }
}
    