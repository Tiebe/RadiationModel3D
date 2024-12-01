using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Platinum191 : RadioactiveSubstance
    {
        public override string name { get; } = "Platinum191";
        public override double halfLife { get; } = 244512.0d;
        public override double atomicWeight { get; } = 190.96168d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Iridium191()), new(5.5e-07d, new GammaParticle(41930.0, 0.02957)), new(0.00035000000000000005d, new GammaParticle(49548.0, 0.02502)), new(0.047d, new GammaParticle(82400.0, 0.01505)), new(0.0005899999999999999d, new GammaParticle(85161.0, 0.01456)), new(0.031d, new GammaParticle(96551.7, 0.01284)), new(0.03d, new GammaParticle(129416.0, 0.00958)), new(0.00024d, new GammaParticle(138515.0, 0.00895)), new(0.00074d, new GammaParticle(140884.0, 0.0088)), new(1.58e-05d, new GammaParticle(160000.0, 0.00775)), new(0.035d, new GammaParticle(172218.1, 0.0072)), new(0.0101d, new GammaParticle(178979.6, 0.00693)), new(0.00031600000000000004d, new GammaParticle(186800.0, 0.00664)), new(0.0039000000000000003d, new GammaParticle(187720.8, 0.0066)), new(3.2e-05d, new GammaParticle(196000.0, 0.00633)), new(0.0012900000000000001d, new GammaParticle(208960.0, 0.00593)), new(8.7e-05d, new GammaParticle(214000.0, 0.00579)), new(0.0084d, new GammaParticle(219674.0, 0.00564)), new(0.00122d, new GammaParticle(221765.0, 0.00559)), new(0.00111d, new GammaParticle(223672.0, 0.00554)), new(3.2e-05d, new GammaParticle(245000.0, 0.00506)), new(0.0079d, new GammaParticle(267978.0, 0.00463)), new(0.0166d, new GammaParticle(268772.0, 0.00461)), new(0.000237d, new GammaParticle(272000.0, 0.00456)), new(6.33e-05d, new GammaParticle(308000.0, 0.00403)), new(0.000117d, new GammaParticle(343220.0, 0.00361)), new(0.035d, new GammaParticle(351187.0, 0.00353)), new(0.059000000000000004d, new GammaParticle(359930.0, 0.00344)), new(0.000119d, new GammaParticle(396750.0, 0.00312)), new(0.00010999999999999999d, new GammaParticle(404100.0, 0.00307)), new(0.00095d, new GammaParticle(409000.0, 0.00303)), new(0.079d, new GammaParticle(409462.0, 0.00303)), new(9.499999999999999e-05d, new GammaParticle(411398.0, 0.00301)), new(0.0005899999999999999d, new GammaParticle(445109.0, 0.00279)), new(6.33e-05d, new GammaParticle(448000.0, 0.00277)), new(0.035d, new GammaParticle(456485.0, 0.00272)), new(0.00057d, new GammaParticle(458546.0, 0.0027)), new(0.00052d, new GammaParticle(479941.7, 0.00258)), new(0.0005899999999999999d, new GammaParticle(494675.0, 0.00251)), new(0.14400000000000002d, new GammaParticle(538897.0, 0.0023)), new(0.0043d, new GammaParticle(541664.0, 0.00229)), new(0.0005600000000000001d, new GammaParticle(568850.0, 0.00218)), new(0.00124d, new GammaParticle(576492.0, 0.00215)), new(0.0007599999999999999d, new GammaParticle(583621.0, 0.00212)), new(0.00149d, new GammaParticle(587980.0, 0.00211)), new(8.2e-05d, new GammaParticle(618480.0, 0.002)), new(0.015d, new GammaParticle(624086.0, 0.00199)), new(0.00028000000000000003d, new GammaParticle(633186.0, 0.00196)), new(0.000168d, new GammaParticle(658760.0, 0.00188)), new(6.7e-05d, new GammaParticle(680240.0, 0.00182)), new(7.9e-06d, new GammaParticle(686600.0, 0.00181)), new(3.6e-05d, new GammaParticle(747760.0, 0.00166)), new(1.5e-05d, new GammaParticle(756500.0, 0.00164)), new(0.000135d, new GammaParticle(762740.0, 0.00163)), new(3.9e-05d, new GammaParticle(806400.0, 0.00154)), new(1.0399999999999999e-05d, new GammaParticle(853500.0, 0.00145)), new(0.000118d, new GammaParticle(935610.0, 0.00133)), new(0.49d, new GammaParticle(10728.0, 0.11557)), new(0.38d, new GammaParticle(63287.0, 0.01959)), new(0.65d, new GammaParticle(64896.0, 0.01911)), new(0.217d, new GammaParticle(73637.0, 0.01684)), new(0.28d, new GammaParticle(74510.0, 0.01664)), new(0.062d, new GammaParticle(75576.0, 0.01641)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    