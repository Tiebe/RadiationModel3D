using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Francium221 : RadioactiveSubstance
    {
        public override string name { get; } = "Francium221";
        public override double halfLife { get; } = 294.0d;
        public override double atomicWeight { get; } = 221.01425d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Astatine217()), new(1.0d, new AlphaParticle(7479002.09)), new(0.00014000000000000001d, new GammaParticle(53800.0, 0.02305)), new(5.1000000000000006e-05d, new GammaParticle(68110.0, 0.0182)), new(7.000000000000001e-05d, new GammaParticle(96300.0, 0.01287)), new(0.0014099999999999998d, new GammaParticle(100200.0, 0.01237)), new(0.00023d, new GammaParticle(117800.0, 0.01052)), new(0.000448d, new GammaParticle(150000.0, 0.00827)), new(0.000774d, new GammaParticle(171600.0, 0.00723)), new(1.14e-05d, new GammaParticle(201400.0, 0.00616)), new(5.1000000000000006e-05d, new GammaParticle(208300.0, 0.00595)), new(0.1144d, new GammaParticle(218000.0, 0.00569)), new(3.4e-05d, new GammaParticle(250700.0, 0.00495)), new(6.7e-05d, new GammaParticle(253150.0, 0.0049)), new(2.2000000000000003e-05d, new GammaParticle(263390.0, 0.00471)), new(3.5000000000000004e-05d, new GammaParticle(271910.0, 0.00456)), new(6.9e-06d, new GammaParticle(281900.0, 0.0044)), new(8.800000000000001e-05d, new GammaParticle(297110.0, 0.00417)), new(0.00015d, new GammaParticle(299590.0, 0.00414)), new(1.0300000000000001e-05d, new GammaParticle(310100.0, 0.004)), new(2.5e-05d, new GammaParticle(314110.0, 0.00395)), new(0.000174d, new GammaParticle(324000.0, 0.00383)), new(0.000386d, new GammaParticle(359000.0, 0.00345)), new(5.4999999999999995e-05d, new GammaParticle(368180.0, 0.00337)), new(0.000341d, new GammaParticle(381100.0, 0.00325)), new(0.001205d, new GammaParticle(410400.0, 0.00302)), new(1.06e-05d, new GammaParticle(437800.0, 0.00283)), new(1.7e-05d, new GammaParticle(446300.0, 0.00278)), new(1.6e-05d, new GammaParticle(469000.0, 0.00264)), new(1.0300000000000001e-05d, new GammaParticle(496200.0, 0.0025)), new(4.6e-05d, new GammaParticle(537500.0, 0.00231)), new(5.72e-06d, new GammaParticle(562300.0, 0.0022)), new(1.3e-05d, new GammaParticle(568500.0, 0.00218)), new(3.5000000000000004e-05d, new GammaParticle(576900.0, 0.00215)), new(4.58e-06d, new GammaParticle(652000.0, 0.0019)), new(6.8599999999999995e-06d, new GammaParticle(658000.0, 0.00188)), new(9.15e-06d, new GammaParticle(665000.0, 0.00186)), new(9.2e-06d, new GammaParticle(809300.0, 0.00153)), new(3.3e-06d, new GammaParticle(891900.0, 0.00139)), new(0.0209d, new GammaParticle(13686.0, 0.09059)), new(0.009000000000000001d, new GammaParticle(78947.0, 0.0157)), new(0.0149d, new GammaParticle(81517.0, 0.01521)), new(0.0052d, new GammaParticle(92333.0, 0.01343)), new(0.0068000000000000005d, new GammaParticle(93473.0, 0.01326)), new(0.0016300000000000002d, new GammaParticle(94897.0, 0.01307)) } },
            { 0.001d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Radium221()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    