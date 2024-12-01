using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Lutetium177p : RadioactiveSubstance
    {
        public override string name { get; } = "Lutetium177p";
        public override double halfLife { get; } = 13858560.0d;
        public override double atomicWeight { get; } = 176.94481d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.773d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Hafnium177()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)), new(0.001472d, new GammaParticle(14050.0, 0.08824)), new(0.01955d, new GammaParticle(55150.0, 0.02248)), new(9.900000000000001e-05d, new GammaParticle(69200.0, 0.01792)), new(0.00876d, new GammaParticle(71641.8, 0.01731)), new(0.00043d, new GammaParticle(88400.0, 0.01403)), new(0.1268d, new GammaParticle(105358.9, 0.01177)), new(0.214d, new GammaParticle(112949.8, 0.01098)), new(0.00194d, new GammaParticle(117144.2, 0.01058)), new(0.1604d, new GammaParticle(128502.7, 0.00965)), new(0.01452d, new GammaParticle(136724.5, 0.00907)), new(0.009649999999999999d, new GammaParticle(145769.3, 0.00851)), new(0.1654d, new GammaParticle(153284.2, 0.00809)), new(0.00534d, new GammaParticle(159734.1, 0.00776)), new(0.1247d, new GammaParticle(174398.8, 0.00711)), new(0.0363d, new GammaParticle(177000.7, 0.007)), new(0.00098d, new GammaParticle(181909.3, 0.00682)), new(0.00124d, new GammaParticle(203000.0, 0.00611)), new(0.1351d, new GammaParticle(204105.0, 0.00607)), new(0.5539999999999999d, new GammaParticle(208366.2, 0.00595)), new(0.0643d, new GammaParticle(214434.1, 0.00578)), new(0.000129d, new GammaParticle(223300.0, 0.00555)), new(0.359d, new GammaParticle(228483.8, 0.00543)), new(0.04650000000000001d, new GammaParticle(233861.5, 0.0053)), new(0.000578d, new GammaParticle(242100.0, 0.00512)), new(0.062400000000000004d, new GammaParticle(249674.2, 0.00497)), new(0.13970000000000002d, new GammaParticle(281786.8, 0.0044)), new(0.0041199999999999995d, new GammaParticle(283609.0, 0.00437)), new(0.010320000000000001d, new GammaParticle(291542.9, 0.00425)), new(0.008100000000000001d, new GammaParticle(292526.6, 0.00424)), new(0.0501d, new GammaParticle(296458.4, 0.00418)), new(0.0163d, new GammaParticle(299053.4, 0.00415)), new(0.01799d, new GammaParticle(305503.3, 0.00406)), new(0.01312d, new GammaParticle(313725.0, 0.00395)), new(0.01164d, new GammaParticle(321315.9, 0.00386)), new(0.1843d, new GammaParticle(327682.9, 0.00378)), new(0.0176d, new GammaParticle(341643.2, 0.00363)), new(0.294d, new GammaParticle(378503.6, 0.00328)), new(0.0317d, new GammaParticle(385030.4, 0.00322)), new(0.21719999999999998d, new GammaParticle(418538.8, 0.00296)), new(0.0048d, new GammaParticle(426472.6, 0.00291)), new(0.02471d, new GammaParticle(465841.6, 0.00266)), new(0.444286326760692d, new GammaParticle(9114.0, 0.13604)), new(0.33026103414747027d, new GammaParticle(54608.0, 0.0227)), new(0.5779857090435251d, new GammaParticle(55786.0, 0.02222)), new(0.19068163669203217d, new GammaParticle(63333.0, 0.01958)), new(0.24159363368880474d, new GammaParticle(64057.0, 0.01936)), new(0.05091199699677259d, new GammaParticle(64935.0, 0.01909)) } },
            { 0.22699999999999998d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Lutetium177()), new(0.00658d, new GammaParticle(115868.2, 0.0107)), new(0.0629d, new GammaParticle(121621.1, 0.01019)), new(2.2e-06d, new GammaParticle(125300.0, 0.00989)), new(0.0359d, new GammaParticle(147163.7, 0.00842)), new(0.048d, new GammaParticle(171857.4, 0.00721)), new(0.00855d, new GammaParticle(195560.2, 0.00634)), new(0.0337d, new GammaParticle(218103.8, 0.00568)), new(0.0349d, new GammaParticle(268784.7, 0.00461)), new(0.1051d, new GammaParticle(319021.0, 0.00389)), new(1.8e-05d, new GammaParticle(333100.0, 0.00372)), new(1.838e-05d, new GammaParticle(334000.0, 0.00371)), new(0.0313d, new GammaParticle(367417.4, 0.00337)), new(0.17620000000000002d, new GammaParticle(413663.7, 0.003)), new(0.086d, new GammaParticle(8810.0, 0.14073)), new(0.053d, new GammaParticle(52965.0, 0.02341)), new(0.09300000000000001d, new GammaParticle(54070.0, 0.02293)), new(0.030600000000000002d, new GammaParticle(61387.0, 0.0202)), new(0.0387d, new GammaParticle(62084.0, 0.01997)), new(0.008100000000000001d, new GammaParticle(62927.0, 0.0197)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    