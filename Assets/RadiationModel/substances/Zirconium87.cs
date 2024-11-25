using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Zirconium87 : RadioactiveSubstance
    {
        public override string name { get; } = "Zirconium87";
        public override double halfLife { get; } = 6048.0d;
        public override double atomicWeight { get; } = 86.91482d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Strontium87() }, { 1.0d, new BetaParticle(1, 2766538.0) }, { 0.0011200000000000001d, new GammaParticle(611000.0, 0.00203) }, { 0.0005600000000000001d, new GammaParticle(633000.0, 0.00196) }, { 0.0022400000000000002d, new GammaParticle(772000.0, 0.00161) }, { 0.0028000000000000004d, new GammaParticle(794000.0, 0.00156) }, { 0.00168d, new GammaParticle(797000.0, 0.00156) }, { 0.0005600000000000001d, new GammaParticle(836000.0, 0.00148) }, { 0.0011200000000000001d, new GammaParticle(973000.0, 0.00127) }, { 0.00784d, new GammaParticle(1024000.0, 0.00121) }, { 0.0005600000000000001d, new GammaParticle(1048000.0, 0.00118) }, { 0.0022400000000000002d, new GammaParticle(1159000.0, 0.00107) }, { 0.0014000000000000002d, new GammaParticle(1203000.0, 0.00103) }, { 0.009212d, new GammaParticle(1210000.0, 0.00102) }, { 0.00084d, new GammaParticle(1216000.0, 0.00102) }, { 0.027999999999999997d, new GammaParticle(1227000.0, 0.00101) }, { 0.00084d, new GammaParticle(1388000.0, 0.00089) }, { 0.0011200000000000001d, new GammaParticle(1400000.0, 0.00089) }, { 0.00028000000000000003d, new GammaParticle(1410000.0, 0.00088) }, { 0.00084d, new GammaParticle(1657000.0, 0.00075) }, { 0.00028000000000000003d, new GammaParticle(1692000.0, 0.00073) }, { 0.00084d, new GammaParticle(1808000.0, 0.00069) }, { 0.00084d, new GammaParticle(1821000.0, 0.00068) }, { 0.0005600000000000001d, new GammaParticle(1857000.0, 0.00067) }, { 0.00028000000000000003d, new GammaParticle(1862000.0, 0.00067) }, { 0.0005600000000000001d, new GammaParticle(2172000.0, 0.00057) }, { 0.00084d, new GammaParticle(2183000.0, 0.00057) }, { 0.00252d, new GammaParticle(2222000.0, 0.00056) }, { 0.00084d, new GammaParticle(2615000.0, 0.00047) }, { 0.0005600000000000001d, new GammaParticle(2883000.0, 0.00043) }, { 1.637408d, new GammaParticle(511000.0, 0.00243) }, { 0.0054973095950432d, new GammaParticle(2027.0, 0.61166) }, { 0.03276361686241494d, new GammaParticle(14883.0, 0.08331) }, { 0.06282572744470746d, new GammaParticle(14958.0, 0.08289) }, { 0.015774761740665725d, new GammaParticle(16803.0, 0.07379) }, { 0.01795167886087759d, new GammaParticle(16880.0, 0.07345) }, { 0.00217691712021187d, new GammaParticle(17011.0, 0.07288) } } },

        };
    }
}
    