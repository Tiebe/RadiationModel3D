using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Iodine130m : RadioactiveSubstance
    {
        public override string name { get; } = "Iodine130m";
        public override double halfLife { get; } = 530.4d;
        public override double atomicWeight { get; } = 129.90671d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.84d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Iodine130()), new(0.00017d, new GammaParticle(39960.0, 0.03103)), new(0.06151317984d, new GammaParticle(4335.0, 0.28601)), new(0.051031127355699306d, new GammaParticle(28318.0, 0.04378)), new(0.09478292599498385d, new GammaParticle(28613.0, 0.04333)), new(0.027307427935821253d, new GammaParticle(32395.0, 0.03827)), new(0.03347890664931685d, new GammaParticle(32680.0, 0.03794)), new(0.006171478713495603d, new GammaParticle(33040.0, 0.03753)) } },
            { 0.16d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Xenon130()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)), new(1.1000000000000001e-05d, new GammaParticle(352270.0, 0.00352)), new(3.4e-06d, new GammaParticle(427930.0, 0.0029)), new(3.6e-05d, new GammaParticle(510350.0, 0.00243)), new(0.157d, new GammaParticle(536066.0, 0.00231)), new(0.010700000000000001d, new GammaParticle(586049.0, 0.00212)), new(2e-06d, new GammaParticle(603500.0, 0.00205)), new(0.00010800000000000001d, new GammaParticle(668540.0, 0.00185)), new(3.4e-06d, new GammaParticle(685990.0, 0.00181)), new(8e-06d, new GammaParticle(837030.0, 0.00148)), new(8e-06d, new GammaParticle(946000.0, 0.00131)), new(0.00039d, new GammaParticle(1028110.0, 0.00121)), new(2.5e-05d, new GammaParticle(1096480.0, 0.00113)), new(0.00168d, new GammaParticle(1122150.0, 0.0011)), new(1.3e-05d, new GammaParticle(1174220.0, 0.00106)), new(2e-05d, new GammaParticle(1263500.0, 0.00098)), new(2.5e-06d, new GammaParticle(1272120.0, 0.00097)), new(0.00035999999999999997d, new GammaParticle(1380150.0, 0.0009)), new(0.000107d, new GammaParticle(1440180.0, 0.00086)), new(0.0045000000000000005d, new GammaParticle(1614100.0, 0.00077)), new(0.00029d, new GammaParticle(1759970.0, 0.0007)), new(1.7e-05d, new GammaParticle(1849300.0, 0.00067)), new(0.00018999999999999998d, new GammaParticle(1958020.0, 0.00063)), new(0.00052d, new GammaParticle(1966040.0, 0.00063)), new(2.3999999999999997e-05d, new GammaParticle(1989100.0, 0.00062)), new(4.4999999999999996e-05d, new GammaParticle(2008350.0, 0.00062)), new(4.2000000000000004e-06d, new GammaParticle(2029300.0, 0.00061)), new(5e-05d, new GammaParticle(2092290.0, 0.00059)), new(9.900000000000001e-05d, new GammaParticle(2101420.0, 0.00059)), new(0.00010200000000000001d, new GammaParticle(2108800.0, 0.00059)), new(0.00021d, new GammaParticle(2150150.0, 0.00058)), new(3.8e-05d, new GammaParticle(2296210.0, 0.00054)), new(2.2000000000000003e-05d, new GammaParticle(2307760.0, 0.00054)), new(0.000132d, new GammaParticle(2502200.0, 0.0005)), new(5.199999999999999e-06d, new GammaParticle(2544000.0, 0.00049)), new(8.8e-06d, new GammaParticle(2762600.0, 0.00045)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    