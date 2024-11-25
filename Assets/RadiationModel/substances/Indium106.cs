using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Indium106 : RadioactiveSubstance
    {
        public override string name { get; } = "Indium106";
        public override double halfLife { get; } = 372.0d;
        public override double atomicWeight { get; } = 105.91346d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Silver106() }, { 1.0d, new BetaParticle(1, 3167000.0) }, { 0.004985d, new GammaParticle(161000.0, 0.0077) }, { 0.0059819999999999995d, new GammaParticle(186600.0, 0.00664) }, { 0.06879299999999999d, new GammaParticle(225700.0, 0.00549) }, { 0.022931d, new GammaParticle(433100.0, 0.00286) }, { 0.018943d, new GammaParticle(524600.0, 0.00236) }, { 0.124625d, new GammaParticle(541000.0, 0.00229) }, { 0.251244d, new GammaParticle(552400.0, 0.00224) }, { 0.021934d, new GammaParticle(558600.0, 0.00222) }, { 0.006979d, new GammaParticle(580700.0, 0.00214) }, { 0.029910000000000003d, new GammaParticle(592100.0, 0.00209) }, { 0.035892d, new GammaParticle(610700.0, 0.00203) }, { 0.017946d, new GammaParticle(623200.0, 0.00199) }, { 0.997d, new GammaParticle(632600.0, 0.00196) }, { 0.00997d, new GammaParticle(634100.0, 0.00196) }, { 0.024925000000000003d, new GammaParticle(753300.0, 0.00165) }, { 0.0127616d, new GammaParticle(811100.0, 0.00153) }, { 0.027916d, new GammaParticle(836700.0, 0.00148) }, { 0.8973d, new GammaParticle(861100.0, 0.00144) }, { 0.015952d, new GammaParticle(974600.0, 0.00127) }, { 0.014955000000000001d, new GammaParticle(992100.0, 0.00125) }, { 0.41375500000000004d, new GammaParticle(997800.0, 0.00124) }, { 0.274175d, new GammaParticle(1009300.0, 0.00123) }, { 0.0059819999999999995d, new GammaParticle(1135200.0, 0.00109) }, { 0.026919d, new GammaParticle(1139000.0, 0.00109) }, { 0.038883d, new GammaParticle(1145000.0, 0.00108) }, { 0.011963999999999999d, new GammaParticle(1430800.0, 0.00087) }, { 0.065802d, new GammaParticle(1471900.0, 0.00084) }, { 0.0018942999999999998d, new GammaParticle(1672600.0, 0.00074) }, { 0.014955000000000001d, new GammaParticle(1780100.0, 0.0007) }, { 0.003988d, new GammaParticle(1790400.0, 0.00069) }, { 0.008973d, new GammaParticle(1853000.0, 0.00067) }, { 2.0952d, new GammaParticle(511000.0, 0.00243) }, { 0.0005558321554057804d, new GammaParticle(3388.0, 0.36595) }, { 0.0020694985693396955d, new GammaParticle(22983.0, 0.05395) }, { 0.003892229771186187d, new GammaParticle(23173.0, 0.0535) }, { 0.0010849135076540757d, new GammaParticle(26184.0, 0.04735) }, { 0.0012823677660471174d, new GammaParticle(26381.0, 0.047) }, { 0.00019745425839304178d, new GammaParticle(26641.0, 0.04654) } } },

        };
    }
}
    