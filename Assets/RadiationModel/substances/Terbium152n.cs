using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Terbium152n : RadioactiveSubstance
    {
        public override string name { get; } = "Terbium152n";
        public override double halfLife { get; } = 252.0d;
        public override double atomicWeight { get; } = 151.92462d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.789d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Terbium152()), new(0.0118d, new GammaParticle(48000.0, 0.02583)), new(0.07200000000000001d, new GammaParticle(58900.0, 0.02105)), new(0.00185d, new GammaParticle(65000.0, 0.01907)), new(0.0032300000000000002d, new GammaParticle(106600.0, 0.01163)), new(0.166d, new GammaParticle(159590.0, 0.00777)), new(0.042d, new GammaParticle(235400.0, 0.00527)), new(0.085d, new GammaParticle(277200.0, 0.00447)), new(0.598d, new GammaParticle(283290.0, 0.00438)), new(0.23062428649122002d, new GammaParticle(7118.0, 0.17418)), new(0.2280829684883758d, new GammaParticle(43743.0, 0.02834)), new(0.40897071631410403d, new GammaParticle(44481.0, 0.02787)), new(0.1305985353832566d, new GammaParticle(50494.0, 0.02455)), new(0.16442355604752007d, new GammaParticle(51040.0, 0.02429)), new(0.03382502066426346d, new GammaParticle(51699.0, 0.02398)) } },
            { 0.21100000000000002d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Europium152()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)), new(0.0029d, new GammaParticle(92400.0, 0.01342)), new(0.0029d, new GammaParticle(197400.0, 0.00628)), new(0.0043d, new GammaParticle(220700.0, 0.00562)), new(0.0036d, new GammaParticle(255400.0, 0.00485)), new(0.0008d, new GammaParticle(271000.0, 0.00458)), new(0.0006d, new GammaParticle(303700.0, 0.00408)), new(0.0008d, new GammaParticle(311400.0, 0.00398)), new(0.0014000000000000002d, new GammaParticle(315200.0, 0.00393)), new(0.2d, new GammaParticle(344260.0, 0.0036)), new(0.0181d, new GammaParticle(351700.0, 0.00353)), new(0.0327d, new GammaParticle(385900.0, 0.00321)), new(0.0013d, new GammaParticle(396400.0, 0.00313)), new(0.18100000000000002d, new GammaParticle(411100.0, 0.00302)), new(0.009300000000000001d, new GammaParticle(427600.0, 0.0029)), new(0.0036d, new GammaParticle(440200.0, 0.00282)), new(0.004d, new GammaParticle(440800.0, 0.00281)), new(0.0018d, new GammaParticle(441200.0, 0.00281)), new(0.00095d, new GammaParticle(447700.0, 0.00277)), new(0.0048d, new GammaParticle(470700.0, 0.00263)), new(0.11800000000000001d, new GammaParticle(471900.0, 0.00263)), new(0.047d, new GammaParticle(519400.0, 0.00239)), new(0.016399999999999998d, new GammaParticle(526800.0, 0.00235)), new(0.043d, new GammaParticle(532600.0, 0.00233)), new(0.0022d, new GammaParticle(579200.0, 0.00214)), new(0.0137d, new GammaParticle(586200.0, 0.00212)), new(0.009399999999999999d, new GammaParticle(634200.0, 0.00195)), new(0.043d, new GammaParticle(647400.0, 0.00192)), new(0.0034000000000000002d, new GammaParticle(652900.0, 0.0019)), new(0.0019d, new GammaParticle(678600.0, 0.00183)), new(0.0058d, new GammaParticle(715000.0, 0.00173)), new(0.0315d, new GammaParticle(726000.0, 0.00171)), new(0.00012d, new GammaParticle(764600.0, 0.00162)), new(0.00155d, new GammaParticle(770400.0, 0.00161)), new(0.0007000000000000001d, new GammaParticle(778900.0, 0.00159)), new(0.0018d, new GammaParticle(794300.0, 0.00156)), new(0.0027d, new GammaParticle(930400.0, 0.00133)), new(0.0048d, new GammaParticle(946000.0, 0.00131)), new(0.0013700000000000001d, new GammaParticle(1041000.0, 0.00119)), new(0.0007000000000000001d, new GammaParticle(1052200.0, 0.00118)), new(0.0066d, new GammaParticle(1074500.0, 0.00115)), new(0.0067d, new GammaParticle(1089700.0, 0.00114)), new(0.027999999999999997d, new GammaParticle(1106200.0, 0.00112)), new(0.0003d, new GammaParticle(1109300.0, 0.00112)), new(0.037000000000000005d, new GammaParticle(1166900.0, 0.00106)), new(0.0006d, new GammaParticle(1205900.0, 0.00103)), new(0.00101d, new GammaParticle(1242600.0, 0.001)), new(0.022639999999999997d, new GammaParticle(511000.0, 0.00243)), new(0.0305d, new GammaParticle(6858.0, 0.18079)), new(0.045d, new GammaParticle(42308.0, 0.02931)), new(0.081d, new GammaParticle(42996.0, 0.02884)), new(0.025699999999999997d, new GammaParticle(48802.0, 0.02541)), new(0.0325d, new GammaParticle(49326.0, 0.02514)), new(0.0068000000000000005d, new GammaParticle(49957.0, 0.02482)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    