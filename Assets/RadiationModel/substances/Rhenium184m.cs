using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhenium184m : RadioactiveSubstance
    {
        public override string name { get; } = "Rhenium184m";
        public override double halfLife { get; } = 14601600.0d;
        public override double atomicWeight { get; } = 183.95273d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.745d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Rhenium184() }, { 5.53e-05d, new GammaParticle(83306.7, 0.01488) }, { 0.136d, new GammaParticle(104739.5, 0.01184) }, { 2.093e-06d, new GammaParticle(188046.2, 0.00659) }, { 0.300497574575251d, new GammaParticle(10063.0, 0.12321) }, { 0.13922423502399225d, new GammaParticle(59718.0, 0.02076) }, { 0.24087237893424263d, new GammaParticle(61141.0, 0.02028) }, { 0.08006733684789756d, new GammaParticle(69395.0, 0.01787) }, { 0.10224598915476518d, new GammaParticle(70206.0, 0.01766) }, { 0.02217865230686762d, new GammaParticle(71195.0, 0.01741) } } },
            { 0.255d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Tungsten184() }, { 0.023305d, new GammaParticle(55279.0, 0.02243) }, { 0.0037524999999999998d, new GammaParticle(63689.0, 0.01947) }, { 0.0024095d, new GammaParticle(87452.0, 0.01418) }, { 0.0025675d, new GammaParticle(91270.0, 0.01358) }, { 0.05846d, new GammaParticle(111217.4, 0.01115) }, { 0.0014615000000000001d, new GammaParticle(124060.0, 0.00999) }, { 5.925e-06d, new GammaParticle(127670.0, 0.00971) }, { 0.0004898d, new GammaParticle(151134.0, 0.0082) }, { 0.06557d, new GammaParticle(161269.0, 0.00769) }, { 0.028045d, new GammaParticle(215326.0, 0.00576) }, { 0.095195d, new GammaParticle(216547.0, 0.00573) }, { 0.0148915d, new GammaParticle(226748.0, 0.00547) }, { 5.135e-05d, new GammaParticle(230450.0, 0.00538) }, { 0.107835d, new GammaParticle(252845.0, 0.0049) }, { 8.295000000000001e-06d, new GammaParticle(279000.0, 0.00444) }, { 0.058065d, new GammaParticle(318008.0, 0.0039) }, { 0.0006320000000000001d, new GammaParticle(381820.0, 0.00325) }, { 0.0316395d, new GammaParticle(384250.0, 0.00323) }, { 1.9750000000000002e-05d, new GammaParticle(385530.0, 0.00322) }, { 0.033338d, new GammaParticle(536674.0, 0.00231) }, { 0.00031995000000000005d, new GammaParticle(539220.0, 0.0023) }, { 0.0034365000000000003d, new GammaParticle(641915.0, 0.00193) }, { 0.0023699999999999997d, new GammaParticle(769778.0, 0.00161) }, { 0.036892999999999995d, new GammaParticle(792067.0, 0.00157) }, { 0.0016392499999999999d, new GammaParticle(857250.0, 0.00145) }, { 0.0276105d, new GammaParticle(894760.0, 0.00139) }, { 0.037367d, new GammaParticle(903282.0, 0.00137) }, { 0.08216d, new GammaParticle(920933.0, 0.00135) }, { 0.000948d, new GammaParticle(1018930.0, 0.00122) }, { 0.001817d, new GammaParticle(1022630.0, 0.00121) }, { 0.0058855d, new GammaParticle(1110082.0, 0.00112) }, { 0.012244999999999999d, new GammaParticle(1173770.0, 0.00106) }, { 0.00020145d, new GammaParticle(1221290.0, 0.00102) }, { 0.165d, new GammaParticle(9740.0, 0.12729) }, { 0.08199999999999999d, new GammaParticle(57983.0, 0.02138) }, { 0.14300000000000002d, new GammaParticle(59320.0, 0.0209) }, { 0.0475d, new GammaParticle(67335.0, 0.01841) }, { 0.06d, new GammaParticle(68117.0, 0.0182) }, { 0.013000000000000001d, new GammaParticle(69068.0, 0.01795) } } },

        };
    }
}
    