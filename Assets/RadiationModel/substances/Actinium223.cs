using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Actinium223 : RadioactiveSubstance
    {
        public override string name { get; } = "Actinium223";
        public override double halfLife { get; } = 126.0d;
        public override double atomicWeight { get; } = 223.01914d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.99d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Francium219()), new(1.0d, new AlphaParticle(7805002.09)), new(2.48e-05d, new GammaParticle(15000.0, 0.08266)), new(0.00028000000000000003d, new GammaParticle(35700.0, 0.03473)), new(0.00024d, new GammaParticle(41150.0, 0.03013)), new(0.00013d, new GammaParticle(42400.0, 0.02924)), new(0.00037999999999999997d, new GammaParticle(56950.0, 0.02177)), new(2.8e-06d, new GammaParticle(64400.0, 0.01925)), new(0.00010999999999999999d, new GammaParticle(66000.0, 0.01879)), new(2.48e-06d, new GammaParticle(72800.0, 0.01703)), new(4e-06d, new GammaParticle(72800.0, 0.01703)), new(0.00054d, new GammaParticle(78250.0, 0.01584)), new(0.0001d, new GammaParticle(82400.0, 0.01505)), new(0.005699999999999999d, new GammaParticle(83550.0, 0.01484)), new(0.0005d, new GammaParticle(89600.0, 0.01384)), new(0.00386d, new GammaParticle(92710.0, 0.01337)), new(0.00891d, new GammaParticle(98580.0, 0.01258)), new(0.0004d, new GammaParticle(101100.0, 0.01226)), new(0.00109d, new GammaParticle(119400.0, 0.01038)), new(0.00089d, new GammaParticle(124800.0, 0.00993)), new(9.900000000000001e-05d, new GammaParticle(126400.0, 0.00981)), new(0.0002d, new GammaParticle(130500.0, 0.0095)), new(9.900000000000001e-05d, new GammaParticle(134600.0, 0.00921)), new(0.0002d, new GammaParticle(171700.0, 0.00722)), new(0.00109d, new GammaParticle(176300.0, 0.00703)), new(0.0058d, new GammaParticle(191300.0, 0.00648)), new(0.0011899999999999999d, new GammaParticle(195400.0, 0.00635)), new(0.0003d, new GammaParticle(199300.0, 0.00622)), new(0.0004d, new GammaParticle(205700.0, 0.00603)), new(0.0019d, new GammaParticle(207000.0, 0.00599)), new(0.0037d, new GammaParticle(216000.0, 0.00574)), new(0.0004d, new GammaParticle(216100.0, 0.00574)), new(0.0006900000000000001d, new GammaParticle(229700.0, 0.0054)), new(0.0006900000000000001d, new GammaParticle(238100.0, 0.00521)), new(0.00178d, new GammaParticle(241700.0, 0.00513)), new(0.0006900000000000001d, new GammaParticle(254400.0, 0.00487)), new(0.00099d, new GammaParticle(269200.0, 0.00461)), new(0.0005d, new GammaParticle(274000.0, 0.00452)), new(0.0003d, new GammaParticle(279800.0, 0.00443)), new(0.00198d, new GammaParticle(284200.0, 0.00436)), new(0.0012900000000000001d, new GammaParticle(285700.0, 0.00434)), new(0.0003d, new GammaParticle(299100.0, 0.00415)), new(0.00178d, new GammaParticle(305500.0, 0.00406)), new(0.0001d, new GammaParticle(315200.0, 0.00393)), new(0.0005d, new GammaParticle(325300.0, 0.00381)), new(0.0011d, new GammaParticle(333500.0, 0.00372)), new(0.0005d, new GammaParticle(341000.0, 0.00364)), new(0.0018d, new GammaParticle(357400.0, 0.00347)), new(0.0016d, new GammaParticle(372400.0, 0.00333)), new(0.0005899999999999999d, new GammaParticle(374800.0, 0.00331)), new(0.0052d, new GammaParticle(434200.0, 0.00286)), new(0.0004d, new GammaParticle(462200.0, 0.00268)), new(0.0027d, new GammaParticle(475200.0, 0.00261)), new(0.0003d, new GammaParticle(506600.0, 0.00245)), new(0.0009d, new GammaParticle(518800.0, 0.00239)), new(0.0003d, new GammaParticle(530000.0, 0.00234)), new(0.083d, new GammaParticle(14500.0, 0.08551)), new(0.005268398816305081d, new GammaParticle(83227.0, 0.0149)), new(0.008648061090454828d, new GammaParticle(86102.0, 0.0144)), new(0.0030166344359819435d, new GammaParticle(97469.0, 0.01272)), new(0.003994023993240094d, new GammaParticle(98682.0, 0.01256)), new(0.0009773895572581497d, new GammaParticle(100209.0, 0.01237)) } },
            { 0.01d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Radium223()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    