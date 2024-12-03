using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Rhenium184m : RadioactiveSubstance
    {
        public override string name { get; } = "Rhenium184m";
        public override double halfLife { get; } = 14601600.0d;
        public override double atomicWeight { get; } = 183.95273d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.745d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Rhenium184()), new(5.53e-05d, new GammaParticle(83306.7, 0.01488)), new(0.136d, new GammaParticle(104739.5, 0.01184)), new(2.093e-06d, new GammaParticle(188046.2, 0.00659)), new(0.300497574575251d, new GammaParticle(10063.0, 0.12321)), new(0.13922423502399225d, new GammaParticle(59718.0, 0.02076)), new(0.24087237893424263d, new GammaParticle(61141.0, 0.02028)), new(0.08006733684789756d, new GammaParticle(69395.0, 0.01787)), new(0.10224598915476518d, new GammaParticle(70206.0, 0.01766)), new(0.02217865230686762d, new GammaParticle(71195.0, 0.01741)) } },
            { 0.255d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Tungsten184()), new(0.023305d, new GammaParticle(55279.0, 0.02243)), new(0.0037524999999999998d, new GammaParticle(63689.0, 0.01947)), new(0.0024095d, new GammaParticle(87452.0, 0.01418)), new(0.0025675d, new GammaParticle(91270.0, 0.01358)), new(0.05846d, new GammaParticle(111217.4, 0.01115)), new(0.0014615000000000001d, new GammaParticle(124060.0, 0.00999)), new(5.925e-06d, new GammaParticle(127670.0, 0.00971)), new(0.0004898d, new GammaParticle(151134.0, 0.0082)), new(0.06557d, new GammaParticle(161269.0, 0.00769)), new(0.028045d, new GammaParticle(215326.0, 0.00576)), new(0.095195d, new GammaParticle(216547.0, 0.00573)), new(0.0148915d, new GammaParticle(226748.0, 0.00547)), new(5.135e-05d, new GammaParticle(230450.0, 0.00538)), new(0.107835d, new GammaParticle(252845.0, 0.0049)), new(8.295000000000001e-06d, new GammaParticle(279000.0, 0.00444)), new(0.058065d, new GammaParticle(318008.0, 0.0039)), new(0.0006320000000000001d, new GammaParticle(381820.0, 0.00325)), new(0.0316395d, new GammaParticle(384250.0, 0.00323)), new(1.9750000000000002e-05d, new GammaParticle(385530.0, 0.00322)), new(0.033338d, new GammaParticle(536674.0, 0.00231)), new(0.00031995000000000005d, new GammaParticle(539220.0, 0.0023)), new(0.0034365000000000003d, new GammaParticle(641915.0, 0.00193)), new(0.0023699999999999997d, new GammaParticle(769778.0, 0.00161)), new(0.036892999999999995d, new GammaParticle(792067.0, 0.00157)), new(0.0016392499999999999d, new GammaParticle(857250.0, 0.00145)), new(0.0276105d, new GammaParticle(894760.0, 0.00139)), new(0.037367d, new GammaParticle(903282.0, 0.00137)), new(0.08216d, new GammaParticle(920933.0, 0.00135)), new(0.000948d, new GammaParticle(1018930.0, 0.00122)), new(0.001817d, new GammaParticle(1022630.0, 0.00121)), new(0.0058855d, new GammaParticle(1110082.0, 0.00112)), new(0.012244999999999999d, new GammaParticle(1173770.0, 0.00106)), new(0.00020145d, new GammaParticle(1221290.0, 0.00102)), new(0.165d, new GammaParticle(9740.0, 0.12729)), new(0.08199999999999999d, new GammaParticle(57983.0, 0.02138)), new(0.14300000000000002d, new GammaParticle(59320.0, 0.0209)), new(0.0475d, new GammaParticle(67335.0, 0.01841)), new(0.06d, new GammaParticle(68117.0, 0.0182)), new(0.013000000000000001d, new GammaParticle(69068.0, 0.01795)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    